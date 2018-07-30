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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDecodeLog = new System.Windows.Forms.Button();
            this.btnFormatXML = new System.Windows.Forms.Button();
            this.btnFormatJson = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1107, 483);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 595);
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
    }
}

