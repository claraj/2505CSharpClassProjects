﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Objects
{
    class QuestionSet
    {
        // Fields - only used internally by a QuestionSet object
        private int currentQuestionIndex = -1;

        private string _userName; 

        // Read and Write Properties
        public string UserName   // This uses the field _userName to store data
        { 
            get 
            {
                return _userName; 
            } 
            set 
            {
                // value is a built-in name for the new value the Property is being set to
                if (String.IsNullOrEmpty(value))   // Validate
                { 
                    throw new Exception();
                }
                _userName = value;
            }
        }

        // Implicit properties. 
        // A private field is generated by the C# compiler for each implicit property

        // This implicit property has an initial value - a new List of Questions
        public List<Question> Questions { get; set; } = new List<Question>();

        // Implicit properties that can be read by other code, but can only be set by this class
        // See ScoreCurrentQuestion method 
        public int Score { get; private set; }

        // Properties that compute their values from other fields/properties in the class
        public int AvailablePoints
        {
            get
            {
                int total = 0;
                Questions.ForEach(question => { total += question.Points; });
                return total;
            }
        }

        public Question CurrentQuestion
        {
            get
            {
                {
                    // Return null if currentQuestionIndex is outside the range of the Questions list
                    return Questions.ElementAtOrDefault(currentQuestionIndex);
                }
            }
        }

        public Question Next
        {
            get
            {
                if (currentQuestionIndex < Questions.Count)
                {
                    currentQuestionIndex++;
                }
                return Questions.ElementAtOrDefault(currentQuestionIndex);
            }
        }

        public bool QuizOver
        {
            get
            {
                return Questions.Count <= currentQuestionIndex + 1;
            }
        }

        // Method
        public void ScoreCurrentQuestion()
        {
            if (!CurrentQuestion.Scored)
            {
                if (CurrentQuestion.Correct)
                {
                    Score += CurrentQuestion.Points;  
                }
            }
            CurrentQuestion.Scored = true;
        }
    }
}
