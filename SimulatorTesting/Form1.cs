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

namespace SimulatorTesting
{
   
    public partial class Form1 : Form
    {
        private Image Roomba = Image.FromFile("roomba.png");
        private List<Rectangle> rectangles = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();


            pictureBox1.Height = Roomba.Height;
            pictureBox1.Width = Roomba.Width;
            pictureBox1.Image = Roomba;
            
                                    
                                    
        }

        //Need obstacle management
        private void GridCleaning()
        {
            while(pictureBox1.Location.Y < this.Height - 146 && pictureBox1.Location.X < this.Width - 119 - pictureBox1.Width)
            {
                while (pictureBox1.Location.Y < this.Height - 146)
                {
                    MoveDown(25);
                    Thread.Sleep(100);
                }
                
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                pictureBox1.Refresh();
                MoveRight(pictureBox1.Width);
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                pictureBox1.Refresh();
                while (pictureBox1.Location.Y > 25)
                {
                    MoveUp(25);
                    Thread.Sleep(100);
                }
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                pictureBox1.Refresh();
                MoveRight(pictureBox1.Width);
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                pictureBox1.Refresh();

            }
            
            MessageBox.Show("Done!");
        }        
        
        private void CreateObstacles(int amount)
        {
            amount = amount + rectangles.Count;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            while (rectangles.Count != amount)
            {
                int X = RandomClass.GetRandom(0, this.Width - 119);
                int Y = RandomClass.GetRandom(0, this.Height - 146);
                Rectangle rectangle = new Rectangle
                {
                    Height = 25,
                    Width = 25,
                    Location = new Point(X, Y)
                };

                if (!(pictureBox1.Bounds.IntersectsWith(rectangle)))
                {
                    rectangles.Add(rectangle);
                    //rectangles.Add(rectangle);
                    formGraphics.DrawRectangle(myPen, rectangle);
                    formGraphics.FillRectangle(myBrush, rectangle);
                }               

            }
            myBrush.Dispose();
            formGraphics.Dispose();

            

        }
        //All fucked yo with obsta
        private void Form1_KeyDown(object sender, KeyPressEventArgs e)
        {
            label1.Text = e.KeyChar.ToString();
        }

        private bool CollisionDetector()
        {
            bool NoCollisionDetected = false;
            foreach (var rectangle in rectangles)
            {
                if (pictureBox1.Bounds.IntersectsWith(rectangle))
                {
                    NoCollisionDetected = true;
                    return NoCollisionDetected;
                }
            }
            return NoCollisionDetected;
        }

        private void MoveDown(int pixels)
        {           
            
            if (pictureBox1.Location.Y < this.Height - 146 && !CollisionDetector())
            {
                label1.Text = String.Format("X: {0} Y: {1}", pictureBox1.Location.X.ToString(), pictureBox1.Location.Y.ToString());
                pictureBox1.Top = pictureBox1.Top + pixels;
            }
            else
            {
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 2);
                //CollisionDetected = true;
                int moveCount = 0;
                while (CollisionDetector())
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                    moveCount++;
                }
                MoveDown(pictureBox1.Height + 25);
                MoveLeft(moveCount);
               


            }

        }

        private void MoveUp(int pixels)
        {
            
            if (pictureBox1.Location.Y > 10 && !CollisionDetector())
            {
                label1.Text = String.Format("X: {0} Y: {1}", pictureBox1.Location.X.ToString(), pictureBox1.Location.Y.ToString());
                pictureBox1.Top = pictureBox1.Top - pixels;
            }
            else
            {
                int moveCount = 0;
                while (CollisionDetector())
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                    moveCount++;
                }
                MoveUp(pictureBox1.Height + 25);
                MoveLeft(moveCount);
            }

        }
        private void MoveRight(int pixels)
        {
            
            if (pictureBox1.Location.X < this.Width - 119 && !CollisionDetector())
            {
                label1.Text = String.Format("X: {0} Y: {1}", pictureBox1.Location.X.ToString(), pictureBox1.Location.Y.ToString());
                pictureBox1.Left = pictureBox1.Left + pixels;
            }
            else
            {
                int moveCount = 0;
                while (CollisionDetector())
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                    moveCount++;
                }
                MoveRight(pictureBox1.Height + 25);
                MoveUp(moveCount);
            }

        }
        private void MoveLeft(int pixels)
        {
             
            if (pictureBox1.Location.X > 10 && !CollisionDetector())
            {
                label1.Text = String.Format("X: {0} Y: {1}", pictureBox1.Location.X.ToString(), pictureBox1.Location.Y.ToString());
                pictureBox1.Left = pictureBox1.Left - pixels;
            }
            else
            {
                int moveCount = 0;
                while (CollisionDetector())
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                    moveCount++;
                }
                MoveLeft(pictureBox1.Height + 25);
                MoveUp(moveCount);
            }
        }
        private void KeepMovingDown()
        {
            int count = 0;
            while (true)
            {
                if (count > 10) break;
                
                MoveDown(5);
                count++;
            }
        }
        private void KeepMovingUp()
        {
            int count = 0;
            while (true)
            {
                if (count > 10) break;

                MoveUp(5);
                count++;
            }
        }
        private void KeepMovingRight()
        {
            int count = 0;
            while (true)
            {
                if (count > 10) break;

                MoveRight(5);
                count++;
            }
        }
        private void KeepMovingLeft()
        {
            int count = 0;
            while (true)
            {
                if (count > 10) break;

                MoveLeft(5);
                count++;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateObstacles(10);
        }       

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {          

            var Char = e.KeyChar.ToString();

            switch(Char)
            {
                case "w":
                    MoveUp(5);
                    break;
                case "s":
                    MoveDown(5);
                    break;
                case "d":
                    MoveRight(5);
                    break;
                case "a":
                    MoveLeft(5);
                    break;
                case "t":
                    KeepMovingUp();
                    break;
                case "g":
                    KeepMovingDown();
                    break;
                case "h":
                    KeepMovingRight();
                    break;
                case "f":
                    KeepMovingLeft();
                    break;
                default:
                    break;
            }


        }

        private void ObstacleButton_Click(object sender, EventArgs e)
        {
            CreateObstacles(10);
        }

        private void GridCleanButton_Click(object sender, EventArgs e)
        {
            GridCleaning();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12, 37);
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            pictureBox1.Refresh();
        }
    }
    public class RandomClass
    {
        static Random random = new Random();


        public static int GetRandom(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
