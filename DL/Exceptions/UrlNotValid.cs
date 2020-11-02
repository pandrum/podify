using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DL.Exceptions
{
    public class UrlNotValid : Exception
    {
        public UrlNotValid()
        {
        }

        public UrlNotValid(string message) : base(message)
        {
            MessageBox.Show(message);
        }
    }
}