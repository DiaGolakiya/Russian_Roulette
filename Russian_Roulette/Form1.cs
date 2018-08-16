using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    //todo At least one class
    //todo at least two Unit Tests of major Parts
    //todo At least one Sound
    //todo At least one Image
    //todo Sound and Image should be loaded from the resource folder
    //todo All significient code to be commented
    //todo Project should be hosted on Github
    //todo no variable in the code - all in the classes
    //todo WIN / LOSE / TOTAL SCORES button needed
    public partial class Form1 : Form
    {
        GameCode myGameCode = new GameCode();
        private bool ShootAway = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnSpinChambers_Click(object sender, EventArgs e)
        {
            int RNDgenerator()
            {
                Random rndNumber = new Random();
                int rnd = rndNumber.Next(1, 7);
                return rnd;

                //we can do this in real world
                //return  rndNumber.Next(1, 7);
            }
        }

        private void BtnLoadBullet_Click(object sender, EventArgs e)
        {
            //my counter increased by 1 each time i click button
            myGameCode.count += 1;

        }

        private void BtnFire_Click(object sender, EventArgs e)
        {
            //my counter increased by 1 each time i click button
            myGameCode.count += 1;
            //show the counter for testing
            this.Text = myGameCode.count.ToString();

            //if random number = the counter show the cat dont run more code from below.
            int rnd = myGameCode.RNDgenerator();
            lbxOutput.Items.Insert(0, rnd);
            if (myGameCode.count == rnd && ShootAway == true)
            {

                // lbxOutput.Items.Add(0 + "I dont know");
                MessageBox.Show("The....");

                myGameCode.count = 0;
                // dont run any code from below
                return;
            }


        }



        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            //load the splash screen form that was made with design view


            //using system media to play the audio which is played upon start of the main form
            //SoundPlayer Sndplayr = new SoundPlayer(Properties.Resources.RoleMusic);
            //Sndplayr.Play();
        }

        private void RbtnPointAway_CheckedChanged(object sender, EventArgs e)
        {
            bool ShootAway = false;
        }
    }
}
