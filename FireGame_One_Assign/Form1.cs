using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_One_Assign
{
    public partial class Form1 : Form
    {
        int step = 0;
        int trigger = 0, newTrigger = 0;
        int countShootTrigger = 0;
        int countTrigger = 0;

        rulesClass rulesClass = new rulesClass();
        public Form1()
        {
            InitializeComponent();
            load_button.Enabled = false;
            spin_button.Enabled = false;
            shoot_btn.Enabled = false;
            shoot_away_button.Enabled = false;
            play_again_button.Enabled = false;
            //get the random no to match 
            trigger = rulesClass.genTrigger();
            newTrigger = rulesClass.genNewTrigger();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //this code is used to strt the gme and need to follow the instructions
            step++;
            MessageBox.Show("Welcome to the Game ");
            load_button.Enabled = true;
            start_btn.Enabled = false;
        }


        // load button working 

        private void load_button_Click(object sender, EventArgs e)
        {
            step++;
            
            load_button.Enabled = false;
            spin_button.Enabled = true;
            //here need to set the image for the working process 
            changing_pictures.Image= FireGame_One_Assign.Properties.Resources.load_btn;
        }

        //spin button working
        private void spin_button_Click(object sender, EventArgs e)
        {
            step++;
            spin_button.Enabled = false;
            shoot_btn.Enabled = true;
            shoot_away_button.Enabled = true;
            //here need to set the image for the working process 
            changing_pictures.Image = FireGame_One_Assign.Properties.Resources.spin_btn;
        }

        //random function working 

        private void shoot_btn_Click(object sender, EventArgs e)
        {
            
            if (countTrigger < 4)
            {
                countTrigger++;
                changing_pictures.Image = FireGame_One_Assign.Properties.Resources.shoot_image1;
                System.Media.SoundPlayer sund = new System.Media.SoundPlayer(FireGame_One_Assign.Properties.Resources.Shot);
                sund.Play();
                if (rulesClass.chkStatus(trigger, countTrigger))
                {
                    MessageBox.Show("Sorry you are died");

                    shoot_btn.Enabled = false;
                    play_again_button.Enabled = true;
                }
                else {
                    MessageBox.Show("Good Luck You are safe");
                }

            }
            else {

                shoot_btn.Enabled = false;
                play_again_button.Enabled = true;
            }
        }

        // it will play again the game 

        private void play_again_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // shoot away button working 

        private void shoot_away_button_Click(object sender, EventArgs e)
        {

            if (countShootTrigger <= 2)
            {
                countShootTrigger++;
                changing_pictures.Image = FireGame_One_Assign.Properties.Resources.shoot_image2;
                System.Media.SoundPlayer sund = new System.Media.SoundPlayer(FireGame_One_Assign.Properties.Resources.Shot);
                sund.Play();

                if (rulesClass.chkNewStatus(newTrigger,countShootTrigger))
                {
                    MessageBox.Show("Sorry you are died");
                    shoot_btn.Enabled = false;
                    shoot_away_button.Enabled = false;
                    play_again_button.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Good Luck You are safe");
                }
            }
            else {
                shoot_away_button.Enabled = false;
                play_again_button.Enabled = true;

            }
        }
    }
}
