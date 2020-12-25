namespace WindowsFormsCrane
{
    partial class FormCrane
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonCreateTrackedVehicle = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.comboBoxRollers = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonThirdForm = new System.Windows.Forms.Button();
            this.buttonFirstForm = new System.Windows.Forms.Button();
            this.buttonSecondForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateCrane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(883, 453);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonCreateTrackedVehicle
            // 
            this.buttonCreateTrackedVehicle.Location = new System.Drawing.Point(6, 20);
            this.buttonCreateTrackedVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateTrackedVehicle.Name = "buttonCreateTrackedVehicle";
            this.buttonCreateTrackedVehicle.Size = new System.Drawing.Size(91, 39);
            this.buttonCreateTrackedVehicle.TabIndex = 1;
            this.buttonCreateTrackedVehicle.Text = "Гус.машина";
            this.buttonCreateTrackedVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateTrackedVehicle.Click += new System.EventHandler(this.buttonCreateTrackedVehicle_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUp.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.Up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(789, 340);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(29, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDown.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.Down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(789, 364);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(29, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRight.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.Right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(817, 364);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(29, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLeft.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.Left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(763, 364);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(29, 30);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // comboBoxRollers
            // 
            this.comboBoxRollers.FormattingEnabled = true;
            this.comboBoxRollers.Location = new System.Drawing.Point(131, 64);
            this.comboBoxRollers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRollers.Name = "comboBoxRollers";
            this.comboBoxRollers.Size = new System.Drawing.Size(82, 24);
            this.comboBoxRollers.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonThirdForm);
            this.groupBox1.Controls.Add(this.buttonFirstForm);
            this.groupBox1.Controls.Add(this.buttonSecondForm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCreateCrane);
            this.groupBox1.Controls.Add(this.comboBoxRollers);
            this.groupBox1.Controls.Add(this.buttonCreateTrackedVehicle);
            this.groupBox1.Location = new System.Drawing.Point(623, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать";
            // 
            // buttonThirdForm
            // 
            this.buttonThirdForm.Location = new System.Drawing.Point(206, 97);
            this.buttonThirdForm.Name = "buttonThirdForm";
            this.buttonThirdForm.Size = new System.Drawing.Size(48, 37);
            this.buttonThirdForm.TabIndex = 9;
            this.buttonThirdForm.Text = "3НФ";
            this.buttonThirdForm.UseVisualStyleBackColor = true;
            this.buttonThirdForm.Click += new System.EventHandler(this.buttonRollersForm_Click);
            // 
            // buttonFirstForm
            // 
            this.buttonFirstForm.Location = new System.Drawing.Point(103, 94);
            this.buttonFirstForm.Name = "buttonFirstForm";
            this.buttonFirstForm.Size = new System.Drawing.Size(50, 40);
            this.buttonFirstForm.TabIndex = 9;
            this.buttonFirstForm.Text = "1нф";
            this.buttonFirstForm.UseVisualStyleBackColor = true;
            this.buttonFirstForm.Click += new System.EventHandler(this.buttonRollersForm_Click);
            // 
            // buttonSecondForm
            // 
            this.buttonSecondForm.Location = new System.Drawing.Point(153, 94);
            this.buttonSecondForm.Name = "buttonSecondForm";
            this.buttonSecondForm.Size = new System.Drawing.Size(47, 40);
            this.buttonSecondForm.TabIndex = 8;
            this.buttonSecondForm.Text = "2НФ";
            this.buttonSecondForm.UseVisualStyleBackColor = true;
            this.buttonSecondForm.Click += new System.EventHandler(this.buttonRollersForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Форма катков";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество катков";
            // 
            // buttonCreateCrane
            // 
            this.buttonCreateCrane.Location = new System.Drawing.Point(103, 20);
            this.buttonCreateCrane.Name = "buttonCreateCrane";
            this.buttonCreateCrane.Size = new System.Drawing.Size(116, 38);
            this.buttonCreateCrane.TabIndex = 2;
            this.buttonCreateCrane.Text = "Кран";
            this.buttonCreateCrane.UseVisualStyleBackColor = true;
            this.buttonCreateCrane.Click += new System.EventHandler(this.buttonCreateCrane_Click);
            // 
            // FormCrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCrane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подъемный кран";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonCreateTrackedVehicle;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.ComboBox comboBoxRollers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreateCrane;
        private System.Windows.Forms.Button buttonThirdForm;
        private System.Windows.Forms.Button buttonFirstForm;
        private System.Windows.Forms.Button buttonSecondForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

