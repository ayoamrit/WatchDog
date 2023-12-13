using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessController
{
    public class DesignHandler
    {
        private static int rowNumber = 1;
        string backgroundColor = "#f0f0f0";
        public DesignHandler(ListViewItem listViewItem)
        {
            if(rowNumber % 2 == 0)
            {
                listViewItem.BackColor = Color.White;
            }
            else
            {
                listViewItem.BackColor = ColorTranslator.FromHtml(backgroundColor);
            }

            rowNumber++;
        }

        public static void ResetRowNumber()
        {
            rowNumber = 1;
        }
    }
}
