using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double[] freqPlayer = { 0.16, 0.16, 0.16, 0.17, 0.17, 0.18};
        double[] freqComputer = { 0.1, 0.15, 0.15, 0.2, 0.2, 0.2 };
        int rollNum = 0;
        double cScore = 0, pScore = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private double[] RollDice(double[] aboba)
        {
            double[] stats = new double[3];

            for (int i = 0; i < 3; i++)
            {
                var q = (double)rand.NextDouble();
                for (int j = 0; j < aboba.Length; j++)
                {
                     q -= aboba[j];
                    if (q <= 0)
                    {
                        stats[i] = j + 1;
                        break;
                    }
                }
            }
            return stats;
        }

        private void Reset()
        {
            PCube1.Text = PCube2.Text = PCube3.Text = "";
            CCube1.Text = CCube2.Text = CCube3.Text = "";
            lWinner.Text = "";
        }
        
        private string CalculateWinner()
        {
            if (pScore >  cScore) { return "The winner is Player!"; }
            if (pScore <  cScore) { return "The winner is Computer!"; }
            if (pScore == cScore) { return "Draw"; }
            return "";

        }
        private void RollB_Click(object sender, EventArgs e)
        {
            
            double[] Player = RollDice(freqPlayer);
            double[] Computer = RollDice(freqComputer);

            switch (rollNum)
            {
                case 0:
                    Reset();
                    pScore += Player[0]; cScore += Computer[0];

                    PCube1.Text = Player[0] + "";
                    CCube1.Text = Computer[0] + "";
                    rollNum = 1;
                    break;
                case 1:
                    pScore += Player[1]; cScore += Computer[1];

                    PCube2.Text = Player[1] + "";
                    CCube2.Text = Computer[1] + "";
                    rollNum = 2;
                    break;
                case 2:
                    pScore += Player[2]; cScore += Computer[2];

                    PCube3.Text = Player[2] + "";
                    CCube3.Text = Computer[2] + "";
                    rollNum = 0;
                    lWinner.Text = CalculateWinner();
                    break;
            }
        }
    }
}
