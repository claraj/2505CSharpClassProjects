using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Objects
{
    class Question
    {
        // Constructor 
        public Question(string questionText, string correctAnswer, List<String> wrongAnswers)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
            WrongAnswers = wrongAnswers;
        }

        // Implicit Properties 
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> WrongAnswers { get; set; }

        //Read only properties. These compute the return value from other properties in the Question
        public bool IsCorrect(String answer)
        {
            return answer == CorrectAnswer;
        }

        public List<string> AllAnswers 
        {
            get
            {
                // Randomize order, combine correct answer and wrong answers
                List<string> allAnswers = new List<string>();
                allAnswers.AddRange(WrongAnswers);
                allAnswers.Add(CorrectAnswer);

                Random random = new Random();
                List<String> shuffledAnswers = new List<String>();
                while (allAnswers.Count > 0)
                {
                    int index = random.Next(allAnswers.Count);
                    Console.WriteLine(index);
                    string answer = allAnswers[index];
                    allAnswers.RemoveAt(index);
                    int insertIndex = random.Next(shuffledAnswers.Count);

                    shuffledAnswers.Insert(insertIndex, answer);
                }

                return shuffledAnswers;
            }
        }
    }
}
