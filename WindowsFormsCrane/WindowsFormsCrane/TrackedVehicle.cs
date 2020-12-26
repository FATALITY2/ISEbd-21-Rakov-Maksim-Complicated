using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCrane
{
    public class Crane : TrackedVehicle
    {
        private IDopElements roller;

        public Crane(int maxSpeed, float weight, Color mainColor, Color dopColor, Color rollersColor, int rollers, int rollersForm) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;

            if (rollersForm == 0)
            {
                roller = new TrapezeRollersForm(rollers, rollersColor);
            }
            else if (rollersForm == 1)
            {
                roller = new TriangleRollersForm(rollers, rollersColor);
            }
            else if (rollersForm == 2)
            {
                roller = new RectangleRollersForm(rollers, rollersColor);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            roller.DrawElements(g, _startPosX, _startPosY);
        }
    }
}
