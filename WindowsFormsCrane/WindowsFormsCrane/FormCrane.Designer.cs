﻿namespace WindowsFormsCrane
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
            this.pictureBoxCrane = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.comboBoxkolvokatkov = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCrane
            // 
            this.pictureBoxCrane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCrane.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCrane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCrane.Name = "pictureBoxCrane";
            this.pictureBoxCrane.Size = new System.Drawing.Size(883, 453);
            this.pictureBoxCrane.TabIndex = 0;
            this.pictureBoxCrane.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(8, 7);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(108, 39);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
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
            // comboBoxkolvokatkov
            // 
            this.comboBoxkolvokatkov.FormattingEnabled = true;
            this.comboBoxkolvokatkov.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.comboBoxkolvokatkov.Location = new System.Drawing.Point(178, 22);
            this.comboBoxkolvokatkov.Name = "comboBoxkolvokatkov";
            this.comboBoxkolvokatkov.Size = new System.Drawing.Size(194, 24);
            this.comboBoxkolvokatkov.TabIndex = 6;
            this.comboBoxkolvokatkov.Text = "Количество катков";
      
            // 
            // FormCrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 453);
            this.Controls.Add(this.comboBoxkolvokatkov);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxCrane);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCrane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подъемный кран";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCrane;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.ComboBox comboBoxkolvokatkov;
    }
}

