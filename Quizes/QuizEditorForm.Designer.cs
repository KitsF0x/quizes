namespace Quizes
{
    partial class QuizEditorForm
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
            this.m_quizDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_exitButton = new System.Windows.Forms.Button();
            this.m_saveButton = new System.Windows.Forms.Button();
            this.m_deleteButton = new System.Windows.Forms.Button();
            this.m_editButton = new System.Windows.Forms.Button();
            this.m_answerTextbox = new System.Windows.Forms.TextBox();
            this.m_answerLabel = new System.Windows.Forms.Label();
            this.m_questionTextbox = new System.Windows.Forms.TextBox();
            this.m_questionLabel = new System.Windows.Forms.Label();
            this.m_quizNameTextbox = new System.Windows.Forms.TextBox();
            this.m_addButton = new System.Windows.Forms.Button();
            this.m_quizNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_quizDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_quizDataGridView
            // 
            this.m_quizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_quizDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.m_quizDataGridView.Location = new System.Drawing.Point(3, 3);
            this.m_quizDataGridView.MultiSelect = false;
            this.m_quizDataGridView.Name = "m_quizDataGridView";
            this.m_quizDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.m_quizDataGridView.RowTemplate.Height = 25;
            this.m_quizDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_quizDataGridView.Size = new System.Drawing.Size(316, 286);
            this.m_quizDataGridView.TabIndex = 0;
            this.m_quizDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_quizDataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.m_quizDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 298);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.m_exitButton);
            this.panel2.Controls.Add(this.m_saveButton);
            this.panel2.Controls.Add(this.m_deleteButton);
            this.panel2.Controls.Add(this.m_editButton);
            this.panel2.Controls.Add(this.m_answerTextbox);
            this.panel2.Controls.Add(this.m_answerLabel);
            this.panel2.Controls.Add(this.m_questionTextbox);
            this.panel2.Controls.Add(this.m_questionLabel);
            this.panel2.Controls.Add(this.m_quizNameTextbox);
            this.panel2.Controls.Add(this.m_addButton);
            this.panel2.Controls.Add(this.m_quizNameLabel);
            this.panel2.Location = new System.Drawing.Point(353, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 298);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // m_exitButton
            // 
            this.m_exitButton.Location = new System.Drawing.Point(3, 266);
            this.m_exitButton.Name = "m_exitButton";
            this.m_exitButton.Size = new System.Drawing.Size(316, 23);
            this.m_exitButton.TabIndex = 12;
            this.m_exitButton.Text = "exit";
            this.m_exitButton.UseVisualStyleBackColor = true;
            this.m_exitButton.Click += new System.EventHandler(this.m_exitButton_Click);
            // 
            // m_saveButton
            // 
            this.m_saveButton.Location = new System.Drawing.Point(3, 237);
            this.m_saveButton.Name = "m_saveButton";
            this.m_saveButton.Size = new System.Drawing.Size(316, 23);
            this.m_saveButton.TabIndex = 11;
            this.m_saveButton.Text = "save";
            this.m_saveButton.UseVisualStyleBackColor = true;
            this.m_saveButton.Click += new System.EventHandler(this.m_saveButton_Click);
            // 
            // m_deleteButton
            // 
            this.m_deleteButton.Location = new System.Drawing.Point(219, 208);
            this.m_deleteButton.Name = "m_deleteButton";
            this.m_deleteButton.Size = new System.Drawing.Size(100, 23);
            this.m_deleteButton.TabIndex = 10;
            this.m_deleteButton.Text = "delete";
            this.m_deleteButton.UseVisualStyleBackColor = true;
            this.m_deleteButton.Click += new System.EventHandler(this.m_deleteButton_Click);
            // 
            // m_editButton
            // 
            this.m_editButton.Location = new System.Drawing.Point(111, 208);
            this.m_editButton.Name = "m_editButton";
            this.m_editButton.Size = new System.Drawing.Size(100, 23);
            this.m_editButton.TabIndex = 9;
            this.m_editButton.Text = "Edit";
            this.m_editButton.UseVisualStyleBackColor = true;
            this.m_editButton.Click += new System.EventHandler(this.m_editButton_Click);
            // 
            // m_answerTextbox
            // 
            this.m_answerTextbox.Location = new System.Drawing.Point(3, 179);
            this.m_answerTextbox.Name = "m_answerTextbox";
            this.m_answerTextbox.Size = new System.Drawing.Size(316, 23);
            this.m_answerTextbox.TabIndex = 7;
            // 
            // m_answerLabel
            // 
            this.m_answerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_answerLabel.Location = new System.Drawing.Point(3, 153);
            this.m_answerLabel.Name = "m_answerLabel";
            this.m_answerLabel.Size = new System.Drawing.Size(316, 23);
            this.m_answerLabel.TabIndex = 6;
            this.m_answerLabel.Text = "Answer";
            this.m_answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_questionTextbox
            // 
            this.m_questionTextbox.Location = new System.Drawing.Point(3, 127);
            this.m_questionTextbox.Name = "m_questionTextbox";
            this.m_questionTextbox.Size = new System.Drawing.Size(316, 23);
            this.m_questionTextbox.TabIndex = 5;
            // 
            // m_questionLabel
            // 
            this.m_questionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_questionLabel.Location = new System.Drawing.Point(3, 101);
            this.m_questionLabel.Name = "m_questionLabel";
            this.m_questionLabel.Size = new System.Drawing.Size(316, 23);
            this.m_questionLabel.TabIndex = 4;
            this.m_questionLabel.Text = "Question";
            this.m_questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_quizNameTextbox
            // 
            this.m_quizNameTextbox.Location = new System.Drawing.Point(3, 30);
            this.m_quizNameTextbox.Name = "m_quizNameTextbox";
            this.m_quizNameTextbox.Size = new System.Drawing.Size(316, 23);
            this.m_quizNameTextbox.TabIndex = 3;
            // 
            // m_addButton
            // 
            this.m_addButton.Location = new System.Drawing.Point(3, 208);
            this.m_addButton.Name = "m_addButton";
            this.m_addButton.Size = new System.Drawing.Size(100, 23);
            this.m_addButton.TabIndex = 1;
            this.m_addButton.Text = "Add";
            this.m_addButton.UseVisualStyleBackColor = true;
            this.m_addButton.Click += new System.EventHandler(this.m_addButton_Click);
            // 
            // m_quizNameLabel
            // 
            this.m_quizNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_quizNameLabel.Location = new System.Drawing.Point(3, 4);
            this.m_quizNameLabel.Name = "m_quizNameLabel";
            this.m_quizNameLabel.Size = new System.Drawing.Size(316, 23);
            this.m_quizNameLabel.TabIndex = 0;
            this.m_quizNameLabel.Text = "Quiz name";
            this.m_quizNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuizEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuizEditorForm";
            this.Text = "QuizEditor";
            this.Load += new System.EventHandler(this.QuizEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_quizDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView m_quizDataGridView;
        private Panel panel1;
        private Panel panel2;
        private Label m_quizNameLabel;
        private Button m_addButton;
        private TextBox m_answerTextbox;
        private Label m_answerLabel;
        private TextBox m_questionTextbox;
        private Label m_questionLabel;
        private TextBox m_quizNameTextbox;
        private Button m_deleteButton;
        private Button m_editButton;
        private Button m_exitButton;
        private Button m_saveButton;
    }
}