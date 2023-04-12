using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lamboda_Run
{
    public partial class GameScreen : UserControl
    {
        //Global Variables 
        Player hero;
        Boolean leftArrowDown, rightArrowDown, downArrowDown, upArrowDown;
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        Random randGen = new Random();

        Cars carObject;
        List<Cars> cars = new List<Cars>();

        int score = 0;
        public static int lives;
        public static int diff;

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
            gameEngine.Start();
        }

        public void InitializeGame()
        {
            //int x = (334);
            //int y = (10);
            //carObject = new Cars(x, y, 5, 5);
            hero = new Player(334, 504);

            if (randGen.Next(1, 11) == 1)
            {
                NewCar();
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            score++;

            if (hero.x == 230)
            {
                leftArrowDown = false;
            }

            if (hero.x == 438)
            {
                rightArrowDown = false;
            }


            if (upArrowDown && hero.y > 161)
            {
                hero.Move("up");
            }
            if (downArrowDown && hero.y < 640 - hero.height)
            {
                hero.Move("down");
            }

            if (leftArrowDown && hero.x > 0)
            {
                hero.Move("left");
            }
            if (rightArrowDown && hero.x < this.Width - hero.width)
            {
                hero.Move("right");
            }

            foreach (Cars car in cars)
            {
                car.Move();
            }

            if (diff == 1)
            {
                if (randGen.Next(1, 61) == 1)
                {
                    NewCar();
                }
            }
            if (diff == 2)
            {
                if (randGen.Next(1, 41) == 1)
                {
                    NewCar();
                }
            }
            else
            {
                if (randGen.Next(1, 21) == 1)
                {
                    NewCar();
                }
            }

            scoreOutput.Text = $"Score: {score}";
            livesOutput.Text = $"Lives: {lives}"; 

            if (lives == 0)
            {
                gameEngine.Stop();
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(blueBrush, carObject.x, carObject.y, carObject.size, carObject.size);

            e.Graphics.FillRectangle(whiteBrush, hero.x, hero.y, hero.width, hero.height);

            foreach (Cars car in cars)
            {
                e.Graphics.FillRectangle(blueBrush, car.x, car.y, car.size, car.size);

            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        public void NewCar()
        {
            int randomValue = randGen.Next(1, 4);

            if (randomValue == 1)
            {
                int x = (230);
                int y = (10);
                Cars newCar = new Cars(x, y, 5, 5);
                cars.Add(newCar);
            }
            else if (randomValue == 2)
            {
                int x = (334);
                int y = (10);
                Cars newCar = new Cars(x, y, 5, 5);
                cars.Add(newCar);

            }
            else
            {
                int x = (438);
                int y = (10);
                Cars newCar = new Cars(x, y, 5, 5);
                cars.Add(newCar);

            }
        }
    }
}
