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
    public partial class QuizForm : Form
    {
        private int m_seconds = 0;
        private Quiz m_quiz;
        private MainForm m_mainForm;
        private int m_currentQuestion = 0;
        private Button[] m_buttons = new Button[4];

        private int m_correctChoices = 0;
        private int m_wrongChoices = 0;
        public QuizForm(Quiz quiz, MainForm mainForm)
        {
            m_quiz = quiz;
            m_mainForm = mainForm;
            m_quiz.parseFile();
            InitializeComponent();
            addButtonsToArray();
            m_correctChoicesLabel.Text = m_correctChoices.ToString();
            m_wrongChoicesLabel.Text = m_wrongChoices.ToString();
            m_timeLabel.Text = "0";
            randomQuestionWithRandomAnswers();
            m_timer.Start();
        }

        private void addButtonsToArray()
        {
            m_buttons[0] = m_buttonA;
            m_buttons[1] = m_buttonB;
            m_buttons[2] = m_buttonC;
            m_buttons[3] = m_buttonD;
        }


        private void randomQuestionWithRandomAnswers()
        {
            Random random = new Random();
            m_currentQuestion = random.Next(m_quiz.m_questions.Count());
            for (int i = 0; i < 4; i++)
            {
                int randomNum = random.Next(m_quiz.m_questions.Count());
                m_buttons[i].Text = m_quiz.m_questions.ElementAt(randomNum).m_answer;
            }

            m_currentQuestion = random.Next(m_quiz.m_questions.Count);

            m_questionLabel.Text = m_quiz.m_questions.ElementAt(m_currentQuestion).m_question;
            m_buttons[random.Next(4)].Text = m_quiz.m_questions.ElementAt(m_currentQuestion).m_answer;
        }

        private void checkForCorrectAnswer(int buttonId)
        {
            if (m_buttons[buttonId].Text == m_quiz.m_questions.ElementAt(m_currentQuestion).m_answer)
            {
                m_correctChoices++;
                m_correctChoicesLabel.Text = m_correctChoices.ToString();
            }
            else
            {
                m_wrongChoices++;
                m_wrongChoicesLabel.Text = m_wrongChoices.ToString();
            }

            randomQuestionWithRandomAnswers();
        }

        private void m_buttonA_Click(object sender, EventArgs e)
        {
            checkForCorrectAnswer(0);
        }

        private void m_buttonB_Click(object sender, EventArgs e)
        {
            checkForCorrectAnswer(1);
        }

        private void m_buttonC_Click(object sender, EventArgs e)
        {
            checkForCorrectAnswer(2);
        }

        private void m_buttonD_Click(object sender, EventArgs e)
        {
            checkForCorrectAnswer(3);
        }

        private void m_timer_Tick(object sender, EventArgs e)
        {
            m_seconds++;
            m_timeLabel.Text = m_seconds.ToString();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_mainForm.Show();
        }
    }
}
