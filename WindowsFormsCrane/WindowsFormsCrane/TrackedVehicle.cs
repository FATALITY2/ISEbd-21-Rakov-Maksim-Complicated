using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Collections.IEnumerable;

namespace WindowsFormsCrane
{
    public class TrackedVehicle : Vehicle
    {
        protected readonly int trackedVehicleWidth = 90;

        protected readonly int trackedVehicleHeight = 50;

        public TrackedVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected TrackedVehicle(int maxSpeed, float weight, Color mainColor, int trackedVehicleWidth, int trackedVehicleHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.trackedVehicleWidth = trackedVehicleWidth;
            this.trackedVehicleHeight = trackedVehicleHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            int boarderTop = 43;
            int boarderLeft = 0;
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - CraneWidth - 73)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > boarderLeft - 40)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > boarderTop)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - CraneHeightDown - 20)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            //рисую главную часть крана
            g.DrawRectangle(pen, _startPosX + 54, _startPosY + 20, 25, 40);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 30, 80, 30);
            Brush mainPart = new SolidBrush(MainColor);
            g.FillRectangle(mainPart, _startPosX + 55, _startPosY + 21, 24, 38);
            g.FillRectangle(mainPart, _startPosX + 80, _startPosY + 31, 80, 29);
            g.FillRectangle(mainPart, _startPosX + 141, _startPosY + 20, 12, 5);

            // Противовес
            {

                g.DrawRectangle(pen, _startPosX + 160, _startPosY + 20, 22, 44);
                g.DrawLine(pen, _startPosX + 140, _startPosY + 30, _startPosX + 140, _startPosY + 20);
                g.DrawLine(pen, _startPosX + 153, _startPosY + 30, _startPosX + 153, _startPosY + 20);
                g.DrawRectangle(pen, _startPosX + 140, _startPosY + 19, 13, 6);
                g.DrawRectangle(pen, _startPosX + 85, _startPosY + 60, 45, 5);
                g.DrawRectangle(pen, _startPosX + 60, _startPosY + 30, 10, 20);
                Brush counterweight = new SolidBrush(MainColor);
                g.FillRectangle(counterweight, _startPosX + 161, _startPosY + 21, 21, 43);
                g.FillRectangle(counterweight, _startPosX + 141, _startPosY + 20, 12, 5);
                g.FillRectangle(counterweight, _startPosX + 86, _startPosY + 61, 44, 4);
            }

            //гусеница
            g.DrawEllipse(pen, _startPosX + 61, _startPosY + 66, 90, 20);

            // подъемное устройство
            {
                g.DrawRectangle(pen, _startPosX + 162, _startPosY - 10, 3, 30);
                g.DrawLine(pen, _startPosX + 125, _startPosY + 30, _startPosX + 162, _startPosY - 10);
                g.DrawLine(pen, _startPosX + 126, _startPosY + 30, _startPosX + 72, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 72, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 45, _startPosY - 13);
                g.DrawLine(pen, _startPosX + 45, _startPosY - 13, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 72, _startPosY - 15, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 164, _startPosY - 10, _startPosX + 53, _startPosY - 45);
                g.DrawRectangle(pen, _startPosX + 38, _startPosY - 45, 18, 3);
                g.DrawLine(pen, _startPosX + 38, _startPosY - 45, _startPosX + 38, _startPosY + 10);
                g.DrawRectangle(pen, _startPosX + 72, _startPosY - 13, 8, 5);
                g.DrawRectangle(pen, _startPosX + 53, _startPosY - 44, 8, 5);
                g.DrawLine(pen, _startPosX + 128, _startPosY + 30, _startPosX + 53, _startPosY - 45);
                g.DrawLine(pen, _startPosX + 105, _startPosY + 30, _startPosX + 55, _startPosY - 45);
                Brush liftingDevice = new SolidBrush(MainColor);
                g.FillRectangle(liftingDevice, _startPosX + 163, _startPosY - 9, 2, 29);
                g.FillRectangle(liftingDevice, _startPosX + 72, _startPosY - 13, 8, 5);
                g.FillRectangle(liftingDevice, _startPosX + 53, _startPosY - 44, 8, 5);
            }
        }
    }
}