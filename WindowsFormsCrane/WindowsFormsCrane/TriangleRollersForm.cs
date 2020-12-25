using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCrane
{
    class TriangleRollersForm : IDopElements
    {
        private EnumElements enumElements;

        public int Number { set => enumElements = (EnumElements)value; }

        public Color DopColor { private set; get; }

        public TriangleRollersForm(int rollers, Color dopColor)
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
            Brush dopc = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(_startPosX + 105, _startPosY + 81), new PointF(_startPosX + 115, _startPosY + 81),
                                           new PointF(_startPosX + 110, _startPosY + 68) };
            g.FillPolygon(dopc, cannon1Points);

            PointF[] cannon2Points = { new PointF(_startPosX + 95, _startPosY + 81), new PointF(_startPosX + 105, _startPosY + 81),
                                           new PointF(_startPosX + 100, _startPosY + 68) };
            g.FillPolygon(dopc, cannon2Points);
        }

        private void DrawFourRollers(Graphics g, float _startPosX, float _startPosY)
        {
            DrawTwoRollers(g, _startPosX, _startPosY);
            Brush dopc = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(_startPosX + 115, _startPosY + 81), new PointF(_startPosX + 125, _startPosY + 81),
                                           new PointF(_startPosX + 120, _startPosY + 68) };
            g.FillPolygon(dopc, cannon1Points);

            PointF[] cannon2Points = { new PointF(_startPosX + 85, _startPosY + 81), new PointF(_startPosX + 95, _startPosY + 81),
                                           new PointF(_startPosX + 90, _startPosY + 68) };
            g.FillPolygon(dopc, cannon2Points);
        }

        private void DrawSixRollers(Graphics g, float _startPosX, float _startPosY)
        {
            DrawFourRollers(g, _startPosX, _startPosY);
            Brush dopc = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(_startPosX + 125, _startPosY + 81), new PointF(_startPosX + 135, _startPosY + 81),
                                           new PointF(_startPosX + 130, _startPosY + 68) };
            g.FillPolygon(dopc, cannon1Points);

            PointF[] cannon2Points = { new PointF(_startPosX + 75, _startPosY + 81), new PointF(_startPosX + 85, _startPosY + 81),
                                           new PointF(_startPosX + 80, _startPosY + 68) };
            g.FillPolygon(dopc, cannon2Points);
        }
    }
}
