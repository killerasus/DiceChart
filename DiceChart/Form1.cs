using System;
using System.IO;
using System.Windows.Forms;

namespace DiceChart
{

    public partial class DiceChartMainWindow : Form
    {
        const int ITERATIONS = 10000;

        public DiceChartMainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates the histogram data using the selected dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();

            int number = (int) diceNumber.Value;
            object selectedDice = diceType.SelectedItem;

            if (selectedDice == null)
            {
                return;
            }

            int dice = int.Parse( selectedDice.ToString() );

            int[] diceRolls = new int[ITERATIONS];

            for(int i = 0; i < ITERATIONS; ++i)
            {
                for (int j = 0; j < number; ++j)
                {
                    diceRolls[i] += randomGenerator.Next(1, dice + 1);
                }
            }

            int[] values = new int[number * dice + 1];

            for(int i = 0; i < ITERATIONS; ++i)
            {
                values[diceRolls[i]]++;
            }

            diceHistogram.Series.Clear();
            diceHistogram.Series.Add("Dice: " + number + "d" + dice);
            diceHistogram.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            diceHistogram.Legends.Clear();

            for(int i = number; i < values.Length; ++i)
            {
                diceHistogram.Series[0].Points.AddXY(i, values[i]);
            }

            diceHistogram.ChartAreas[0].AxisX.Title = "Dice: " + number + "d" + dice;
            diceHistogram.ChartAreas[0].AxisY.Title = "Rolls in " + ITERATIONS;
            diceHistogram.Update();
        }

        /// <summary>
        /// Saves the charted histogram to a JPG file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToImageButton_Click(object sender, EventArgs e)
        {
            Stream imageStream;
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;

            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                imageStream = saveDialog.OpenFile();
                if( imageStream != null )
                {
                    using (imageStream)
                    {
                        diceHistogram.SaveImage(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }
    }
}
