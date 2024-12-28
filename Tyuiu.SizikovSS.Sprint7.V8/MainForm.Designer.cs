namespace Tyuiu.SizikovSS.Sprint7.V8
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox_Background_SSS = new PictureBox();
            button_Info_SSS = new Button();
            button_CheckTO_SSS = new Button();
            button_AddCar_SSS = new Button();
            button_DelCar_SSS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Background_SSS).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Background_SSS
            // 
            pictureBox_Background_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_Background_SSS.Image = (Image)resources.GetObject("pictureBox_Background_SSS.Image");
            pictureBox_Background_SSS.Location = new Point(2, 1);
            pictureBox_Background_SSS.Name = "pictureBox_Background_SSS";
            pictureBox_Background_SSS.Size = new Size(652, 480);
            pictureBox_Background_SSS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Background_SSS.TabIndex = 0;
            pictureBox_Background_SSS.TabStop = false;
            // 
            // button_Info_SSS
            // 
            button_Info_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Info_SSS.BackColor = Color.Silver;
            button_Info_SSS.BackgroundImage = (Image)resources.GetObject("button_Info_SSS.BackgroundImage");
            button_Info_SSS.BackgroundImageLayout = ImageLayout.Stretch;
            button_Info_SSS.Location = new Point(565, 1);
            button_Info_SSS.Name = "button_Info_SSS";
            button_Info_SSS.Size = new Size(89, 86);
            button_Info_SSS.TabIndex = 1;
            button_Info_SSS.TextAlign = ContentAlignment.MiddleLeft;
            button_Info_SSS.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_Info_SSS.UseVisualStyleBackColor = false;
            button_Info_SSS.Click += button_Info_SSS_Click;
            // 
            // button_CheckTO_SSS
            // 
            button_CheckTO_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_CheckTO_SSS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_CheckTO_SSS.Location = new Point(12, 106);
            button_CheckTO_SSS.Name = "button_CheckTO_SSS";
            button_CheckTO_SSS.RightToLeft = RightToLeft.No;
            button_CheckTO_SSS.Size = new Size(228, 51);
            button_CheckTO_SSS.TabIndex = 2;
            button_CheckTO_SSS.Text = "Узнать дату проведения ТО";
            button_CheckTO_SSS.UseVisualStyleBackColor = true;
            button_CheckTO_SSS.Click += button_CheckTO_SSS_Click;
            // 
            // button_AddCar_SSS
            // 
            button_AddCar_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_AddCar_SSS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_AddCar_SSS.Location = new Point(12, 163);
            button_AddCar_SSS.Name = "button_AddCar_SSS";
            button_AddCar_SSS.RightToLeft = RightToLeft.No;
            button_AddCar_SSS.Size = new Size(228, 51);
            button_AddCar_SSS.TabIndex = 3;
            button_AddCar_SSS.Text = "Внести авто в базу ТО";
            button_AddCar_SSS.UseVisualStyleBackColor = true;
            button_AddCar_SSS.Click += button_AddCar_SSS_Click;
            // 
            // button_DelCar_SSS
            // 
            button_DelCar_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_DelCar_SSS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_DelCar_SSS.Location = new Point(12, 220);
            button_DelCar_SSS.Name = "button_DelCar_SSS";
            button_DelCar_SSS.RightToLeft = RightToLeft.No;
            button_DelCar_SSS.Size = new Size(228, 51);
            button_DelCar_SSS.TabIndex = 4;
            button_DelCar_SSS.Text = "Удалить авто из базы\r\n";
            button_DelCar_SSS.UseVisualStyleBackColor = true;
            button_DelCar_SSS.Click += button_DelCar_SSS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(656, 482);
            Controls.Add(button_DelCar_SSS);
            Controls.Add(button_AddCar_SSS);
            Controls.Add(button_CheckTO_SSS);
            Controls.Add(button_Info_SSS);
            Controls.Add(pictureBox_Background_SSS);
            MaximumSize = new Size(3840, 2160);
            MinimumSize = new Size(674, 529);
            Name = "MainForm";
            Text = "Спринт 7 | Вариант 8 | Сизиков С. С. | РППб-24-1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Background_SSS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_Background_SSS;
        private Button button_Info_SSS;
        private Button button_CheckTO_SSS;
        private Button button_AddCar_SSS;
        private Button button_DelCar_SSS;
        private Button button1;
    }
}
