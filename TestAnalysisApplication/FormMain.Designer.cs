namespace TextAnalysisApp
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMostCommonWords = new System.Windows.Forms.Label();
            this.labelLongestWords = new System.Windows.Forms.Label();
            this.labelShortestWords = new System.Windows.Forms.Label();
            this.labelAverageWordLength = new System.Windows.Forms.Label();
            this.labelSearchWord = new System.Windows.Forms.Label();
            this.labelSearchLength = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxMostCommonWords = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLongestWords = new System.Windows.Forms.RichTextBox();
            this.richTextBoxShortestWords = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAverageWordLength = new System.Windows.Forms.RichTextBox();
            this.textBoxSearchWord = new System.Windows.Forms.TextBox();
            this.textBoxSearchLength = new System.Windows.Forms.TextBox();
            this.richTextBoxSearchWord = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSearchLength = new System.Windows.Forms.RichTextBox();
            this.richTextBoxUniqWords = new System.Windows.Forms.RichTextBox();
            this.buttonSearchWord = new System.Windows.Forms.Button();
            this.buttonSearchLength = new System.Windows.Forms.Button();
            this.chartWordOccur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWordOccur)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // labelMostCommonWords
            // 
            this.labelMostCommonWords.AutoSize = true;
            this.labelMostCommonWords.Location = new System.Drawing.Point(40, 40);
            this.labelMostCommonWords.Name = "labelMostCommonWords";
            this.labelMostCommonWords.Size = new System.Drawing.Size(142, 17);
            this.labelMostCommonWords.TabIndex = 1;
            this.labelMostCommonWords.Text = "Most Common Words";
            // 
            // labelLongestWords
            // 
            this.labelLongestWords.AutoSize = true;
            this.labelLongestWords.Location = new System.Drawing.Point(40, 160);
            this.labelLongestWords.Name = "labelLongestWords";
            this.labelLongestWords.Size = new System.Drawing.Size(104, 17);
            this.labelLongestWords.TabIndex = 2;
            this.labelLongestWords.Text = "Longest Words";
            // 
            // labelShortestWords
            // 
            this.labelShortestWords.AutoSize = true;
            this.labelShortestWords.Location = new System.Drawing.Point(40, 280);
            this.labelShortestWords.Name = "labelShortestWords";
            this.labelShortestWords.Size = new System.Drawing.Size(106, 17);
            this.labelShortestWords.TabIndex = 3;
            this.labelShortestWords.Text = "Shortest Words";
            // 
            // labelAverageWordLength
            // 
            this.labelAverageWordLength.AutoSize = true;
            this.labelAverageWordLength.Location = new System.Drawing.Point(40, 400);
            this.labelAverageWordLength.Name = "labelAverageWordLength";
            this.labelAverageWordLength.Size = new System.Drawing.Size(147, 17);
            this.labelAverageWordLength.TabIndex = 4;
            this.labelAverageWordLength.Text = "Average Word Length";
            // 
            // labelSearchWord
            // 
            this.labelSearchWord.AutoSize = true;
            this.labelSearchWord.Location = new System.Drawing.Point(600, 40);
            this.labelSearchWord.Name = "labelSearchWord";
            this.labelSearchWord.Size = new System.Drawing.Size(91, 17);
            this.labelSearchWord.TabIndex = 5;
            this.labelSearchWord.Text = "Search Word";
            // 
            // labelSearchLength
            // 
            this.labelSearchLength.AutoSize = true;
            this.labelSearchLength.Location = new System.Drawing.Point(600, 160);
            this.labelSearchLength.Name = "labelSearchLength";
            this.labelSearchLength.Size = new System.Drawing.Size(101, 17);
            this.labelSearchLength.TabIndex = 6;
            this.labelSearchLength.Text = "Search Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "List Of All Unique Words";
            // 
            // richTextBoxMostCommonWords
            // 
            this.richTextBoxMostCommonWords.Location = new System.Drawing.Point(220, 40);
            this.richTextBoxMostCommonWords.Name = "richTextBoxMostCommonWords";
            this.richTextBoxMostCommonWords.Size = new System.Drawing.Size(300, 96);
            this.richTextBoxMostCommonWords.TabIndex = 8;
            this.richTextBoxMostCommonWords.Text = "";
            // 
            // richTextBoxLongestWords
            // 
            this.richTextBoxLongestWords.Location = new System.Drawing.Point(220, 160);
            this.richTextBoxLongestWords.Name = "richTextBoxLongestWords";
            this.richTextBoxLongestWords.Size = new System.Drawing.Size(300, 96);
            this.richTextBoxLongestWords.TabIndex = 9;
            this.richTextBoxLongestWords.Text = "";
            // 
            // richTextBoxShortestWords
            // 
            this.richTextBoxShortestWords.Location = new System.Drawing.Point(220, 280);
            this.richTextBoxShortestWords.Name = "richTextBoxShortestWords";
            this.richTextBoxShortestWords.Size = new System.Drawing.Size(300, 96);
            this.richTextBoxShortestWords.TabIndex = 10;
            this.richTextBoxShortestWords.Text = "";
            // 
            // richTextBoxAverageWordLength
            // 
            this.richTextBoxAverageWordLength.Location = new System.Drawing.Point(220, 400);
            this.richTextBoxAverageWordLength.Name = "richTextBoxAverageWordLength";
            this.richTextBoxAverageWordLength.Size = new System.Drawing.Size(300, 96);
            this.richTextBoxAverageWordLength.TabIndex = 11;
            this.richTextBoxAverageWordLength.Text = "";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(720, 40);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearchWord.TabIndex = 12;
            // 
            // textBoxSearchLength
            // 
            this.textBoxSearchLength.Location = new System.Drawing.Point(720, 160);
            this.textBoxSearchLength.Name = "textBoxSearchLength";
            this.textBoxSearchLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearchLength.TabIndex = 13;
            // 
            // richTextBoxSearchWord
            // 
            this.richTextBoxSearchWord.Location = new System.Drawing.Point(840, 40);
            this.richTextBoxSearchWord.Name = "richTextBoxSearchWord";
            this.richTextBoxSearchWord.Size = new System.Drawing.Size(300, 96);
            this.richTextBoxSearchWord.TabIndex = 14;
            this.richTextBoxSearchWord.Text = "";
            // 
            // richTextBoxSearchLength
            // 
            this.richTextBoxSearchLength.Location = new System.Drawing.Point(840, 160);
            this.richTextBoxSearchLength.Name = "richTextBoxSearchLength";
            this.richTextBoxSearchLength.Size = new System.Drawing.Size(300, 96);
            this.richTextBoxSearchLength.TabIndex = 15;
            this.richTextBoxSearchLength.Text = "";
            // 
            // richTextBoxUniqWords
            // 
            this.richTextBoxUniqWords.Location = new System.Drawing.Point(600, 300);
            this.richTextBoxUniqWords.Name = "richTextBoxUniqWords";
            this.richTextBoxUniqWords.Size = new System.Drawing.Size(540, 200);
            this.richTextBoxUniqWords.TabIndex = 16;
            this.richTextBoxUniqWords.Text = "";
            // 
            // buttonSearchWord
            // 
            this.buttonSearchWord.Location = new System.Drawing.Point(720, 69);
            this.buttonSearchWord.Name = "buttonSearchWord";
            this.buttonSearchWord.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchWord.TabIndex = 17;
            this.buttonSearchWord.Text = "Search";
            this.buttonSearchWord.UseVisualStyleBackColor = true;
            this.buttonSearchWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearchLength
            // 
            this.buttonSearchLength.Location = new System.Drawing.Point(720, 189);
            this.buttonSearchLength.Name = "buttonSearchLength";
            this.buttonSearchLength.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchLength.TabIndex = 18;
            this.buttonSearchLength.Text = "Search";
            this.buttonSearchLength.UseVisualStyleBackColor = true;
            this.buttonSearchLength.Click += new System.EventHandler(this.button2_Click);
            // 
            // chartWordOccur
            // 
            this.chartWordOccur.Location = new System.Drawing.Point(43, 506);
            this.chartWordOccur.Name = "chartWordOccur";
            this.chartWordOccur.Size = new System.Drawing.Size(1097, 282);
            this.chartWordOccur.TabIndex = 19;
            this.chartWordOccur.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.chartWordOccur);
            this.Controls.Add(this.buttonSearchLength);
            this.Controls.Add(this.buttonSearchWord);
            this.Controls.Add(this.richTextBoxUniqWords);
            this.Controls.Add(this.richTextBoxSearchLength);
            this.Controls.Add(this.richTextBoxSearchWord);
            this.Controls.Add(this.textBoxSearchLength);
            this.Controls.Add(this.textBoxSearchWord);
            this.Controls.Add(this.richTextBoxAverageWordLength);
            this.Controls.Add(this.richTextBoxShortestWords);
            this.Controls.Add(this.richTextBoxLongestWords);
            this.Controls.Add(this.richTextBoxMostCommonWords);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSearchLength);
            this.Controls.Add(this.labelSearchWord);
            this.Controls.Add(this.labelAverageWordLength);
            this.Controls.Add(this.labelShortestWords);
            this.Controls.Add(this.labelLongestWords);
            this.Controls.Add(this.labelMostCommonWords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWordOccur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelMostCommonWords;
        private System.Windows.Forms.Label labelLongestWords;
        private System.Windows.Forms.Label labelShortestWords;
        private System.Windows.Forms.Label labelAverageWordLength;
        private System.Windows.Forms.Label labelSearchWord;
        private System.Windows.Forms.Label labelSearchLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxMostCommonWords;
        private System.Windows.Forms.RichTextBox richTextBoxLongestWords;
        private System.Windows.Forms.RichTextBox richTextBoxShortestWords;
        private System.Windows.Forms.RichTextBox richTextBoxAverageWordLength;
        private System.Windows.Forms.TextBox textBoxSearchWord;
        private System.Windows.Forms.TextBox textBoxSearchLength;
        private System.Windows.Forms.RichTextBox richTextBoxSearchWord;
        private System.Windows.Forms.RichTextBox richTextBoxSearchLength;
        private System.Windows.Forms.RichTextBox richTextBoxUniqWords;
        private System.Windows.Forms.Button buttonSearchWord;
        private System.Windows.Forms.Button buttonSearchLength;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWordOccur;
    }
}

