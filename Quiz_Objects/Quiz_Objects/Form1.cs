using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Objects
{
    public partial class Form1 : Form
    {

        private List<RadioButton> QuizRadioButtons;
        private List<Question> QuizQuestions;

        private int CurrentQuestionNumber;

        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            QuizRadioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4 };

            Question q1 = new Question("What is the fastest animal?", "Cheetah", new List<string> { "Sloth", "Snail", "Tortoise" });
            Question q2 = new Question("What color is an elephant?", "Gray", new List<string> { "Pink", "Green", "Purple" });
            Question q3 = new Question("What does a cat say?", "Meow", new List<string> { "Quack", "Woof", "Beep" });

            QuizQuestions = new List<Question> { q1, q2, q3 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayQuestion(0);
            btnNext.Enabled = false;
            btnCheckAnswer.Focus();
        }

        private void DisplayQuestion(int questionIndex)
        {
            Question question = QuizQuestions[questionIndex];

            List<string> Answers = question.AllAnswers;

            // Deselect all the radio buttons
            QuizRadioButtons.ForEach(b => b.Checked = false);
            lblResult.Text = "??";

            // Check are list or RadioButtons and Questions are the same size? 
            if (QuizRadioButtons.Count != question.AllAnswers.Count)
            {
                throw new Exception("Questions must have the same number of answers as radio buttons");
            }

            for (int a = 0; a < Answers.Count; a++)
            {
                QuizRadioButtons[a].Text = Answers[a];
            }

            lblQuestion.Text = question.QuestionText;
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            // What is the current question? ElementAtOrDefault Returns null if 
            // CurrentQuestionNumber is out of range for the QuizQuestions list
            Question currentQuestion = QuizQuestions.ElementAtOrDefault(CurrentQuestionNumber);

            if (currentQuestion == null)   
            {
                return;  // Do you think this is the best way to deal with no question?
            }

            // Which RadioButton was selected?
            string userAnswer = null;

            foreach(RadioButton rb in QuizRadioButtons)
            {
               if (rb.Checked == true)
               {
                   userAnswer = rb.Text;
               }
            }

            if (userAnswer == null)
            {
                MessageBox.Show("Pick an answer", "Error");
                return;
            }

            // Determine if the user's answer is the correct one.
            // Inform user by updating lblResult
            // Increase score if user is correct 
            if (currentQuestion.IsCorrect(userAnswer) )
            {
                lblResult.Text = "Correct!";
                score++;
            }
            else
            {
                lblResult.Text = $"Wrong. The correct answer is {currentQuestion.CorrectAnswer}";
            }

            btnCheckAnswer.Enabled = false;
            btnNext.Enabled = true;
            btnNext.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Advance to next question
            CurrentQuestionNumber++;

            if (CurrentQuestionNumber >= QuizQuestions.Count)
            {
                MessageBox.Show($"End of Quiz! Your score is {score}", "Quiz Over");
                // Disable both buttons
                btnNext.Enabled = false;
                btnCheckAnswer.Enabled = false;
            }
            else
            {
                DisplayQuestion(CurrentQuestionNumber);
                // Disable Next, enable Check Answer and focus
                btnNext.Enabled = false;
                btnCheckAnswer.Enabled = true;
                btnCheckAnswer.Focus();
            }
        }
    }
}
