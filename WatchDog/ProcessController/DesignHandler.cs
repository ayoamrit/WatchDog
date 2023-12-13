using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchDog.ExceptionHandler;

namespace WatchDog.ProcessController
{
    /// <summary>
    /// Handles the design aspects of ListView items, such as coloring rows
    /// </summary>
    public class DesignHandler
    {
        //static field to keep track of the row number for alternating colors
        private static int rowNumber = 1;

        //Default background color for odd rows
        string backgroundColor = "#f0f0f0";

        /// <summary>
        /// Init a new instance of <see cref="DesignHandler"/> class
        /// </summary>
        /// <param name="listViewItem">The list view to be styled</param>
        /// <exception cref="DesignException">Exception</exception>
        public DesignHandler(ListViewItem listViewItem)
        {

            try
            {
                //Check if the row is odd or even to determine the background color
                if (rowNumber % 2 == 0)
                {
                    listViewItem.BackColor = Color.White;
                }
                else
                {
                    listViewItem.BackColor = ColorTranslator.FromHtml(backgroundColor);
                }

                //Increment the row number for the next ListViewItem
                rowNumber++;
            }
            catch (Exception)
            {
                //If an exception occurs during the design process
                throw new DesignException("Error occurred while coloring rows of the list");
            }
        }

        /// <summary>
        /// Resets the static row number to its initial value
        /// </summary>
        public static void ResetRowNumber()
        {
            rowNumber = 1;
        }
    }
}
