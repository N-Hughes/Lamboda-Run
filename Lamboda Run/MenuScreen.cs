using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lamboda_Run
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void trueButton_Click_1(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
            GameScreen.diff = 3;
            GameScreen.lives = 1;
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {

            Form1.ChangeScreen(this, new GameScreen());
            GameScreen.diff = 2;
            GameScreen.lives = 3;
        }

        private void easyButton_Click(object sender, EventArgs e)
        {

            Form1.ChangeScreen(this, new GameScreen());
            GameScreen.diff = 1;
            GameScreen.lives = 5;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
