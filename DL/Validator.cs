using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DL
{
    public class Validator
    {
        //private PodcastController podcastController;
        //public EpisodeController episodeController = new EpisodeController();
       //public CategoryController categoryController = new CategoryController();

        public Validator ()
        {
           // podcastController = new PodcastController();

        }
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
