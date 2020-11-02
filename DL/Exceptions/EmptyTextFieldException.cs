using System;
using System.Windows.Forms;

namespace DL.Exceptions
{
    public class EmptyTextFieldException : Exception
    {
        public EmptyTextFieldException()
        {
            MessageBox.Show("Textfield is empty.");
        }

        public EmptyTextFieldException(string message) : base(message)
        {
            MessageBox.Show(message);
        }
    }
}