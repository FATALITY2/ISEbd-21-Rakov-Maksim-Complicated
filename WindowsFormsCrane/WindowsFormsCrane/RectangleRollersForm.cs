using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCrane
{
    class RectangleRollersForm : IDopElements
    {
        private EnumElements enumElements;

        public int Number { set => enumElements = (EnumElements)value; }

        public Color DopColor { private set; get; }

        public RectangleRollersForm(int rollers, Color dopColor)
        {
            Number = rollers;
            DopColor = dopColor;
        }

        public void DrawElements(Graphics g, float _startPosX, float _startPosY)
        {
            switch (enumElements)
            {
                case EnumElements.Two:
                    DrawTwoRollers(g, _startPosX, _startPosY);
                    break;

                case EnumElements.Four:
                    DrawFourRollers(g, _startPosX, _startPosY);
                    break;

                case EnumElements.Six:
                    DrawSixRollers(g, _startPosX, _startPosY);
                    break;
            }
        }

        private void DrawTwoRollers(Graphics g, float _startPosX, float _startPosY)
        {
            Pen penr = new Pen(Color.Black, 1);
            Brush dopc = new SolidBrush(DopColor);
            g.FillRectangle(dopc, _startPosX + 88, _startPosY + 67, 15, 15);
            g.FillRectangle(dopc, _startPosX + 105, _startPosY + 67, 15, 15);
            g.DrawRectangle(penr, _startPosX + 88, _startPosY + 67, 15, 15);
            g.DrawRectangle(penr, _startPosX + 105, _startPosY + 67, 15, 15);
        }

        private void DrawFourRollers(Graphics g, float _startPosX, float _startPosY)
        {
            Pen penr = new Pen(Color.Black, 1);
            Brush dopc = new SolidBrush(DopColor);

            g.FillRectangle(dopc, _startPosX + 77, _startPosY + 70, 10, 10);
            g.FillRectangle(dopc, _startPosX + 121, _startPosY + 70, 10, 10);
            g.DrawRectangle(penr, _startPosX + 77, _startPosY + 70, 10, 10);
            g.DrawRectangle(penr, _startPosX + 121, _startPosY + 70, 10, 10);
            g.FillRectangle(dopc, _startPosX + 88, _startPosY + 67, 15, 15);
            g.FillRectangle(dopc, _startPosX + 105, _startPosY + 67, 15, 15);
            g.DrawRectangle(penr, _startPosX + 88, _startPosY + 67, 15, 15);
            g.DrawRectangle(penr, _startPosX + 105, _startPosY + 67, 15, 15);
        }

        private void DrawSixRollers(Graphics g, float _startPosX, float _startPosY)
        {
            Pen penr = new Pen(Color.Black, 1);
            Brush dopc = new SolidBrush(DopColor);
            g.FillRectangle(dopc, _startPosX + 75, _startPosY + 70, 10, 10);
            g.FillRectangle(dopc, _startPosX + 125, _startPosY + 70, 10, 10);
            g.DrawRectangle(penr, _startPosX + 75, _startPosY + 70, 10, 10);
            g.DrawRectangle(penr, _startPosX + 125, _startPosY + 70, 10, 10);
            g.FillRectangle(dopc, _startPosX + 95, _startPosY + 72, 10, 10);
            g.FillRectangle(dopc, _startPosX + 105, _startPosY + 72, 10, 10);
            g.DrawRectangle(penr, _startPosX + 95, _startPosY + 72, 10, 10);
            g.DrawRectangle(penr, _startPosX + 105, _startPosY + 72, 10, 10);
            g.FillRectangle(dopc, _startPosX + 85, _startPosY + 72, 10, 10);
            g.FillRectangle(dopc, _startPosX + 115, _startPosY + 72, 10, 10);
            g.DrawRectangle(penr, _startPosX + 85, _startPosY + 72, 10, 10);
            g.DrawRectangle(penr, _startPosX + 115, _startPosY + 72, 10, 10);
        }
    }
}
