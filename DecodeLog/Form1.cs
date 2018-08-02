using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;

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

            string result = "";

            var mStream = new MemoryStream();
            var writer = new XmlTextWriter(mStream, Encoding.Unicode);
            var document = new XmlDocument();

            try
            {
                document.LoadXml(textBox1.Text);

                writer.Formatting = System.Xml.Formatting.Indented;

                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                mStream.Position = 0;

                StreamReader sReader = new StreamReader(mStream);

                string formattedXml = sReader.ReadToEnd();

                result = formattedXml;
            }
            catch (XmlException ex)
            {
                textBox1.Text = $"Invalid XML object. {ex}";
            }

            mStream.Close();
            writer.Close();

            textBox1.Text = result;
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
