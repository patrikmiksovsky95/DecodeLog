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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxApiUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1107, 404);
            this.textBox1.TabIndex = 0;
            // 
            // btnDecodeLog
            // 
            this.btnDecodeLog.Location = new System.Drawing.Point(819, 501);
            this.btnDecodeLog.Name = "btnDecodeLog";
            this.btnDecodeLog.Size = new System.Drawing.Size(93, 23);
            this.btnDecodeLog.TabIndex = 1;
            this.btnDecodeLog.Text = "Decode log";
            this.btnDecodeLog.UseVisualStyleBackColor = true;
            this.btnDecodeLog.Click += new System.EventHandler(this.decodeLog_Click);
            // 
            // btnFormatXML
            // 
            this.btnFormatXML.Location = new System.Drawing.Point(918, 501);
            this.btnFormatXML.Name = "btnFormatXML";
            this.btnFormatXML.Size = new System.Drawing.Size(87, 23);
            this.btnFormatXML.TabIndex = 2;
            this.btnFormatXML.Text = "Format XML";
            this.btnFormatXML.UseVisualStyleBackColor = true;
            this.btnFormatXML.Click += new System.EventHandler(this.btnFormatXML_Click);
            // 
            // btnFormatJson
            // 
            this.btnFormatJson.Location = new System.Drawing.Point(1011, 501);
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
            this.txtBoxLog.Size = new System.Drawing.Size(1104, 20);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Root url";
            // 
            // txtBoxApiUrl
            // 
            this.txtBoxApiUrl.Location = new System.Drawing.Point(174, 67);
            this.txtBoxApiUrl.Name = "txtBoxApiUrl";
            this.txtBoxApiUrl.Size = new System.Drawing.Size(426, 20);
            this.txtBoxApiUrl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "API url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxApiUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxApiUrl;
        private System.Windows.Forms.Label label3;
    }
}

