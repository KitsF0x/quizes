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
    public partial class QuizEditorForm : Form
    {
        private Quiz m_quiz;
        private int m_selectedQuestionId;
        private MainForm m_mainForm;
        public QuizEditorForm(Quiz quiz, MainForm mainForm)
        {
            InitializeComponent();
            m_quiz = quiz;
            m_quiz.parseFile();
            m_mainForm = mainForm;
            m_mainForm.Hide();
            loadQuizIntoDataGridView();
        }
        private void loadQuizIntoDataGridView()
        {
            m_quizDataGridView.DataSource = null;
            m_quizDataGridView.DataSource = m_quiz.m_questions;
        }
        private void QuizEditorForm_Load(object sender, EventArgs e)
        {
            m_quizNameTextbox.Text = m_quiz.m_name;
            this.CenterToScreen();
        }

        private void m_quizDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Question selectedQuestion = (Question)m_quizDataGridView.CurrentRow.DataBoundItem; ;
                m_questionTextbox.Text = selectedQuestion.m_question;
                m_answerTextbox.Text = selectedQuestion.m_answer;
                m_selectedQuestionId = e.RowIndex;
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void m_saveButton_Click(object sender, EventArgs e)
        {
            m_quiz.save();
        }

        private void m_addButton_Click(object sender, EventArgs e)
        {
            if(m_questionTextbox.Text.Length > 0 && m_answerTextbox.Text.Length > 0)
            {
                Question question = new Question(m_questionTextbox.Text, m_answerTextbox.Text);
                m_quiz.m_questions.Add(question);
                MessageBox.Show("New question was added");
                loadQuizIntoDataGridView();
            }
        }

        private void m_editButton_Click(object sender, EventArgs e)
        {
            if (m_questionTextbox.Text.Length > 0 && m_answerTextbox.Text.Length > 0)
            {
                m_quiz.m_questions[m_selectedQuestionId] = new Question(m_questionTextbox.Text, m_answerTextbox.Text);
                MessageBox.Show("Question was updated");
                loadQuizIntoDataGridView();
            }
        }

        private void m_deleteButton_Click(object sender, EventArgs e)
        {
            m_quiz.m_questions.RemoveAt(m_selectedQuestionId);
            MessageBox.Show("Question was deleted");
            loadQuizIntoDataGridView();
        }

        private void m_exitButton_Click(object sender, EventArgs e)
        {
            m_mainForm.Show();
            Close();
        }
    }
}
