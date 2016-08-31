using System;
using System.Windows.Forms;

namespace DiceChart
{

    public partial class Form1 : Form
    {
        const int ITERATIONS = 10000;

        public Form1()
        {
            InitializeComponent();
        }

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

            diceHistogram.Update();
        }
    }
}
