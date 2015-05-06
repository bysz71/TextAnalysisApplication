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

        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "TXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Reset();
                richTextBox1.Text = openFileDialog.FileName;
                var streamReader = new StreamReader(openFileDialog.FileName);
                string line;
                var data = new List<string>();
                while ((line = streamReader.ReadLine()) != null)
                {
                    //richTextBox8.Text += line;//output to test textbox
                    data.AddRange(line.Split(' '));
                }
                _textAnalysis = new TextAnalysisControl(data);


                TextBoxesInitiation();
                ChartInitiation();
            }
        }

        private void Reset()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";
            richTextBox7.Text = "";
            //chart1 = null;
        }

        private void TextBoxesInitiation()
        {
            richTextBox1.Text = _textAnalysis.GetMostCommonWords();
            richTextBox2.Text = _textAnalysis.GetLongestWords();
            richTextBox3.Text = _textAnalysis.GetShortestWords();
            richTextBox4.Text = _textAnalysis.GetAverageLength();
            richTextBox7.Text = _textAnalysis.GetUniqWords();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            richTextBox5.Text = _textAnalysis.GetOccurOfWord(word);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox2.Text, out n))
            {
                int length = Convert.ToInt32(textBox2.Text);
                richTextBox6.Text = _textAnalysis.GetWordsOfLength(length);
            }
            else
            {
                MessageBox.Show("Invalid input, please input a integer.");
            }

        }

        public void ChartInitiation()
        {
            //chart1 = new Chart();
            //((System.ComponentModel.ISupportInitialize)(chart1)).BeginInit();
            chart1.Location = new System.Drawing.Point(43, 506);
            chart1.Name = "chart1";
            chart1.Size = new System.Drawing.Size(1097, 282);
            chart1.TabIndex = 19;
            chart1.Text = "chart1";
            ChartArea area1 = new ChartArea();
            area1.Name = "area";
            chart1.ChartAreas.Add(area1);
            Series words = new Series();
            words.ChartType = SeriesChartType.Column;
            words.Points.DataBindXY(_textAnalysis.GetWordOccur().Keys , _textAnalysis.GetWordOccur().Values);
            words.Name = "Words";
            chart1.Series.Add(words);
            Legend legend = new Legend();
            legend.Name = "legend1";
            chart1.Legends.Add(legend);
            chart1.Series["Words"].Legend = "legend1";
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            //((System.ComponentModel.ISupportInitialize)(chart1)).EndInit();
        }

        

    }
}
