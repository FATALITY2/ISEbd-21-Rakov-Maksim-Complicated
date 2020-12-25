using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormCrane : Form
    {
        private TrackedVehicle trackedVehicle;

        public FormCrane()
        {
            InitializeComponent();
            comboBoxRollers.Items.AddRange(new string[] { "2 Катков", "4 Катков", "6 Катков" });
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            trackedVehicle.DrawTransport(gr);
            pictureBox.Image = bmp;
        }

        private void buttonCreateTrackedVehicle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            trackedVehicle = new TrackedVehicle(rnd.Next(100, 200), rnd.Next(1000, 2000), Color.Blue,
            Color.Green, Color.Blue);
            trackedVehicle.SetPosition(rnd.Next(50, 120), rnd.Next(50, 120), pictureBox.Width,
            pictureBox.Height);
            Draw();
        }
        private void buttonCreateCrane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            trackedVehicle = new Crane(rnd.Next(100, 200), rnd.Next(1000, 2000), Color.Blue, Color.Green,
            Color.Red, (comboBoxRollers.SelectedIndex + 1) * 2, FormOfRollers());
            trackedVehicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);

            buttonSecondForm.Enabled = true;
            buttonFirstForm.Enabled = true;
            buttonThirdForm.Enabled = true;

            Draw();
        }

        private void buttonRollersForm_Click(object sender, EventArgs e)
        {
            if (sender == buttonFirstForm)
            {
                buttonSecondForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else if (sender == buttonSecondForm)
            {
                buttonFirstForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else
            {
                buttonFirstForm.Enabled = false;
                buttonSecondForm.Enabled = false;
            }
        }

        private int FormOfRollers()
        {
            if (buttonFirstForm.Enabled == true)
            {
                return 0;
            }
            else if (buttonSecondForm.Enabled == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    trackedVehicle.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    trackedVehicle.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    trackedVehicle.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    trackedVehicle.MoveTransport(Direction.Right);
                    break;
            }

            Draw();
        }
    }
}