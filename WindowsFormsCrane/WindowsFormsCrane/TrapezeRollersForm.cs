using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCrane
{
    class TrapezeRollersForm : IDopElements
    {
        private EnumElements enumElements;

        public int Number { set => enumElements = (EnumElements)value; }

        public Color DopColor { private set; get; }

        public TrapezeRollersForm(int rollers, Color dopColor)
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
            Brush brDopColor = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(_startPosX + 105, _startPosY + 81), new PointF(_startPosX + 110, _startPosY + 68),
                                           new PointF(_startPosX + 115, _startPosY + 68), new PointF(_startPosX + 120, _startPosY + 81) };
            g.FillPolygon(brDopColor, cannon1Points);

            PointF[] cannon2Points = { new PointF(_startPosX + 90, _startPosY + 81), new PointF(_startPosX + 95, _startPosY + 68),
                                           new PointF(_startPosX + 100, _startPosY + 68), new PointF(_startPosX + 105, _startPosY + 81) };
            g.FillPolygon(brDopColor, cannon2Points);
        }

        private void DrawFourRollers(Graphics g, float _startPosX, float _startPosY)
        {
            DrawTwoRollers(g, _startPosX, _startPosY);
            Brush brDopColor = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(_startPosX + 120, _startPosY + 81), new PointF(_startPosX + 125, _startPosY + 68),
                                           new PointF(_startPosX + 130, _startPosY + 68), new PointF(_startPosX + 135, _startPosY + 81) };
            g.FillPolygon(brDopColor, cannon1Points);

            PointF[] cannon2Points = { new PointF(_startPosX + 75, _startPosY + 81), new PointF(_startPosX + 80, _startPosY + 68),
                                           new PointF(_startPosX + 85, _startPosY + 68), new PointF(_startPosX + 90, _startPosY + 81) };
            g.FillPolygon(brDopColor, cannon2Points);
        }

        private void DrawSixRollers(Graphics g, float _startPosX, float _startPosY)
        {
            DrawFourRollers(g, _startPosX, _startPosY);
            Brush brDopColor = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(_startPosX + 135, _startPosY + 81), new PointF(_startPosX + 138, _startPosY + 68),
                                           new PointF(_startPosX + 142, _startPosY + 68), new PointF(_startPosX + 145, _startPosY + 81) };
            g.FillPolygon(brDopColor, cannon1Points);

            PointF[] cannon2Points = { new PointF(_startPosX + 65, _startPosY + 81), new PointF(_startPosX + 68, _startPosY + 68),
                                           new PointF(_startPosX + 72, _startPosY + 68), new PointF(_startPosX + 75, _startPosY + 81) };
            g.FillPolygon(brDopColor, cannon2Points);
        }
    }
}

