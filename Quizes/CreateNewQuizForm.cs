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
    public partial class CreateNewQuizForm : Form
    {
        private Quiz m_quiz;
        private MainForm m_mainForm;
        public CreateNewQuizForm(Quiz quiz, MainForm mainForm)
        {
            m_quiz = quiz;
            m_mainForm = mainForm;
            InitializeComponent();
        }

        private void CreateNewQuiz_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void m_createQuiz_Click(object sender, EventArgs e)
        {
            if(m_quizNameTextbox.Text.Length > 0)
            {
                // https://learn.microsoft.com/pl-pl/dotnet/api/system.windows.forms.savefiledialog?view=windowsdesktop-7.0
            }
        }
    }
}
