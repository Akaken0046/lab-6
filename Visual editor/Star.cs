using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_editor
{
    public class Star : Shape
    {
        private int count_v;
        private double angle;
        private PointF[] vertex;


        public Star(int x, int y, int size, Color color, int n, double angle) : base(x, y, size, color)
        {
            this.count_v = n;
            this.angle = angle;
        }

        public override void Draw(Graphics graph)
        {
            vertex = new PointF[count_v];
            int pass = 1;
            for (int i = 3; i < count_v; i += 2)
                pass++;
            int num = 0;
            double beta = Math.PI / 180 * angle;
            double alfa = 0.0 + beta; 
            do
            {
                vertex[num].X = (float)(center.X + size * Math.Cos(alfa));
                vertex[num].Y = (float)(center.Y + size * Math.Sin(alfa));

                alfa += 2 * pass * (Math.PI / count_v);
                num++;
            } while ((int)alfa != (int)(2 * pass * Math.PI + beta));
            if (current)
            {
                graph.DrawEllipse(new Pen(Color.Red, 3), center.X - size, center.Y - size, 2 * size, 2 * size);
            }
            graph.DrawPolygon(new Pen(color, 2), vertex);
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

        public PointF[] GetVertex()
        {
            return vertex;
        }

        public void SetVertex(PointF[] value)
        {
            vertex = value;
        }
    }
}