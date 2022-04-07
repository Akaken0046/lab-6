using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_editor
{
    public class Polygon : Shape
    {
        private int count_v;
        private double angle;
        private List<Point> vertex;

        public Polygon(int x, int y, int size, Color color, int count_v, double angle) : base(x, y, size, color)
        {
            this.count_v = count_v;
            vertex = new List<Point>();
            this.angle = angle;
        }

        public override void Draw(Graphics graph)
        {
            vertex.Clear();
            double x, y;
            double beta = Math.PI / 180 * angle;
            for (double alfa = 0.0 + beta; alfa <= 2 * Math.PI + beta; alfa += 2 * Math.PI / count_v )
            {
                x = center.X + size * Math.Cos(alfa);
                y = center.Y + size * Math.Sin(alfa);
                vertex.Add(new Point((int)x, (int)y));
            }
            if (current)
            {
                graph.DrawEllipse(new Pen(Color.Red, 3), center.X - size, center.Y - size, 2 * size, 2 * size);
            }
            graph.DrawPolygon(new Pen(color, 2), vertex.ToArray());
        }

        public override void Move(int dx, int dy)
        {
            center.X += dx;
            center.Y += dy;
        }

        public override int GetCountV()
        {
            return count_v;
        }

        public override void SetCountV(int value)
        {
            count_v = value;
        }

        public override double GetAngle()
        {
            return angle;
        }

        public override void SetAngle(double value)
        {
            angle = value;
        }

        public List<Point> GetVertex()
        {
            return vertex;
        }

        public void SetVertex(List<Point> value)
        {
            vertex = value;
        }
    }
}
