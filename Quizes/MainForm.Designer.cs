namespace Quizes
{
    partial class MainForm
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
            this.m_loadQuizButton = new System.Windows.Forms.Button();
            this.m_startQuizButton = new System.Windows.Forms.Button();
            this.m_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.m_quizFileName = new System.Windows.Forms.Label();
            this.m_quizName = new System.Windows.Forms.Label();
            this.m_editQuizButton = new System.Windows.Forms.Button();
            this.m_quitButton = new System.Windows.Forms.Button();
            this.m_createNewQuizButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_loadQuizButton
            // 
            this.m_loadQuizButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_loadQuizButton.Location = new System.Drawing.Point(12, 12);
            this.m_loadQuizButton.Name = "m_loadQuizButton";
            this.m_loadQuizButton.Size = new System.Drawing.Size(442, 59);
            this.m_loadQuizButton.TabIndex = 0;
            this.m_loadQuizButton.Text = "Load quiz";
            this.m_loadQuizButton.UseVisualStyleBackColor = true;
            this.m_loadQuizButton.Click += new System.EventHandler(this.m_loadQuizButton_Click);
            // 
            // m_startQuizButton
            // 
            this.m_startQuizButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_startQuizButton.Location = new System.Drawing.Point(12, 77);
            this.m_startQuizButton.Name = "m_startQuizButton";
            this.m_startQuizButton.Size = new System.Drawing.Size(442, 59);
            this.m_startQuizButton.TabIndex = 1;
            this.m_startQuizButton.Text = "Start quiz";
            this.m_startQuizButton.UseVisualStyleBackColor = true;
            this.m_startQuizButton.Click += new System.EventHandler(this.m_startQuizButton_Click);
            // 
            // m_openFileDialog
            // 
            this.m_openFileDialog.FileName = "openFileDialog1";
            this.m_openFileDialog.Filter = "Quiz files (*.quiz)|*.quiz";
            // 
            // m_quizFileName
            // 
            this.m_quizFileName.AutoSize = true;
            this.m_quizFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_quizFileName.Location = new System.Drawing.Point(12, 334);
            this.m_quizFileName.Name = "m_quizFileName";
            this.m_quizFileName.Size = new System.Drawing.Size(151, 25);
            this.m_quizFileName.TabIndex = 2;
            this.m_quizFileName.Text = "m_quizFileName";
            // 
            // m_quizName
            // 
            this.m_quizName.AutoSize = true;
            this.m_quizName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_quizName.Location = new System.Drawing.Point(12, 359);
            this.m_quizName.Name = "m_quizName";
            this.m_quizName.Size = new System.Drawing.Size(63, 25);
            this.m_quizName.TabIndex = 3;
            this.m_quizName.Text = "label2";
            // 
            // m_editQuizButton
            // 
            this.m_editQuizButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_editQuizButton.Location = new System.Drawing.Point(12, 142);
            this.m_editQuizButton.Name = "m_editQuizButton";
            this.m_editQuizButton.Size = new System.Drawing.Size(442, 59);
            this.m_editQuizButton.TabIndex = 4;
            this.m_editQuizButton.Text = "Edit quiz";
            this.m_editQuizButton.UseVisualStyleBackColor = true;
            this.m_editQuizButton.Click += new System.EventHandler(this.m_editQuizButton_Click);
            // 
            // m_quitButton
            // 
            this.m_quitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_quitButton.Location = new System.Drawing.Point(12, 272);
            this.m_quitButton.Name = "m_quitButton";
            this.m_quitButton.Size = new System.Drawing.Size(442, 59);
            this.m_quitButton.TabIndex = 5;
            this.m_quitButton.Text = "Quit";
            this.m_quitButton.UseVisualStyleBackColor = true;
            this.m_quitButton.Click += new System.EventHandler(this.m_quitButton_Click);
            // 
            // m_createNewQuizButton
            // 
            this.m_createNewQuizButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_createNewQuizButton.Location = new System.Drawing.Point(12, 207);
            this.m_createNewQuizButton.Name = "m_createNewQuizButton";
            this.m_createNewQuizButton.Size = new System.Drawing.Size(442, 59);
            this.m_createNewQuizButton.TabIndex = 6;
            this.m_createNewQuizButton.Text = "Create new quiz";
            this.m_createNewQuizButton.UseVisualStyleBackColor = true;
            this.m_createNewQuizButton.Click += new System.EventHandler(this.m_createNewQuizButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 404);
            this.Controls.Add(this.m_createNewQuizButton);
            this.Controls.Add(this.m_quitButton);
            this.Controls.Add(this.m_editQuizButton);
            this.Controls.Add(this.m_quizName);
            this.Controls.Add(this.m_quizFileName);
            this.Controls.Add(this.m_startQuizButton);
            this.Controls.Add(this.m_loadQuizButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button m_loadQuizButton;
        private Button m_startQuizButton;
        private OpenFileDialog m_openFileDialog;
        private Label m_quizFileName;
        private Label m_quizName;
        private Button m_editQuizButton;
        private Button m_quitButton;
        private Button m_createNewQuizButton;
    }
}