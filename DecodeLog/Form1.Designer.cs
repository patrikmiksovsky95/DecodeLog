namespace DecodeLog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDecodeLog = new System.Windows.Forms.Button();
            this.btnFormatXML = new System.Windows.Forms.Button();
            this.btnFormatJson = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.txtBoxLog = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtRootUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxApiUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDevelop = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectFormat = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStatusCode = new System.Windows.Forms.TextBox();
            this.txtStatusMessage = new System.Windows.Forms.TextBox();
            this.txtResponseBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1107, 360);
            this.textBox1.TabIndex = 0;
            // 
            // btnDecodeLog
            // 
            this.btnDecodeLog.Location = new System.Drawing.Point(923, 22);
            this.btnDecodeLog.Name = "btnDecodeLog";
            this.btnDecodeLog.Size = new System.Drawing.Size(93, 23);
            this.btnDecodeLog.TabIndex = 1;
            this.btnDecodeLog.Text = "Decode log";
            this.btnDecodeLog.UseVisualStyleBackColor = true;
            this.btnDecodeLog.Click += new System.EventHandler(this.decodeLog_Click);
            // 
            // btnFormatXML
            // 
            this.btnFormatXML.Location = new System.Drawing.Point(910, 457);
            this.btnFormatXML.Name = "btnFormatXML";
            this.btnFormatXML.Size = new System.Drawing.Size(87, 23);
            this.btnFormatXML.TabIndex = 2;
            this.btnFormatXML.Text = "Format XML";
            this.btnFormatXML.UseVisualStyleBackColor = true;
            this.btnFormatXML.Click += new System.EventHandler(this.btnFormatXML_Click);
            // 
            // btnFormatJson
            // 
            this.btnFormatJson.Location = new System.Drawing.Point(1003, 457);
            this.btnFormatJson.Name = "btnFormatJson";
            this.btnFormatJson.Size = new System.Drawing.Size(108, 23);
            this.btnFormatJson.TabIndex = 3;
            this.btnFormatJson.Text = "Format JSON";
            this.btnFormatJson.UseVisualStyleBackColor = true;
            this.btnFormatJson.Click += new System.EventHandler(this.btnFormatJson_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(12, 544);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 4;
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Location = new System.Drawing.Point(12, 24);
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.Size = new System.Drawing.Size(904, 20);
            this.txtBoxLog.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Log";
            // 
            // txtRootUrl
            // 
            this.txtRootUrl.Location = new System.Drawing.Point(266, 59);
            this.txtRootUrl.Name = "txtRootUrl";
            this.txtRootUrl.Size = new System.Drawing.Size(122, 20);
            this.txtRootUrl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Root url";
            // 
            // txtBoxApiUrl
            // 
            this.txtBoxApiUrl.Location = new System.Drawing.Point(395, 59);
            this.txtBoxApiUrl.Name = "txtBoxApiUrl";
            this.txtBoxApiUrl.Size = new System.Drawing.Size(426, 20);
            this.txtBoxApiUrl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "API url";
            // 
            // btnDevelop
            // 
            this.btnDevelop.Location = new System.Drawing.Point(12, 59);
            this.btnDevelop.Name = "btnDevelop";
            this.btnDevelop.Size = new System.Drawing.Size(75, 23);
            this.btnDevelop.TabIndex = 12;
            this.btnDevelop.Text = "Develop";
            this.btnDevelop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevelop.UseVisualStyleBackColor = true;
            this.btnDevelop.Click += new System.EventHandler(this.btnDevelop_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(93, 58);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 13;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(174, 58);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 14;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(962, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectFormat
            // 
            this.selectFormat.FormattingEnabled = true;
            this.selectFormat.Items.AddRange(new object[] {
            "json",
            "xml"});
            this.selectFormat.Location = new System.Drawing.Point(835, 58);
            this.selectFormat.Name = "selectFormat";
            this.selectFormat.Size = new System.Drawing.Size(121, 21);
            this.selectFormat.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(1039, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStatusCode
            // 
            this.txtStatusCode.Location = new System.Drawing.Point(15, 516);
            this.txtStatusCode.Name = "txtStatusCode";
            this.txtStatusCode.Size = new System.Drawing.Size(100, 20);
            this.txtStatusCode.TabIndex = 18;
            // 
            // txtStatusMessage
            // 
            this.txtStatusMessage.Location = new System.Drawing.Point(121, 516);
            this.txtStatusMessage.Name = "txtStatusMessage";
            this.txtStatusMessage.Size = new System.Drawing.Size(592, 20);
            this.txtStatusMessage.TabIndex = 19;
            // 
            // txtResponseBody
            // 
            this.txtResponseBody.Location = new System.Drawing.Point(15, 560);
            this.txtResponseBody.Multiline = true;
            this.txtResponseBody.Name = "txtResponseBody";
            this.txtResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponseBody.Size = new System.Drawing.Size(1104, 108);
            this.txtResponseBody.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Status message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Response body";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 680);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResponseBody);
            this.Controls.Add(this.txtStatusMessage);
            this.Controls.Add(this.txtStatusCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.selectFormat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnDevelop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxApiUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRootUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btnFormatJson);
            this.Controls.Add(this.btnFormatXML);
            this.Controls.Add(this.btnDecodeLog);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Best tool for xml json ever!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDecodeLog;
        private System.Windows.Forms.Button btnFormatXML;
        private System.Windows.Forms.Button btnFormatJson;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox txtBoxLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRootUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxApiUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDevelop;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox selectFormat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStatusCode;
        private System.Windows.Forms.TextBox txtStatusMessage;
        private System.Windows.Forms.TextBox txtResponseBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

