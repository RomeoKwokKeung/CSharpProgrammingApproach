using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SongMethod
{
    public partial class FrmSongMethod : Form
    {
        public FrmSongMethod()
        {
            InitializeComponent();
        }

        private void BtnWithoutMethod_Click(object sender, EventArgs e)
        {
            TxtSong.Text += "-----------CLEMENTINE 1------------" + Environment.NewLine;
            TxtSong.Text += " " + Environment.NewLine;

            TxtSong.Text+= "In a cavern, in a canyon"+Environment.NewLine;
            TxtSong.Text+= "Excavating for a mine" +Environment.NewLine;
            TxtSong.Text+= "Lived a miner, forty-niner"+Environment.NewLine;
            TxtSong.Text+="And his daughter, Clementine"+Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            MessageBox.Show( "Oh my darling, oh my darling" + "\n" + "Oh may darling, Clementine");
            MessageBox.Show("You are lost and gone forever" + "\n" + "Dreadful sorry, Clementine");

            TxtSong.Text += "Light she was and like a fairy" + Environment.NewLine;
            TxtSong.Text += "And her shoes were number nine" + Environment.NewLine;
            TxtSong.Text += "Herring boxes without topses" + Environment.NewLine;
            TxtSong.Text += "Sandals were for Clementine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            MessageBox.Show( "Oh my darling, oh my darling" + "\n" + "Oh may darling, Clementine");
            MessageBox.Show("You are lost and gone forever" + "\n" + "Dreadful sorry, Clementine");


            TxtSong.Text += "Drove she ducklings to the water" + Environment.NewLine;
            TxtSong.Text += "Every morning just a nin" + Environment.NewLine;
            TxtSong.Text += "Hit her foot against a splinter" + Environment.NewLine;
            TxtSong.Text += "Fell into the foaming brine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            MessageBox.Show( "Oh my darling, oh my darling" + "\n" + "Oh may darling, Clementine");
            MessageBox.Show("You are lost and gone forever" + "\n" + "Dreadful sorry, Clementine");

            TxtSong.Text+= "In a cavern, in a canyon"+Environment.NewLine;
            TxtSong.Text+= "Excavating for a mine" +Environment.NewLine;
            TxtSong.Text+= "Lived a miner, forty-niner"+Environment.NewLine;
            TxtSong.Text+="And his daughter, Clementine"+Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            MessageBox.Show( "Oh my darling, oh my darling" + "\n" + "Oh may darling, Clementine");
            MessageBox.Show("You are lost and gone forever" + "\n" + "Dreadful sorry, Clementine");

            TxtSong.Text += "Light she was and like a fairy" + Environment.NewLine;
            TxtSong.Text += "And her shoes were number nine" + Environment.NewLine;
            TxtSong.Text += "Herring boxes without topses" + Environment.NewLine;
            TxtSong.Text += "Sandals were for Clementine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            MessageBox.Show( "Oh my darling, oh my darling" + "\n" + "Oh may darling, Clementine");
            MessageBox.Show("You are lost and gone forever" + "\n" + "Dreadful sorry, Clementine");


            TxtSong.Text += "Drove she ducklings to the water" + Environment.NewLine;
            TxtSong.Text += "Every morning just a nin" + Environment.NewLine;
            TxtSong.Text += "Hit her foot against a splinter" + Environment.NewLine;
            TxtSong.Text += "Fell into the foaming brine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            MessageBox.Show( "Oh my darling, oh my darling" + "\n" + "Oh may darling, Clementine");
            MessageBox.Show("You are lost and gone forever" + "\n" + "Dreadful sorry, Clementine");
        }

        private void BtnWithMethod_Click(object sender, EventArgs e)
        {

            TxtSong.Clear();

            TxtSong.Text += "-----------CLEMENTINE 1------------" + Environment.NewLine;
            TxtSong.Text += " " + Environment.NewLine;

            TxtSong.Text += "In a cavern, in a canyon" + Environment.NewLine;
            TxtSong.Text += "Excavating for a mine" + Environment.NewLine;
            TxtSong.Text += "Lived a miner, forty-niner" + Environment.NewLine;
            TxtSong.Text += "And his daughter, Clementine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            Verse();

            TxtSong.Text += "Light she was and like a fairy" + Environment.NewLine;
            TxtSong.Text += "And her shoes were number nine" + Environment.NewLine;
            TxtSong.Text += "Herring boxes without topses" + Environment.NewLine;
            TxtSong.Text += "Sandals were for Clementine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            Verse();


            TxtSong.Text += "Drove she ducklings to the water" + Environment.NewLine;
            TxtSong.Text += "Every morning just a nin" + Environment.NewLine;
            TxtSong.Text += "Hit her foot against a splinter" + Environment.NewLine;
            TxtSong.Text += "Fell into the foaming brine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            Verse();

            TxtSong.Text += "In a cavern, in a canyon" + Environment.NewLine;
            TxtSong.Text += "Excavating for a mine" + Environment.NewLine;
            TxtSong.Text += "Lived a miner, forty-niner" + Environment.NewLine;
            TxtSong.Text += "And his daughter, Clementine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            Verse();

            TxtSong.Text += "Light she was and like a fairy" + Environment.NewLine;
            TxtSong.Text += "And her shoes were number nine" + Environment.NewLine;
            TxtSong.Text += "Herring boxes without topses" + Environment.NewLine;
            TxtSong.Text += "Sandals were for Clementine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            Verse();


            TxtSong.Text += "Drove she ducklings to the water" + Environment.NewLine;
            TxtSong.Text += "Every morning just a nin" + Environment.NewLine;
            TxtSong.Text += "Hit her foot against a splinter" + Environment.NewLine;
            TxtSong.Text += "Fell into the foaming brine" + Environment.NewLine;

            TxtSong.Text += " " + Environment.NewLine;

            Verse();
        }

        private void Verse()
        {
            MessageBox.Show("Oh my darling, oh my darling" + "\n" + "Oh may darling, Clementine");
            MessageBox.Show("You are lost and gone forever" + "\n" + "Dreadful sorry, Clementine");
        }
    }
}