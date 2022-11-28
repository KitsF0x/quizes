namespace Quizes
{
    partial class CreateNewQuizForm
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
            this.m_quizNameLabel = new System.Windows.Forms.Label();
            this.m_quizNameTextbox = new System.Windows.Forms.TextBox();
            this.m_createQuiz = new System.Windows.Forms.Button();
            this.m_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // m_quizNameLabel
            // 
            this.m_quizNameLabel.AutoSize = true;
            this.m_quizNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_quizNameLabel.Location = new System.Drawing.Point(12, 9);
            this.m_quizNameLabel.Name = "m_quizNameLabel";
            this.m_quizNameLabel.Size = new System.Drawing.Size(103, 25);
            this.m_quizNameLabel.TabIndex = 0;
            this.m_quizNameLabel.Text = "Quiz name";
            // 
            // m_quizNameTextbox
            // 
            this.m_quizNameTextbox.Location = new System.Drawing.Point(121, 11);
            this.m_quizNameTextbox.Name = "m_quizNameTextbox";
            this.m_quizNameTextbox.Size = new System.Drawing.Size(333, 23);
            this.m_quizNameTextbox.TabIndex = 1;
            // 
            // m_createQuiz
            // 
            this.m_createQuiz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_createQuiz.Location = new System.Drawing.Point(12, 103);
            this.m_createQuiz.Name = "m_createQuiz";
            this.m_createQuiz.Size = new System.Drawing.Size(442, 59);
            this.m_createQuiz.TabIndex = 2;
            this.m_createQuiz.Text = "Create";
            this.m_createQuiz.UseVisualStyleBackColor = true;
            this.m_createQuiz.Click += new System.EventHandler(this.m_createQuiz_Click);
            // 
            // m_saveFileDialog
            // 
            this.m_saveFileDialog.Filter = "Quiz files (*.quiz)|*.quiz";
            // 
            // CreateNewQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 170);
            this.Controls.Add(this.m_createQuiz);
            this.Controls.Add(this.m_quizNameTextbox);
            this.Controls.Add(this.m_quizNameLabel);
            this.Name = "CreateNewQuizForm";
            this.Text = "CreateNewQuiz";
            this.Load += new System.EventHandler(this.CreateNewQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label m_quizNameLabel;
        private TextBox m_quizNameTextbox;
        private Button m_createQuiz;
        private SaveFileDialog m_saveFileDialog;
    }
}