using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizes
{
    public class Question
    {
        public string m_question { get; set; }
        public string m_answer { get; set; }
        public Question(string question, string answer)
        {
            m_question = question; 
            m_answer = answer;
        }
        public string toString() { return "[" + m_question + ", " + m_answer +"]"; }
    }
}
