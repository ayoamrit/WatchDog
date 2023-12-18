using WatchDog.ProcessController;
using WatchDog.ExceptionHandler;

namespace WatchDog
{
    public partial class Form1 : Form
    {
        private Thread thread = null;
        private int processId = 0;

        public Form1()
        {
            InitializeComponent();

            try
            {
                //Init a new thread to handle process information
                thread = new Thread(() =>
                {
                    //Create a instance of ProcessHandler, passing the ProcessListView as a parameter
                    ProcessHandler processHandler = new ProcessHandler(ProcessListView);
                });

                //Start the thread
                thread.Start();

            }
            catch (ProcessDataException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch(ThreadException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DesignException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ItemSelectionException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(TerminateTaskException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Error occurred");
            }
        }

        //Event handler for the ItemSelectionChanged event of the ProcessListView
        private void ProcessListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            try
            {
                //Get the process ID from the selected of the process item in the processListView
                processId = Convert.ToInt32(ProcessListView.SelectedItems[0]);
            }catch(Exception ex)
            {
                //If an error occurs during the selection of the process, theow an ItemSelectionException
                throw new ItemSelectionException($"An error occurred during the selection of the process: {ex.Message}");
            }
            
        }

        private void EndTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of ProcessTerminator, passing the processId as a parameter
                ProcessTerminator processorTerminator = new ProcessTerminator(processId);
            }
            catch (Exception ex)
            {
                //If an error occurs during the termination of the task, throw a TerminateTaskException
                throw new TerminateTaskException($"An error occurred during the termination of the task '{processId}': {ex.Message}");
            }
        }

        //Event handlerfor the form closing event
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            //Exit the application when the form is coming
            Environment.Exit(0);
        }

    }
}