using WatchDog.ProcessController;
using WatchDog.ExceptionHandler;

namespace WatchDog
{
    public partial class Form1 : Form
    {
        private Thread thread = null;

        public Form1()
        {
            InitializeComponent();

            try
            {
                thread = new Thread(() =>
                {
                    ProcessHandler processHandler = new ProcessHandler(ProcessListView);
                });


                thread.Start();

            }
            catch(ProcessDataException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}