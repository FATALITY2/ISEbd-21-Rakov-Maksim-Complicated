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
    public partial class FormParking : Form
    {
        private readonly Parking<TrackedVehicle, TrapezeRollersForm> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<TrackedVehicle, TrapezeRollersForm>(pictureBoxParking.Width,
                pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetTrackedVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var trackedVehicle = new TrackedVehicle(100, 1000, dialog.Color);
                if (parking + trackedVehicle)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не припарковано =)");
                }
            }
        }

        private void buttonSetCrane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var crane = new Crane(100, 1000, dialog.Color, dialogDop.Color);
                    if (parking + crane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Не припарковано =)");
                    }
                }
            }
        }

        private void buttonUnparking_Click(object sender, EventArgs e)
        {
            if (MaskedTextBox.Text != "")
            {
                var trackedVehicle = parking - Convert.ToInt32(MaskedTextBox.Text);
                if (trackedVehicle != null)
                {
                    FormCrane form = new FormCrane();
                    form.SetTrackedVehicle(trackedVehicle);
                    form.ShowDialog();
                }
                MaskedTextBox.Text = "";
                Draw();
            }
        }

        private void ButtonSortCrane_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < parking._places.Length - 1; ++i)
            {
                for (int j = 0; j < parking._places.Length - 1; ++j)
                {
                    if (parking < j)
                    {
                        parking.SwapTrackedVehicle(j, j + 1);
                    }
                }
            }
            Draw();
        }

        private void ButtonSortTrackedVehicle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < parking._places.Length - 1; ++i)
            {
                for (int j = 0; j < parking._places.Length - 1; ++j)
                {
                    if (parking > j)
                    {
                        parking.SwapTrackedVehicle(j, j + 1);
                    }
                }
            }
            Draw();
        }
        private void ButtonMore_Click(object sender, EventArgs e)
        {
            int ind;
            if (Compare.Text != "")
            {
                ind = Convert.ToInt32(Compare.Text);
            }
            else { return; }
            if (checkBoxMore.Checked)
            {
                if (parking > ind)
                {
                    MessageBox.Show("Парковка заполнена более, чем на " + ind + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Парковка заполнена не более, чем на " + ind + " мест(а)");
                }
            }

            else if (checkBoxLess.Checked)
            {
                if (parking < ind)
                {
                    MessageBox.Show("Парковка заполнена менее, чем на " + ind + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Парковка заполнена не менее, чем на " + ind + " мест(а)");
                }
            }
        }
    }
}

