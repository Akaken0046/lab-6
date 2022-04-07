using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_editor
{
    public class Circle : Shape
    {

        public Circle(int x, int y, int size, Color color) : base(x, y, size, color)
        {
            
        }

        public override void Draw(Graphics graph)
        {
            int x = center.X - size;
            int y = center.Y - size;
            int diam = size * 2;
            if (current)
                graph.DrawRectangle(new Pen(Color.Red, 3), x, y, diam, diam);

            graph.DrawEllipse(new Pen(color, 2), x, y, diam, diam);
        }

        public override void Move(int dx, int dy)
        {
            center.X += dx;
            center.Y += dy;
        }

        public override void SetCountV(int count_v)
        {

        }

        public override int GetCountV()
        {
            return 0;
        }

        public override void SetAngle(double angle)
        {

        }

        public override double GetAngle()
        {
            return 0;
        }

    }
}
