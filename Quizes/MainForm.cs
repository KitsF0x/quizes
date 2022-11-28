using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizes
{
    public partial class MainForm : Form
    {
        private string m_fileNameLabelDefaultValue = "Selected quiz file: ";
        private Quiz m_quiz = new Quiz();
        public MainForm()
        {
            InitializeComponent();
        }

        private void m_loadQuizButton_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            m_openFileDialog.InitialDirectory = Application.StartupPath;

            if (m_openFileDialog.ShowDialog() == DialogResult.OK && (fileStream = m_openFileDialog.OpenFile()) != null)
            {
                m_quiz.m_path = m_openFileDialog.FileName;
                m_quizFileName.Text = m_fileNameLabelDefaultValue + m_quiz.m_path;
                m_quizName.Text = "Quiz name: " + m_quiz.m_name;
                m_editQuizButton.Enabled = true;
                m_startQuizButton.Enabled = true;
            }
            fileStream.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            m_quizFileName.Text = "";
            m_quizName.Text = "";
            m_editQuizButton.Enabled = false;
            m_startQuizButton.Enabled = false;
        }

        private void m_startQuizButton_Click(object sender, EventArgs e)
        {

            QuizForm quizForm = new QuizForm(m_quiz, this);
            quizForm.Show();
            Hide();
        }

        private void m_editQuizButton_Click(object sender, EventArgs e)
        {
            QuizEditorForm quizEditorForm = new QuizEditorForm(m_quiz, this);
            quizEditorForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void m_quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_createNewQuizButton_Click(object sender, EventArgs e)
        {
            CreateNewQuizForm createNewQuizForm = new CreateNewQuizForm(m_quiz, this);
            createNewQuizForm.Show();
            Hide();
        }
    }
}
