using System;
using System.Windows.Forms;

namespace DL
{
    public class DuplicateException : Exception
    {
        public DuplicateException()
        {
            MessageBox.Show("Item already exists in the list.");
        }

        public DuplicateException(string message) : base(message)
        {
            MessageBox.Show(message);
        }
    }
}