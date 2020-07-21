using System;
using System.IO;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DiskSearch
{
    public partial class DiskSearchForm : Form
    {
        int milliseconds_passed = 0;
        int processed_files_count = 0;
        TreeNode start_search_treeNode = null;
        string search_pattern = "";
        string search_symbols = "";
        ManualResetEvent terminate = new ManualResetEvent(true);
        CancellationToken token;
        CancellationTokenSource tokenSource;
        

        public DiskSearchForm()
        {
            InitializeComponent();

            this.StartingDirectoryPathTextBox.Text = (string)Properties.Settings.Default["StartingSearchDirPath"];
            this.FileNamePatternTextBox.Text = (string)Properties.Settings.Default["FileNamePattern"];
            this.FileSearchSymbolsTextBox.Text = (string)Properties.Settings.Default["FileSearchRegex"];
            this.FilesTreeView.Nodes.Clear();
            this.AfterStartTimer.Tick += AfterStartTimer_Tick;
        }

        private void AfterStartTimer_Tick(object sender, EventArgs e)
        {
            this.milliseconds_passed += this.AfterStartTimer.Interval;
            this.TimePassedAfterStartStatusLabel.Text = $"{((float)this.milliseconds_passed / 1000.0f),14:F1}s";
        }

        private bool isFileContainSymbols(string path, string symbols, CancellationTokenSource ts)
        {
            bool[] symbols_present = new bool[symbols.Length];
            for(int i = 0; i < symbols_present.Length; i++)
            {
                symbols_present[i] = false;
            }

            using (StreamReader streamReader = File.OpenText(path))
            {
                while(!streamReader.EndOfStream)
                {
                    char ch = (char)streamReader.Read();
                    for(int i = 0; i < symbols.Length; i++)
                    {
                        if (ch == symbols[i])
                            symbols_present[i] = true;
                    }
                }
            }

            foreach (bool sp in symbols_present)
            {
                if (!sp) return false;
            }

            return true;
        }

        private void buildFileSystemTreeView(TreeNode CurrentTreeNode, DirectoryInfo directoryInfo, CancellationTokenSource ts)
        {
            foreach (var f in directoryInfo.GetFiles(this.search_pattern))
            {
                terminate.WaitOne();
                if (ts.IsCancellationRequested)
                {
                    this.processed_files_count = 0;
                    return;
                }

                if (this.search_symbols == "" 
                    || isFileContainSymbols(f.FullName, this.search_symbols, ts))
                {
                    CurrentTreeNode.Nodes.Add(f.Name);
                }

                this.CurrentProcessingFileStatusLabel.Text = f.Name;
                this.ProcessedFilesCountStatusLabel.Text = $"{++processed_files_count,3} files processed";
            }

            foreach (var d in directoryInfo.GetDirectories())
            {
                CurrentTreeNode.Nodes.Add(d.Name);
                int i = CurrentTreeNode.Nodes.Count - 1;
                this.buildFileSystemTreeView(CurrentTreeNode.Nodes[i], new DirectoryInfo(d.FullName), ts);
            }
        }

        private void copyTreeNodeToTreeView(TreeNode tn_from, TreeNode tn_to)
        {
            tn_to.Text = tn_from.Text;
            foreach (TreeNode n in tn_from.Nodes)
            {
                tn_to.Nodes.Add("");
                int i = tn_to.Nodes.Count - 1;
                copyTreeNodeToTreeView(n, tn_to.Nodes[i]);
            }
        }


        private void ChooseDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            browserDialog.ShowDialog();
            if (browserDialog.SelectedPath != "")
                this.StartingDirectoryPathTextBox.Text = browserDialog.SelectedPath;
        }

        private async void StartSearchButton_Click(object sender, EventArgs e)
        {
            this.StopSearchButton.Enabled = true;
            this.tokenSource?.Cancel();
            this.terminate.Set();
            this.tokenSource = new CancellationTokenSource();
            this.token = tokenSource.Token;
            this.StartSearchButton.Enabled = true;
            this.SearchContinueButton.Enabled = false;

            this.CurrentStateStatusLabel.Text = "";
            string path = this.StartingDirectoryPathTextBox.Text;
            if (!Directory.Exists(path))
            {
                this.CurrentStateStatusLabel.Text = "Error!!!No such folder.";
                return;
            }

            this.CurrentStateStatusLabel.Text = "Searching...";
            this.SearchProgressBar.Style = ProgressBarStyle.Marquee;
            this.SearchProgressBar.MarqueeAnimationSpeed = 30;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            this.start_search_treeNode = new TreeNode(directoryInfo.Name);
            this.milliseconds_passed = 0;
            this.processed_files_count = 0;
            this.ProcessedFilesCountStatusLabel.Text = $"{processed_files_count,3} files processed";
            this.AfterStartTimer.Start();
            
            if (this.FileNamePatternTextBox.Text != "")
                this.search_pattern = this.FileNamePatternTextBox.Text;
            else
                this.search_pattern = "*";
            
            this.search_symbols = this.FileSearchSymbolsTextBox.Text;

            CancellationTokenSource ts = this.tokenSource;
            await Task.Run(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                this.buildFileSystemTreeView(this.start_search_treeNode, directoryInfo, ts);
            }, token);
         
            if (ts.IsCancellationRequested)
                return;

            this.FilesTreeView.Nodes.Clear();
            this.FilesTreeView.Nodes.Add("");
            this.copyTreeNodeToTreeView(this.start_search_treeNode, this.FilesTreeView.Nodes[0]);
            this.SearchProgressBar.MarqueeAnimationSpeed = 0;
            this.SearchProgressBar.Style = ProgressBarStyle.Continuous;
            this.AfterStartTimer.Stop();
            this.CurrentStateStatusLabel.Text = "Done.";
            this.StopSearchButton.Enabled = false;
        }

        private void StopSearchButton_Click(object sender, EventArgs e)
        {
            this.StopSearchButton.Enabled = false;
            this.SearchContinueButton.Enabled = true;
            this.terminate.Reset();
            this.AfterStartTimer.Stop();
            this.CurrentStateStatusLabel.Text = "Stoped.";
            this.SearchProgressBar.MarqueeAnimationSpeed = 0;
            this.FilesTreeView.Nodes.Clear();
            this.FilesTreeView.Nodes.Add("");
            copyTreeNodeToTreeView(this.start_search_treeNode, this.FilesTreeView.Nodes[0]);
        }

        private void SearchContinueButton_Click(object sender, EventArgs e)
        {
            this.StopSearchButton.Enabled = true;
            this.SearchContinueButton.Enabled = false;
            this.SearchProgressBar.MarqueeAnimationSpeed = 30;
            this.CurrentStateStatusLabel.Text = "Continue...";
            this.AfterStartTimer.Start();
            this.terminate.Set();
        }

        private void DiskSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default["StartingSearchDirPath"] = this.StartingDirectoryPathTextBox.Text;
            Properties.Settings.Default["FileNamePattern"] = this.FileNamePatternTextBox.Text;
            Properties.Settings.Default["FileSearchRegex"] = this.FileSearchSymbolsTextBox.Text;
            Properties.Settings.Default.Save();
        }

    }
}
