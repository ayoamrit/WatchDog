using WatchDog.ProcessController;

namespace WatchDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProcessHandler processHandler = new ProcessHandler(ProcessListView);


            //ListViewItem listViewItems = new ListViewItem(new String[] { "123", "Google Chrome", "Active", "223", "34", "654", "0" });
            //ListViewItem listViewItems2 = new ListViewItem(new String[] { "1232", "Google Chrome", "Active", "223", "34", "654", "0" });
            //ListViewItem listViewItems3 = new ListViewItem(new String[] { "1233", "Google Chrome", "Active", "223", "34", "654", "0" });
            //ListViewItem listViewItems4 = new ListViewItem(new String[] { "1234", "Google Chrome", "Active", "223", "34", "654", "0" });

            //ProcessListView.Items.Add(listViewItems);
            //ProcessListView.Items.Add(listViewItems2);
            //ProcessListView.Items.Add(listViewItems3);
            //ProcessListView.Items.Add(listViewItems4);

            //for(int x = 0; x < ProcessListView.Items.Count; x++)
            //{
            //    ProcessListView.Items[x].BackColor = Color.Red;
            //}
        }

    }
}