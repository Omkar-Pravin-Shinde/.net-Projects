namespace TextToSpeechConverter
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Speak = new System.Windows.Forms.Button();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(77, 139);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(551, 237);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_Speak
            // 
            this.btn_Speak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Speak.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Speak.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Speak.Location = new System.Drawing.Point(123, 410);
            this.btn_Speak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Speak.Name = "btn_Speak";
            this.btn_Speak.Size = new System.Drawing.Size(105, 36);
            this.btn_Speak.TabIndex = 1;
            this.btn_Speak.Text = "Speak";
            this.btn_Speak.UseVisualStyleBackColor = false;
            this.btn_Speak.Click += new System.EventHandler(this.btn_Speak_Click);
            // 
            // btn_Resume
            // 
            this.btn_Resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Resume.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Resume.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Resume.Location = new System.Drawing.Point(237, 410);
            this.btn_Resume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(103, 36);
            this.btn_Resume.TabIndex = 2;
            this.btn_Resume.Text = "Resume";
            this.btn_Resume.UseVisualStyleBackColor = false;
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Pause.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Pause.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Pause.Location = new System.Drawing.Point(347, 410);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(117, 36);
            this.btn_Pause.TabIndex = 3;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Stop.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Stop.Location = new System.Drawing.Point(473, 410);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(105, 36);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(217, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text To Speech";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(651, 485);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Resume);
            this.Controls.Add(this.btn_Speak);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Text to Speech Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Speak;
        private System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

