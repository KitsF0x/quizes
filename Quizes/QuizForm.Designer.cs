namespace Quizes
{
    partial class QuizForm
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
            this.m_timer = new System.Windows.Forms.Timer(this.components);
            this.m_questionLabel = new System.Windows.Forms.Label();
            this.m_timeLabel = new System.Windows.Forms.Label();
            this.m_correctChoicesLabel = new System.Windows.Forms.Label();
            this.m_wrongChoicesLabel = new System.Windows.Forms.Label();
            this.m_buttonD = new System.Windows.Forms.Button();
            this.m_buttonC = new System.Windows.Forms.Button();
            this.m_buttonB = new System.Windows.Forms.Button();
            this.m_buttonA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_timer
            // 
            this.m_timer.Interval = 1000;
            this.m_timer.Tick += new System.EventHandler(this.m_timer_Tick);
            // 
            // m_questionLabel
            // 
            this.m_questionLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_questionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_questionLabel.Location = new System.Drawing.Point(-4, -2);
            this.m_questionLabel.Name = "m_questionLabel";
            this.m_questionLabel.Size = new System.Drawing.Size(842, 83);
            this.m_questionLabel.TabIndex = 4;
            this.m_questionLabel.Text = "<Question>";
            this.m_questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_timeLabel
            // 
            this.m_timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_timeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_timeLabel.Location = new System.Drawing.Point(143, -2);
            this.m_timeLabel.Name = "m_timeLabel";
            this.m_timeLabel.Size = new System.Drawing.Size(552, 85);
            this.m_timeLabel.TabIndex = 5;
            this.m_timeLabel.Text = "<Time>";
            this.m_timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_correctChoicesLabel
            // 
            this.m_correctChoicesLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_correctChoicesLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.m_correctChoicesLabel.Location = new System.Drawing.Point(0, 0);
            this.m_correctChoicesLabel.Name = "m_correctChoicesLabel";
            this.m_correctChoicesLabel.Size = new System.Drawing.Size(139, 85);
            this.m_correctChoicesLabel.TabIndex = 6;
            this.m_correctChoicesLabel.Text = "goodChoices";
            this.m_correctChoicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_wrongChoicesLabel
            // 
            this.m_wrongChoicesLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_wrongChoicesLabel.ForeColor = System.Drawing.Color.Red;
            this.m_wrongChoicesLabel.Location = new System.Drawing.Point(703, 0);
            this.m_wrongChoicesLabel.Name = "m_wrongChoicesLabel";
            this.m_wrongChoicesLabel.Size = new System.Drawing.Size(139, 85);
            this.m_wrongChoicesLabel.TabIndex = 7;
            this.m_wrongChoicesLabel.Text = "wrongChoices";
            this.m_wrongChoicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_buttonD
            // 
            this.m_buttonD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_buttonD.Location = new System.Drawing.Point(3, 107);
            this.m_buttonD.Name = "m_buttonD";
            this.m_buttonD.Size = new System.Drawing.Size(832, 46);
            this.m_buttonD.TabIndex = 3;
            this.m_buttonD.Text = "button4";
            this.m_buttonD.UseVisualStyleBackColor = true;
            this.m_buttonD.Click += new System.EventHandler(this.m_buttonD_Click);
            // 
            // m_buttonC
            // 
            this.m_buttonC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_buttonC.Location = new System.Drawing.Point(3, 159);
            this.m_buttonC.Name = "m_buttonC";
            this.m_buttonC.Size = new System.Drawing.Size(832, 46);
            this.m_buttonC.TabIndex = 2;
            this.m_buttonC.Text = "button3";
            this.m_buttonC.UseVisualStyleBackColor = true;
            this.m_buttonC.Click += new System.EventHandler(this.m_buttonC_Click);
            // 
            // m_buttonB
            // 
            this.m_buttonB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_buttonB.Location = new System.Drawing.Point(3, 55);
            this.m_buttonB.Name = "m_buttonB";
            this.m_buttonB.Size = new System.Drawing.Size(832, 46);
            this.m_buttonB.TabIndex = 1;
            this.m_buttonB.Text = "button2";
            this.m_buttonB.UseVisualStyleBackColor = true;
            this.m_buttonB.Click += new System.EventHandler(this.m_buttonB_Click);
            // 
            // m_buttonA
            // 
            this.m_buttonA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_buttonA.Location = new System.Drawing.Point(3, 3);
            this.m_buttonA.Name = "m_buttonA";
            this.m_buttonA.Size = new System.Drawing.Size(832, 46);
            this.m_buttonA.TabIndex = 0;
            this.m_buttonA.Text = "button1";
            this.m_buttonA.UseVisualStyleBackColor = true;
            this.m_buttonA.Click += new System.EventHandler(this.m_buttonA_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.m_wrongChoicesLabel);
            this.panel1.Controls.Add(this.m_correctChoicesLabel);
            this.panel1.Controls.Add(this.m_timeLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 85);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.m_questionLabel);
            this.panel2.Location = new System.Drawing.Point(12, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 85);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.m_buttonA);
            this.panel3.Controls.Add(this.m_buttonD);
            this.panel3.Controls.Add(this.m_buttonC);
            this.panel3.Controls.Add(this.m_buttonB);
            this.panel3.Location = new System.Drawing.Point(12, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 215);
            this.panel3.TabIndex = 10;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 420);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer m_timer;
        private Label m_questionLabel;
        private Label m_timeLabel;
        private Label m_correctChoicesLabel;
        private Label m_wrongChoicesLabel;
        private Button m_buttonD;
        private Button m_buttonC;
        private Button m_buttonB;
        private Button m_buttonA;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}