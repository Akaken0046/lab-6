using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_editor
{
    public partial class Form1 : Form
    {
        Storage<Shape> storage;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            storage = new Storage<Shape>();
            rand = new Random();
        }

            
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Shape temp = IsFree(e.X, e.Y);
                if (temp == null)
                {
                    Color color = colorDialog1.Color;
                    int size = (int)numericalSize.Value;
                    int countV = (int)numeriсCountV.Value;
                    double angle = (double)numericalAngle.Value;

                    CheckArea(e.X, e.Y, ref size);
                    if (CircleButton.Checked)
                        storage.Add(new Circle(e.X, e.Y, size, color));
                    if (PolygonButton.Checked)
                        storage.Add(new Polygon(e.X, e.Y, size, color, countV, angle));
                    if (StarButton.Checked)
                    {
                        if((int)numeriсCountV.Value % 2 == 1)
                        storage.Add(new Star(e.X, e.Y, size, color, countV, angle));
                    }
                    if(storage.GetSize() > 1)
                    storage.PrevObject().SetCurrent(false);
                    ChangeProperty(storage.CurrentObject());
                    pictureBox.Refresh();
                }
                else
                {
                    storage.CurrentObject().SetCurrent(false);
                    storage.SetCurrent(temp);
                    storage.CurrentObject().SetCurrent(true);
                    ChangeProperty(storage.CurrentObject());
                    pictureBox.Refresh();
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (storage.GetSize() > 0)
                {
                    Shape del = IsFree(e.X, e.Y);
                    if (del != null)
                    {
                        if(del == storage.CurrentObject())
                        {
                            storage.NextObject().SetCurrent(true);
                        }

                        storage.RemoveByIndex(storage.FindIndex(del));
                        if (storage.GetSize() > 0)
                            ChangeProperty(storage.CurrentObject());
                        pictureBox.Refresh();
                    }
                }

            }
        }

        private void CheckArea( int x,  int y, ref int size)
        {
            int h = pictureBox.Size.Height;
            int w = pictureBox.Size.Width;

            if (x + size > w)
                size -= (x + size) - w;
                
            if (x - size < 0)
                size -= Math.Abs(x - size);

            if (y + size > h)
                size -= (y + size) - h;

            if (y - size < 0)
                size -= Math.Abs(y - size);
        }

        private bool CheckMove(int x, int y, int size)
        {
            int h = pictureBox.Size.Height;
            int w = pictureBox.Size.Width;

            if (x + size > w)
                return false;

            if (x - size < 0)
                return false;

            if (y + size > h)
                return false;

            if (y - size < 0)
                return false;

            return true;
        }

        private void ChangeProperty(Shape obj)
        {
            if (obj is Circle)
            {
                CircleButton.Checked = true;
                numericalSize.Value = storage.CurrentObject().GetSize();
                ChangeColorButton.BackColor = storage.CurrentObject().GetColor();
                colorDialog1.Color = storage.CurrentObject().GetColor();
            }
            if (obj is Polygon)
            {
                PolygonButton.Checked = true;
                numericalSize.Value = storage.CurrentObject().GetSize();
                numeriсCountV.Value = storage.CurrentObject().GetCountV();
                numericalAngle.Value = (decimal)storage.CurrentObject().GetAngle();
                ChangeColorButton.BackColor = storage.CurrentObject().GetColor();
                colorDialog1.Color = storage.CurrentObject().GetColor();
            }
            if (obj is Star)
            {
                StarButton.Checked = true;
                numericalSize.Value = storage.CurrentObject().GetSize();
                numeriсCountV.Value = storage.CurrentObject().GetCountV();
                numericalAngle.Value = (decimal)storage.CurrentObject().GetAngle();
                ChangeColorButton.BackColor = storage.CurrentObject().GetColor();
                colorDialog1.Color = storage.CurrentObject().GetColor();
            }
        }

        private Shape IsFree(int x, int y)
        {
            for (storage.First(); !storage.IsEOL(); storage.Next())
            {
                int xNull = storage.GetObject().GetCenter().X;
                int yNull = storage.GetObject().GetCenter().Y;

                double lenght = Math.Sqrt(Math.Pow(x - xNull, 2) + Math.Pow(y - yNull, 2));
                if (lenght < storage.GetObject().GetSize())
                {
                    return storage.GetObject();
                }
            }
            return null;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (storage.First(); !storage.IsEOL(); storage.Next())
            {
                storage.GetObject().Draw(g);
            }
            return;
        }

        private void ChangeColorbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                if (storage.GetSize() > 0)
                {
                    storage.CurrentObject().SetColor(colorDialog1.Color);
                }
            ChangeColorButton.BackColor = colorDialog1.Color;
            pictureBox.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (storage.GetSize() > 0)
            {
                Shape temp = storage.CurrentObject();
                if(e.KeyCode == Keys.T)
                {
                    if(temp.GetSize() < 150)
                    temp.SetSize(temp.GetSize() + 1);
                    numericalSize.Value = temp.GetSize();
                }
                if (e.KeyCode == Keys.G)
                {
                    if (temp.GetSize() > 1)
                        temp.SetSize(temp.GetSize() - 1);
                    numericalSize.Value = temp.GetSize();
                }
                if(e.KeyCode == Keys.V)
                {
                    storage.NextObject().SetCurrent(true);
                    storage.RemoveCurrent();
                    if(storage.GetSize() > 0)
                    {
                        ChangeProperty(storage.CurrentObject());
                    }
                }

                if (CircleButton.Checked == false) {
                    if (e.KeyCode == Keys.Q)
                    {
                        if (temp.GetAngle() < 360)
                            temp.SetAngle(temp.GetAngle() + 1);
                        numericalAngle.Value = (decimal)temp.GetAngle();

                    }
                    if (e.KeyCode == Keys.E)
                    {
                        if (temp.GetAngle() > 0)
                            temp.SetAngle(temp.GetAngle() - 1);
                        numericalAngle.Value = (decimal)temp.GetAngle();
                    }
                    if (e.KeyCode == Keys.R)
                    {
                        if (numeriсCountV.Value < 12)
                        {
                            if (temp is Star == true && (temp.GetCountV() + 1) % 2 != 0)
                                temp.SetCountV((temp.GetCountV() + 1));
                            if (temp is Polygon)
                                temp.SetCountV((temp.GetCountV() + 1));
                            numeriсCountV.Value++;
                        }
                    }
                    if (e.KeyCode == Keys.F)
                    {
                        if (numeriсCountV.Value > 3)
                        {
                            if (StarButton.Checked == true && (temp.GetCountV() - 1) % 2 != 0)
                                temp.SetCountV((temp.GetCountV() - 1));
                            if (PolygonButton.Checked == true)
                                temp.SetCountV((temp.GetCountV() - 1));
                            numeriсCountV.Value--;
                        }
                    }
                }
                ObjectMove(temp, e);
                pictureBox.Refresh();
            }
            CreateObject(storage.CurrentObject(), e);
            pictureBox.Refresh();
        }

        private void ObjectMove(Shape temp, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                if (CheckMove(temp.GetCenter().X, temp.GetCenter().Y - 5, temp.GetSize()))
                    temp.Move(0, -5);
            }
            if (e.KeyCode == Keys.D)
            {
                if (CheckMove(temp.GetCenter().X + 5, temp.GetCenter().Y, temp.GetSize()))
                    temp.Move(5, 0);
            }
            if (e.KeyCode == Keys.S)
            {
                if (CheckMove(temp.GetCenter().X, temp.GetCenter().Y + 5, temp.GetSize()))
                    temp.Move(0, 5);
            }
            if (e.KeyCode == Keys.A)
            {
                if (CheckMove(temp.GetCenter().X - 5, temp.GetCenter().Y, temp.GetSize()))
                    temp.Move(-5, 0);
            }
        }

        private void CreateObject(Shape temp, KeyEventArgs e)
        {
            int x = rand.Next(10, pictureBox.Size.Width);
            int y = rand.Next(10, pictureBox.Size.Height);
            int size = rand.Next(1, 150);
            Color color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            int countV = rand.Next(3, 12);
            double angle = rand.Next(0, 360);

            CheckArea(x, y, ref size);

            if (e.KeyCode == Keys.Z)
            {
                storage.Add(new Circle(x, y, size, color));
                CircleButton.Checked = true;
                numericalSize.Value = storage.CurrentObject().GetSize();
                ChangeColorButton.BackColor = color;
                colorDialog1.Color = color;
            }
            if (e.KeyCode == Keys.X)
            {
                storage.Add(new Polygon(x, y, size, color, countV, angle));
                PolygonButton.Checked = true;
                numericalSize.Value = storage.CurrentObject().GetSize();
                numeriсCountV.Value = storage.CurrentObject().GetCountV();
                numericalAngle.Value = (decimal)storage.CurrentObject().GetAngle();
                ChangeColorButton.BackColor = color;
                colorDialog1.Color = color;
            }
            if (e.KeyCode == Keys.C)
            {
                while (countV % 2 == 0)
                    countV = rand.Next(3, 12);
                storage.Add(new Star(x, y, size, color, countV, angle));
                StarButton.Checked = true;
                numericalSize.Value = storage.CurrentObject().GetSize();
                numeriсCountV.Value = storage.CurrentObject().GetCountV();
                numericalAngle.Value = (decimal)storage.CurrentObject().GetAngle();
                ChangeColorButton.BackColor = color;
                colorDialog1.Color = color;
            }

            if(e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C)
            if (storage.GetSize() > 1)
                storage.PrevObject().SetCurrent(false);
        }

        private void NumericCountV_ValueChanged(object sender, EventArgs e)
        {
            if (PolygonButton.Checked && storage.GetSize() > 0)
                storage.CurrentObject().SetCountV((int)numeriсCountV.Value);
            if (StarButton.Checked == true && storage.GetSize() > 0 && (int)numeriсCountV.Value % 2 != 0)
                storage.CurrentObject().SetCountV((int)numeriсCountV.Value);
            pictureBox.Refresh();
        }

        private void NumericalSize_ValueChanged(object sender, EventArgs e)
        {
            if (storage.GetSize() > 0)
                if (CheckMove(storage.CurrentObject().GetCenter().X, storage.CurrentObject().GetCenter().Y, (int)numericalSize.Value))
                {
                    storage.CurrentObject().SetSize((int)numericalSize.Value);
                    pictureBox.Refresh();
                }
                else
                    numericalSize.Value--;
        }

        private void NumericalAngle_ValueChanged(object sender, EventArgs e)
        {
            if(storage.GetSize() > 0)
            {
                storage.CurrentObject().SetAngle((double)numericalAngle.Value);
                pictureBox.Refresh();
            }
        }

        private void CircleButton_CheckedChanged(object sender, EventArgs e)
        {
            CircleButton.AutoCheck = true;
            if (CircleButton.Checked == true)
            {
                label2.Visible = false;
                numeriсCountV.Visible = false;
                label4.Visible = false;
                numericalAngle.Visible = false;
            }
        }

        private void PolygonButton_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            numeriсCountV.Visible = true;
            label4.Visible = true;
            numericalAngle.Visible = true;
        }

        private void StarButton_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            numeriсCountV.Visible = true;
            label4.Visible = true;
            numericalAngle.Visible = true;
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            CircleButton.AutoCheck = true;
        }

    }
}