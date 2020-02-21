using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Objects
{
    public partial class Form1 : Form
    {
        // Collect the RadioButtons into a list to help select/deselect all, 
        // help and figure out which one the user has checked
        List<RadioButton> QuizRadioButtons;  
        
        // The question bank
        QuestionSet QuizQuestionSet;

        public Form1()
        {
            InitializeComponent();

            QuizRadioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4 };
            
            // Configure QuestionSet with example questions. Use your own questions if prefered.
            QuizQuestionSet = new QuestionSet();

            Question q1 = new Question("What is the fastest animal?", "Cheetah", new List<string> { "Sloth", "Snail", "Tortoise" });
            Question q2 = new Question("What color is an elephant?", "Gray", new List<string> { "Pink", "Green", "Purple" });
            Question q3 = new Question("What does a cat say?", "Meow", new List<string> { "Quack", "Woof", "Beep" });

            QuizQuestionSet.Questions.Add(q1);
            QuizQuestionSet.Questions.Add(q2);
            QuizQuestionSet.Questions.Add(q3);
        }

        private void txtUserName_EnterPressedChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   // Only want to respond to Enter key events
            {
                string userName = txtUserName.Text;

                if (String.IsNullOrWhiteSpace(userName))
                {
                    return;   // Ignore empty strings
                }

                // Set the user's name for this question set 
                QuizQuestionSet.UserName = userName;

                // Disable the TextBox to preserve the user's name
                txtUserName.Enabled = false;

                // enable all of the RadioButton controls
                foreach (RadioButton rb in QuizRadioButtons)
                {
                    rb.Enabled = true;
                }

                // enable the check answer button and focus on it
                btnCheckAnswer.Enabled = true;
                btnCheckAnswer.Focus();

                // Start quiz
                DisplayNextQuestion();
            }
        }

        private void DisplayNextQuestion()
        {
            Question question = QuizQuestionSet.Next;

            if (question == null)
            {
                Debug.WriteLine("Quiz over, no more questions");
                return;
            }

            List<string> Answers = question.AllAnswers;

            // Deselect all the radio buttons and clear the results 

            foreach (RadioButton rb in QuizRadioButtons)
            {
                rb.Checked = false;
            }

            lblResult.Text = "??";

            // check are lists same size. Error if not - throw new exception. Programmer needs to fix situation.
            if (QuizRadioButtons.Count != question.AllAnswers.Count)
            {
                throw new Exception("Questions must have the same number of answers as radio buttons");
            }

            // Set question
            lblQuestion.Text = question.QuestionText;

            // Set each radio button Text to one of the Question's answers  
            for (int a = 0; a < Answers.Count; a++)
            {
                QuizRadioButtons[a].Text = Answers[a];
            }
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
 
            string userAnswer = null;

            Question question = QuizQuestionSet.CurrentQuestion;

            // Which radio button was selected?
            foreach (RadioButton rb in QuizRadioButtons) 
            {
               if (rb.Checked == true)
               {
                   userAnswer = rb.Text;
               }
            }

            // If no radio button was selected, userAnswer will not be changed from null
            if (userAnswer == null)
            {
                MessageBox.Show("Pick an answer", "Error");
                return;   
            }

            // Set the user's answer, and score the question
            question.UserAnswer = userAnswer;

            QuizQuestionSet.ScoreCurrentQuestion();

            // Show "correct" or "wrong answer" message
            if (question.Correct)
            {
                lblResult.Text = "Correct!";
            }
            else
            {
                lblResult.Text = $"Wrong. The correct answer is {question.CorrectAnswer}";
            }

            // Disable Check answer button, enable the Next button and focus 
            btnCheckAnswer.Enabled = false;
            btnNext.Enabled = true;
            btnNext.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Has the user answered all of the questions? 
            if (QuizQuestionSet.QuizOver) 
            { 
                // Display results, disable next and check answer buttons
                ShowResults();
                btnNext.Enabled = false;
                btnCheckAnswer.Enabled = false;
            }
            else
            {
                DisplayNextQuestion();
            }

            // Disable next button, enable check answer and focus
            btnNext.Enabled = false;
            btnCheckAnswer.Enabled = true;
            btnCheckAnswer.Focus();
        }

        private void ShowResults()
        {
            // Get score and total points from QuizQuestionSet
            string results = $"{QuizQuestionSet.UserName}, you scored {QuizQuestionSet.Score} out of " +
                $"{QuizQuestionSet.AvailablePoints} points";
            MessageBox.Show(results, "Quiz Results!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
