using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_editor
{
    public abstract class Shape
    {
        protected Point center;
        protected int size;
        protected Color color;
        protected bool current;


        public Shape(int x, int y, int size, Color color)
        {
            center.X = x;
            center.Y = y;
            this.size = size;
            this.color = color;
            current = true;
        }

        public abstract void Draw(Graphics graph);
        public abstract void Move(int dx, int dy);
        public abstract void SetCountV(int count_v);
        public abstract int GetCountV();
        public abstract void SetAngle(double angle);
        public abstract double GetAngle();

        public Point GetCenter()
        {
            return center;
        }

        public void SetCenter(Point value)
        {
            center = value;
        }

        public int GetSize()
        {
            return size;
        }

        public void SetSize(int value)
        {
            size = value;
        }

        public Color GetColor()
        {
            return color;
        }

        public void SetColor(Color value)
        {
            color = value;
        }

        public bool GetCurrent()
        {
            return current;
        }

        public void SetCurrent(bool value)
        {
            current = value;
        }
    }
}
