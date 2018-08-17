using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace DecodeLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetMessage()
        {
            message.Text = "";
        }

        private void txtBoxLog_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxLog.Text))
            {
                var log = txtBoxLog.Text;
                var apiUrl = log.GetApiUrl();
                txtBoxApiUrl.Text = apiUrl;
                textBox1.Text = log.DecodeXmlLog().DecodeJsonLog().NormalizeLog();

                if (txtBoxLog.Text.Contains("<?xml"))
                {
                    textBox1.Text = FormatXml(textBox1.Text);
                    selectFormat.SelectedItem = selectFormat.Items[1];
                }
                else
                {
                    try
                    {
                        selectFormat.SelectedItem = selectFormat.Items[0];
                        textBox1.Text = FormatJson(textBox1.Text);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void decodeLog_Click(object sender, EventArgs e)
        {
            ResetMessage();

            var log = txtBoxLog.Text;
            var apiUrl = log.GetApiUrl();
            txtBoxApiUrl.Text = apiUrl;
            textBox1.Text = log.DecodeXmlLog().DecodeJsonLog().NormalizeLog();
        }


        private void btnFormatXML_Click(object sender, EventArgs e)
        {
            ResetMessage();
            textBox1.Text = FormatXml(textBox1.Text);
        }


        private void btnFormatJson_Click(object sender, EventArgs e)
        {
            ResetMessage();

            try
            {
                textBox1.Text = FormatJson(textBox1.Text);
            }
            catch (Exception ex)
            {
                message.Text = $"Invalid JSON object. {ex}";
            }
        }

        private string FormatXml(string xml)
        {
            var mStream = new MemoryStream();
            var writer = new XmlTextWriter(mStream, Encoding.Unicode);
            var document = new XmlDocument();

            var formated = "";
            try
            {
                document.LoadXml(xml);

                writer.Formatting = System.Xml.Formatting.Indented;

                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                mStream.Position = 0;

                StreamReader sReader = new StreamReader(mStream);

                string formattedXml = sReader.ReadToEnd();

                return formated = formattedXml;
            }
            catch (XmlException ex)
            {
                textBox1.Text = $"Invalid XML object. {ex}";
                formated = xml;
            }

            mStream.Close();
            writer.Close();

            return formated;
        }

        private const string INDENT_STRING = "    ";
        public string FormatJson(string str)
        {
            var indent = 0;
            var quoted = false;
            var sb = new StringBuilder();
            for (var i = 0; i < str.Length; i++)
            {
                var ch = str[i];
                switch (ch)
                {
                    case '{':
                    case '[':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, ++indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case '}':
                    case ']':
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, --indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        sb.Append(ch);
                        break;
                    case '"':
                        sb.Append(ch);
                        bool escaped = false;
                        var index = i;
                        while (index > 0 && str[--index] == '\\')
                            escaped = !escaped;
                        if (!escaped)
                            quoted = !quoted;
                        break;
                    case ',':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case ':':
                        sb.Append(ch);
                        if (!quoted)
                            sb.Append(" ");
                        break;
                    default:
                        sb.Append(ch);
                        break;
                }
            }
            return sb.ToString();
        }

        private void btnDevelop_Click(object sender, EventArgs e)
        {
            txtRootUrl.Text = "https://develop.mews.li";
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtRootUrl.Text = "https://demo.mews.li";
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            txtRootUrl.Text = "http://localhost:61785";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create($"{txtRootUrl.Text}{txtBoxApiUrl.Text}");

            var postData = textBox1.Text;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            var type = selectFormat.Text == "json" ? "json" : "x-www-form-urlencoded";
            request.ContentType = $"application/{type}";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                ProcessResponse(response, type);
            }
            catch (WebException ex)
            {
                ProcessResponse((HttpWebResponse)ex.Response, "json");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxLog.Text = "";
            txtStatusCode.Text = "";
            txtStatusMessage.Text = "";
            txtRootUrl.Text = "";
            txtBoxApiUrl.Text = "";

        }

        private void ProcessResponse(HttpWebResponse response, string format)
        {
            txtStatusCode.Text = response.StatusCode.ToString();
            txtStatusMessage.Text = response.StatusDescription.ToString();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (!string.IsNullOrEmpty(responseString))
            {
                if (format == "json")
                {
                    txtResponseBody.Text = FormatJson(responseString);
                }
                else
                {
                    txtResponseBody.Text = FormatXml(responseString);
                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtBoxLog.Focus();
        }
    }

    public static class logExtensions
    {
        public static string GetApiUrl(this string log)
        {
            return new Regex("\"Identifier\":\".*\",\"StartUtc\"").Match(log).Value.Replace("\"Identifier\":\"", "").Replace("\",\"StartUtc\"", "");
        }
        public static string DecodeXmlLog(this string log)
        {
            log = new Regex("\\[\\d\\d.*\\\"Body\\\":\"").Replace(log, "");
            return new Regex("\\[\\d\\d.*\\\"message\\\":\"").Replace(log, "");

        }
        public static string DecodeJsonLog(this string log)
        {
            log = new Regex("\\[\\d\\d.*\\\"Parameters\\\":").Replace(log, "");
            return new Regex(",\\\"Exception.*}").Replace(log, "");
        }
        public static string NormalizeLog(this string log)
        {
            return log.Replace("\\r\\n", "").Replace("\\n", "").Replace("\\\"", "\"").Replace("\"}", "").Trim().Trim('"');
        }

        public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
        {
            foreach (var i in ie)
            {
                action(i);
            }
        }
    }
}
