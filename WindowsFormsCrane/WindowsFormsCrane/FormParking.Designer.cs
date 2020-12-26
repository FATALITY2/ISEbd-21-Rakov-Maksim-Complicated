
namespace WindowsFormsCrane
{
    partial class FormParking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonCreateTrackedVehicle = new System.Windows.Forms.Button();
            this.buttonCreateVehicle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonUnparking = new System.Windows.Forms.Button();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.checkBoxLess = new System.Windows.Forms.CheckBox();
            this.Compare = new System.Windows.Forms.MaskedTextBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(929, 482);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonCreateTrackedVehicle
            // 
            this.buttonCreateTrackedVehicle.Location = new System.Drawing.Point(788, 26);
            this.buttonCreateTrackedVehicle.Name = "buttonCreateTrackedVehicle";
            this.buttonCreateTrackedVehicle.Size = new System.Drawing.Size(142, 49);
            this.buttonCreateTrackedVehicle.TabIndex = 1;
            this.buttonCreateTrackedVehicle.Text = "Гус.машина";
            this.buttonCreateTrackedVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateTrackedVehicle.Click += new System.EventHandler(this.buttonSetTrackedVehicle_Click);
            // 
            // buttonCreateVehicle
            // 
            this.buttonCreateVehicle.Location = new System.Drawing.Point(788, 81);
            this.buttonCreateVehicle.Name = "buttonCreateVehicle";
            this.buttonCreateVehicle.Size = new System.Drawing.Size(142, 44);
            this.buttonCreateVehicle.TabIndex = 2;
            this.buttonCreateVehicle.Text = "Кран";
            this.buttonCreateVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateVehicle.Click += new System.EventHandler(this.buttonSetCrane_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonUnparking);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MaskedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(730, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Припарковать кран";
            // 
            // MaskedTextBox
            // 
            this.MaskedTextBox.Location = new System.Drawing.Point(94, 53);
            this.MaskedTextBox.Name = "MaskedTextBox";
            this.MaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaskedTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место";
            // 
            // ButtonUnparking
            // 
            this.ButtonUnparking.Location = new System.Drawing.Point(21, 105);
            this.ButtonUnparking.Name = "ButtonUnparking";
            this.ButtonUnparking.Size = new System.Drawing.Size(159, 36);
            this.ButtonUnparking.TabIndex = 2;
            this.ButtonUnparking.Text = "Удалить";
            this.ButtonUnparking.UseVisualStyleBackColor = true;
            this.ButtonUnparking.Click += new System.EventHandler(this.buttonUnparking_Click);
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(788, 322);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(81, 21);
            this.checkBoxMore.TabIndex = 4;
            this.checkBoxMore.Text = "Больше";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // checkBoxLess
            // 
            this.checkBoxLess.AutoSize = true;
            this.checkBoxLess.Location = new System.Drawing.Point(788, 350);
            this.checkBoxLess.Name = "checkBoxLess";
            this.checkBoxLess.Size = new System.Drawing.Size(83, 21);
            this.checkBoxLess.TabIndex = 5;
            this.checkBoxLess.Text = "Меньше";
            this.checkBoxLess.UseVisualStyleBackColor = true;
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(788, 378);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(100, 22);
            this.Compare.TabIndex = 6;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(788, 418);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(122, 35);
            this.buttonCompare.TabIndex = 7;
            this.buttonCompare.Text = "Сортировать";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonMore_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 507);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.checkBoxLess);
            this.Controls.Add(this.checkBoxMore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreateVehicle);
            this.Controls.Add(this.buttonCreateTrackedVehicle);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonCreateTrackedVehicle;
        private System.Windows.Forms.Button buttonCreateVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonUnparking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskedTextBox;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.CheckBox checkBoxLess;
        private System.Windows.Forms.MaskedTextBox Compare;
        private System.Windows.Forms.Button buttonCompare;
    }
}