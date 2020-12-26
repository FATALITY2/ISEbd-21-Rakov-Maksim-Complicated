using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCrane
{
    public class Parking<T, U> where T : class, ITransport where U : class, IDopElements
    {
        public readonly T[] _places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 280;

        private readonly int _placeSizeHeight = 150;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Parking<T, U> p, T trackedVehicle)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    trackedVehicle.SetPosition(10 + p._placeSizeWidth * (int)(i / (int)(p.pictureHeight / p._placeSizeHeight)),
                        50 + p._placeSizeHeight * (int)(i % (int)(p.pictureHeight / p._placeSizeHeight)), p.pictureWidth, p.pictureHeight);
                    p._places[i] = trackedVehicle;
                    return true;
                }
            }
            return false;
        }


        public static bool operator >(Parking<T, U> p, int ind)
        {
            return p.CompareHelper() > ind;
        }

        public static bool operator <(Parking<T, U> p, int ind)
        {
            return p.CompareHelper() < ind;
        }

        private int CompareHelper()
        {
            int cnt = 0;
            for (int i = 0; i < _places.Length; ++i)
            {
                if (_places[i] != null)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public static T operator -(Parking<T, U> p, int index)
        {
            if ((index < p._places.Length) && (index >= 0))
            {
                T trackedVehicle = p._places[index];
                p._places[index] = null;
                return trackedVehicle;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        public void SwapTrackedVehicle(int ind1, int ind2)
        {
            if (ind1 >= 0 && ind1 < _places.Length && ind2 >= 0 && ind2 < _places.Length)
            {
                var t = _places[ind1];
                _places[ind1] = _places[ind2];
                _places[ind2] = t;
                _places[ind1].SetPosition(10 + _placeSizeWidth * (int)(ind1 / (int)(pictureHeight / _placeSizeHeight)),
                         _placeSizeHeight * (int)(ind1 % (int)(pictureHeight / _placeSizeHeight)), pictureWidth, pictureHeight);
                _places[ind2].SetPosition(_placeSizeWidth * (int)(ind2 / (int)(pictureHeight / _placeSizeHeight)),
                         50 + _placeSizeHeight * (int)(ind2 % (int)(pictureHeight / _placeSizeHeight)), pictureWidth, pictureHeight);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth + 5, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2 + 70, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth + 5, 0, i * _placeSizeWidth + 5, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}