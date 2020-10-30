using Model;
using System.Windows.Forms;

namespace DL
{
    public class Validator
    {
        public bool IntervalHasValue(ComboBox interval)
        {
            bool isValid = true;
            if (interval.SelectedItem == null)
            {
                MessageBox.Show("You must choose an interval!");
                isValid = false;
            }

            return isValid;

            // Kolla om url är korrekt ifylld

            // Kolla om url har tilldelats ett namn
        }
    }
}