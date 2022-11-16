using System.ComponentModel;
using System.Windows.Forms;

namespace Replicate
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation= true;
            worker.WorkerReportsProgress= true;

            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;
        }

        void ReplicateFile(string source, string destination)
        {
            FileStream fsOut = new FileStream(destination, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);

            byte[] bt = new byte[1048756];
            int readByte;

            while((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);
                worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
            }
            fsIn.Close();
            fsOut.Close();
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            ReplicateFile(txtSource.Text, txtDestination.Text);
        }

        private void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblPercentage.Text = progressBar1.Value.ToString() + "%";
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                MessageBox.Show("Replicate Complete!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes Application on button Exit click
            if (MessageBox.Show("This will close the application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = openFile.FileName;
            }
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            if(browse.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = Path.Combine(browse.SelectedPath, Path.GetFileName(txtSource.Text));
            }
        }

        private void btnReplicate_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DirectoryInfo diSource = new(txtSource.Text);
            DirectoryInfo diDestination= new(txtDestination.Text);

            DeleteOpearation(diSource, diDestination);
        }

        private static void DeleteOpearation(DirectoryInfo diSource, DirectoryInfo diDestination)
        {
            if (!diSource.Exists)
            {
                diDestination.Delete(true);
                return;
            }

            // Deleteeach file that exits in the target dir not existing in the source dir
            foreach(FileInfo file in diDestination.GetFiles())
            {
                var sourceFile = Path.Combine(diSource.FullName, file.Name);
                //If the source file does not exist, delete the target file
                if(File.Exists(sourceFile))
                {
                    file.Delete();
                }
            }

            //Delete non existing file in each subdirectory using recursion
            foreach(DirectoryInfo diDestSubDir in diDestination.GetDirectories())
            {
                DirectoryInfo nextSourceSubDir = new DirectoryInfo(Path.Combine(diSource.FullName, diDestSubDir.Name));
                DeleteOpearation(nextSourceSubDir, diDestSubDir);
            }
        }
    }
}