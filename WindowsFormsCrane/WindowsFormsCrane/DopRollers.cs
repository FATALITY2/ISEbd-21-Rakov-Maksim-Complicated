using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    class DopRollers
    {
        //закрытое поле
        private RollersEnum _quantityrollers;

        public int enumeration
        {
            set
            {
                switch (value)
                {
                    case 4:
                        _quantityrollers = RollersEnum.Four;
                        break;
                    case 5:
                        _quantityrollers = RollersEnum.Five;
                        break;
                    case 6:
                        _quantityrollers = RollersEnum.Six;
                        break;
                }
            }
        }
        
        
        //метод отрисовки объекта
        public void DrawRollers(Graphics g, Color dopColor, float x, float y)
        {
            Pen penr = new Pen(Color.Black, 1);
            Brush dopc = new SolidBrush(dopColor);

            g.FillEllipse(dopc, x + 75, y + 70, 10, 10);
            g.FillEllipse(dopc, x + 125, y + 70, 10, 10);
            g.DrawEllipse(penr, x + 75, y + 70, 10, 10);
            g.DrawEllipse(penr, x + 125, y + 70, 10, 10);

            if (_quantityrollers == RollersEnum.Four)
            {
                g.FillEllipse(dopc, x + 85, y + 65, 20, 20);
                g.FillEllipse(dopc, x + 105, y + 65, 20, 20);
                g.DrawEllipse(penr, x + 85, y + 65, 20, 20);
                g.DrawEllipse(penr, x + 105, y + 65, 20, 20);
                return;
            }

            if (_quantityrollers == RollersEnum.Five)
            {
                g.FillEllipse(dopc, x + 95, y + 65, 20, 20);
                g.DrawEllipse(penr, x + 95, y + 65, 20, 20);
            }

            if (_quantityrollers == RollersEnum.Six)
            {
                g.FillEllipse(dopc, x + 95, y + 75, 10, 10);
                g.FillEllipse(dopc, x + 105, y + 75, 10, 10);
                g.DrawEllipse(penr, x + 95, y + 75, 10, 10);
                g.DrawEllipse(penr, x + 105, y + 75, 10, 10);
            }

            g.FillEllipse(dopc, x + 85, y + 75, 10, 10);
            g.FillEllipse(dopc, x + 115, y + 75, 10, 10);
            g.DrawEllipse(penr, x + 85, y + 75, 10, 10);
            g.DrawEllipse(penr, x + 115, y + 75, 10, 10);
        }
    }
}