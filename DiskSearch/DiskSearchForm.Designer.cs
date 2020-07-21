namespace DiskSearch
{
    partial class DiskSearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiskSearchForm));
            this.FilesTreeView = new System.Windows.Forms.TreeView();
            this.FileSearchSymbolsTextBox = new System.Windows.Forms.TextBox();
            this.StartSearchButton = new System.Windows.Forms.Button();
            this.FileNamePatternTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartingDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentProcessingFileStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProcessedFilesCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimePassedAfterStartStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentStateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SearchProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StopSearchButton = new System.Windows.Forms.Button();
            this.ChooseDirectoryButton = new System.Windows.Forms.Button();
            this.AfterStartTimer = new System.Windows.Forms.Timer(this.components);
            this.SearchContinueButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesTreeView
            // 
            this.FilesTreeView.Location = new System.Drawing.Point(12, 12);
            this.FilesTreeView.Name = "FilesTreeView";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Node2";
            treeNode7.Name = "Node3";
            treeNode7.Text = "Node3";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Node0";
            this.FilesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.FilesTreeView.Size = new System.Drawing.Size(347, 371);
            this.FilesTreeView.TabIndex = 0;
            // 
            // FileSearchSymbolsTextBox
            // 
            this.FileSearchSymbolsTextBox.Location = new System.Drawing.Point(474, 77);
            this.FileSearchSymbolsTextBox.Name = "FileSearchSymbolsTextBox";
            this.FileSearchSymbolsTextBox.Size = new System.Drawing.Size(301, 20);
            this.FileSearchSymbolsTextBox.TabIndex = 1;
            // 
            // StartSearchButton
            // 
            this.StartSearchButton.Location = new System.Drawing.Point(538, 103);
            this.StartSearchButton.Name = "StartSearchButton";
            this.StartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.StartSearchButton.TabIndex = 3;
            this.StartSearchButton.Text = "Start Search";
            this.StartSearchButton.UseVisualStyleBackColor = true;
            this.StartSearchButton.Click += new System.EventHandler(this.StartSearchButton_Click);
            // 
            // FileNamePatternTextBox
            // 
            this.FileNamePatternTextBox.Location = new System.Drawing.Point(474, 40);
            this.FileNamePatternTextBox.Name = "FileNamePatternTextBox";
            this.FileNamePatternTextBox.Size = new System.Drawing.Size(301, 20);
            this.FileNamePatternTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File name pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Symbols in file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Starting directory";
            // 
            // StartingDirectoryPathTextBox
            // 
            this.StartingDirectoryPathTextBox.Location = new System.Drawing.Point(117, 402);
            this.StartingDirectoryPathTextBox.Name = "StartingDirectoryPathTextBox";
            this.StartingDirectoryPathTextBox.Size = new System.Drawing.Size(526, 20);
            this.StartingDirectoryPathTextBox.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentProcessingFileStatusLabel,
            this.ProcessedFilesCountStatusLabel,
            this.TimePassedAfterStartStatusLabel,
            this.CurrentStateStatusLabel,
            this.SearchProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CurrentProcessingFileStatusLabel
            // 
            this.CurrentProcessingFileStatusLabel.AutoSize = false;
            this.CurrentProcessingFileStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CurrentProcessingFileStatusLabel.Name = "CurrentProcessingFileStatusLabel";
            this.CurrentProcessingFileStatusLabel.Size = new System.Drawing.Size(306, 19);
            this.CurrentProcessingFileStatusLabel.Spring = true;
            this.CurrentProcessingFileStatusLabel.Text = "CurrentProcessingFile";
            this.CurrentProcessingFileStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProcessedFilesCountStatusLabel
            // 
            this.ProcessedFilesCountStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ProcessedFilesCountStatusLabel.Name = "ProcessedFilesCountStatusLabel";
            this.ProcessedFilesCountStatusLabel.Size = new System.Drawing.Size(120, 19);
            this.ProcessedFilesCountStatusLabel.Text = "ProcessedFilesCount";
            // 
            // TimePassedAfterStartStatusLabel
            // 
            this.TimePassedAfterStartStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TimePassedAfterStartStatusLabel.Name = "TimePassedAfterStartStatusLabel";
            this.TimePassedAfterStartStatusLabel.Size = new System.Drawing.Size(124, 19);
            this.TimePassedAfterStartStatusLabel.Text = "TimePassedAfterStart";
            // 
            // CurrentStateStatusLabel
            // 
            this.CurrentStateStatusLabel.Name = "CurrentStateStatusLabel";
            this.CurrentStateStatusLabel.Size = new System.Drawing.Size(133, 19);
            this.CurrentStateStatusLabel.Text = "CurrentStateStatusLabel";
            // 
            // SearchProgressBar
            // 
            this.SearchProgressBar.Name = "SearchProgressBar";
            this.SearchProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // StopSearchButton
            // 
            this.StopSearchButton.Location = new System.Drawing.Point(619, 103);
            this.StopSearchButton.Name = "StopSearchButton";
            this.StopSearchButton.Size = new System.Drawing.Size(75, 23);
            this.StopSearchButton.TabIndex = 10;
            this.StopSearchButton.Text = "Stop Search";
            this.StopSearchButton.UseVisualStyleBackColor = true;
            this.StopSearchButton.Click += new System.EventHandler(this.StopSearchButton_Click);
            // 
            // ChooseDirectoryButton
            // 
            this.ChooseDirectoryButton.Location = new System.Drawing.Point(649, 400);
            this.ChooseDirectoryButton.Name = "ChooseDirectoryButton";
            this.ChooseDirectoryButton.Size = new System.Drawing.Size(139, 23);
            this.ChooseDirectoryButton.TabIndex = 11;
            this.ChooseDirectoryButton.Text = "Choose directory";
            this.ChooseDirectoryButton.UseVisualStyleBackColor = true;
            this.ChooseDirectoryButton.Click += new System.EventHandler(this.ChooseDirectoryButton_Click);
            // 
            // SearchContinueButton
            // 
            this.SearchContinueButton.Location = new System.Drawing.Point(700, 103);
            this.SearchContinueButton.Name = "SearchContinueButton";
            this.SearchContinueButton.Size = new System.Drawing.Size(75, 23);
            this.SearchContinueButton.TabIndex = 12;
            this.SearchContinueButton.Text = "Continue";
            this.SearchContinueButton.UseVisualStyleBackColor = true;
            this.SearchContinueButton.Click += new System.EventHandler(this.SearchContinueButton_Click);
            // 
            // DiskSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchContinueButton);
            this.Controls.Add(this.ChooseDirectoryButton);
            this.Controls.Add(this.StopSearchButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StartingDirectoryPathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileNamePatternTextBox);
            this.Controls.Add(this.StartSearchButton);
            this.Controls.Add(this.FileSearchSymbolsTextBox);
            this.Controls.Add(this.FilesTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiskSearchForm";
            this.Text = "DiskSearch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiskSearchForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView FilesTreeView;
        private System.Windows.Forms.TextBox FileSearchSymbolsTextBox;
        private System.Windows.Forms.Button StartSearchButton;
        private System.Windows.Forms.TextBox FileNamePatternTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StartingDirectoryPathTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentProcessingFileStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar SearchProgressBar;
        private System.Windows.Forms.Button StopSearchButton;
        private System.Windows.Forms.ToolStripStatusLabel ProcessedFilesCountStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimePassedAfterStartStatusLabel;
        private System.Windows.Forms.Button ChooseDirectoryButton;
        private System.Windows.Forms.ToolStripStatusLabel CurrentStateStatusLabel;
        private System.Windows.Forms.Timer AfterStartTimer;
        private System.Windows.Forms.Button SearchContinueButton;
    }
}

