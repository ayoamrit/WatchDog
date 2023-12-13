using WatchDog.ProcessController;

namespace WatchDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Thread processThread = new Thread(() =>
            {
                ProcessHandler processHandler = new ProcessHandler(ProcessListView);
            });

            processThread.Start();
        }

    }
}