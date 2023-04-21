using System.Collections.Generic;

namespace BasketballMatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmbWin.Text == "")
            {
                MessageBox.Show("Invalid, please choose the team");
                return;
            }



            // repeat till there is a winner (no tie)

            Random random = new Random();
            string win = "";
            int lakersPoints;
            int heatPoints;

            do
            {
                lakersPoints = random.Next(70, 120);
                heatPoints = random.Next(70, 120);
    
                win = "";
                if (lakersPoints > heatPoints)
                {
                    win = "Lakers";
                }
                else if (lakersPoints < heatPoints) 
                {
                    win = "Heat";
                }
            }
            while (win == "");

            lblResult.Text = "Result: Lakers " + lakersPoints + " - " + heatPoints + " Heat" + Environment.NewLine;

            if ((win == "Lakers" && cmbWin.Text == "Lakers") || (win == "Heat" && cmbWin.Text == "Heat"))
            {
                lblResult.Text = lblResult.Text + "You won ";
            }
            else
            {
                lblResult.Text = lblResult.Text + "You lost. The winner was " + win + Environment.NewLine;
            }
        }
    }
}