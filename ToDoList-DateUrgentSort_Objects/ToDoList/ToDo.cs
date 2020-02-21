using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    struct ToDo
    {
        public ToDo(string text, bool urgent)
        {
            Text = text;      // set the Text property
            Urgent = urgent;     // set the Urgent property
            DateCreated = DateTime.Now;
        }

        // A Property, backed by the text field
        public string Text { get; set; }

        // Another auto property, C# creates an urgent field
        public bool Urgent { get; set; }

        // Auto property with an initial value
        public DateTime DateCreated { get; set; } // = DateTime.Now;

        // A method that can be called for any ToDo object
        public override string ToString()
        {
            string displayText = $"{Text} - Created on {DateCreated:f}";
            if (Urgent)
            {
                displayText += " URGENT!";
            }
            return displayText;
        }
    }
}

