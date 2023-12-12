using WatchDog.ProcessController;

namespace WatchDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProcessHandler processHandler = new ProcessHandler(ProcessListView);
        }

    }
}