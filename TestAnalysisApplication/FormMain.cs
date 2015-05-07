using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using TextAnalysisAppControl;
using System.Windows.Forms.DataVisualization.Charting;

namespace TextAnalysisApp
{
    public partial class FormMain : Form
    {
        private TextAnalysisAppControl.TextAnalysisControl _textAnalysis;
        private bool _loaded;

        public FormMain()
        {
            InitializeComponent();
            _loaded = false;
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "TXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Reset();
                richTextBoxMostCommonWords.Text = openFileDialog.FileName;
                var streamReader = new StreamReader(openFileDialog.FileName);
                string line;
                var data = new List<string>();
                while ((line = streamReader.ReadLine()) != null)
                {
                    data.AddRange(line.Split(' '));
                }
                _textAnalysis = new TextAnalysisControl(data);

                TextBoxesInitiation();
                ChartInitiation();
                _loaded = true;
            }
        }

        private void Reset()
        {
            richTextBoxMostCommonWords.Text = "";
            richTextBoxLongestWords.Text = "";
            richTextBoxShortestWords.Text = "";
            richTextBoxAverageWordLength.Text = "";
            richTextBoxSearchWord.Text = "";
            richTextBoxSearchLength.Text = "";
            richTextBoxUniqWords.Text = "";
        }

        private void TextBoxesInitiation()
        {
            richTextBoxMostCommonWords.Text = _textAnalysis.GetMostCommonWords();
            richTextBoxLongestWords.Text = _textAnalysis.GetLongestWords();
            richTextBoxShortestWords.Text = _textAnalysis.GetShortestWords();
            richTextBoxAverageWordLength.Text = _textAnalysis.GetAverageLength();
            richTextBoxUniqWords.Text = _textAnalysis.GetUniqWords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_loaded == true)
            {
                string word = textBoxSearchWord.Text;
                richTextBoxSearchWord.Text = _textAnalysis.GetOccurOfWord(word);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            if (_loaded == true)
            {
                if (int.TryParse(textBoxSearchLength.Text, out n))
                {
                    int length = Convert.ToInt32(textBoxSearchLength.Text);
                    richTextBoxSearchLength.Text = _textAnalysis.GetWordsOfLength(length);
                }
                else
                {
                    MessageBox.Show("Invalid input, please input a integer.");
                }
            }
        }

        public void ChartInitiation()
        {
            chartWordOccur.Invalidate();
            chartWordOccur.Update();

            chartWordOccur.Location = new System.Drawing.Point(43, 506);
            chartWordOccur.Name = "chart1";
            chartWordOccur.Size = new System.Drawing.Size(1097, 282);
            chartWordOccur.TabIndex = 19;
            chartWordOccur.Text = "chart1";
            chartWordOccur.ChartAreas.Add(new ChartArea());

            chartWordOccur.Series.Add(new Series());
            chartWordOccur.Series[0].ChartType = SeriesChartType.Column;
            chartWordOccur.Series[0].Points.DataBindXY(_textAnalysis.GetWordOccur().Keys, _textAnalysis.GetWordOccur().Values);
            chartWordOccur.Series[0].Name = "Words";

            chartWordOccur.Legends.Add(new Legend());
            chartWordOccur.Legends[0].Name = "legend1";
            chartWordOccur.Series["Words"].Legend = "legend1";
            chartWordOccur.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartWordOccur.ChartAreas[0].AxisX.Interval = 1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
