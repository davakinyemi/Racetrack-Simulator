using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public partial class Form1 : Form
    {
        private int minBet = 5;
        private int numOfDogs = 4;
        private int Cash = 100;
        private int numBettors = 3;
        Greyhound[] greyhounds;
        Bettor[] bettors;
        Control[] allPicBoxes;
        private Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var c = GetAll(this, typeof(PictureBox));
            allPicBoxes = c.ToArray();
            minBetLabel.Text = "Minimum bet: " + minBet + " bucks";
            betNumUpDown.Minimum = minBet;
            initializeGreyhounds();
            initializeBettors();
        }

        private static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void initializeGreyhounds()
        {
            greyhounds = new Greyhound[numOfDogs];
            int a = allPicBoxes.Length-1;
            for(int i = 0; i < allPicBoxes.Length; i++)
            {
                if(!allPicBoxes[i].Name.Equals(trackPictureBox.Name))
                {
                    greyhounds[i] = new Greyhound(trackPictureBox.Left, trackPictureBox.Width, (PictureBox) allPicBoxes[a--], randomizer);
                }
            }
        }

        private void initializeBettors()
        {
            bettors = new Bettor[numBettors];
            bettors[0] = new Bettor("Joe", Cash, joeRadioButton, joeBetLabel);
            bettors[1] = new Bettor("Bob", Cash, bobRadioButton, bobBetLabel);
            bettors[2] = new Bettor("Al", Cash, alRadioButton, alBetLabel);
            joeRadioButton.Checked = true;
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = "Al";
        }
    }
}
