using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizes
{
    public class Quiz
    {
        public string m_name { get; set; }
        public string m_path { get; set; }
        public List<Question> m_questions { get; set; }
        public Quiz()
        {
            m_questions = new List<Question>();
        }
        public void parseFile() {
            m_questions.Clear();
            List<string> lines = getLinesFromFile(m_path);

            if ((lines.Count < 3) && (lines.Count % 2 == 0))
            {
                throw new InvalidDataException("Broken file format");
            }
            m_name = lines[0];
            
            for (int i = 1; i < lines.Count; i += 2)
            {
                m_questions.Add(new Question(lines[i], lines[i + 1]));
            }
        }

        private List<string> getLinesFromFile(string path)
        {
            List<string> lines = new List<string>();

            using (var stream = File.Open(path, FileMode.Open))
            {
                var reader = new StreamReader(stream);
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        public void save()
        {
            List<string> lines = new List<string>();
            lines.Add(m_name);
            foreach(Question question in m_questions)
            {
                lines.Add(question.m_question);
                lines.Add(question.m_answer);
            }

            File.WriteAllLines(m_path, lines.ToArray());
        }
    }
}
