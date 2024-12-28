namespace Tyuiu.SizikovSS.Sprint7.V8
{
    partial class DelCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelCarForm));
            pictureBox1 = new PictureBox();
            textBox_Head_SSS = new TextBox();
            textBox_InputNomer_SSS = new TextBox();
            textBox_GosNomer_SSS = new TextBox();
            button_LookCar_SSS = new Button();
            button_DelCar_SSS = new Button();
            dataGridViewCar_SSS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar_SSS).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox_Head_SSS
            // 
            textBox_Head_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Head_SSS.BackColor = Color.Black;
            textBox_Head_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_Head_SSS.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Head_SSS.ForeColor = SystemColors.MenuBar;
            textBox_Head_SSS.Location = new Point(12, 12);
            textBox_Head_SSS.Name = "textBox_Head_SSS";
            textBox_Head_SSS.ReadOnly = true;
            textBox_Head_SSS.Size = new Size(446, 43);
            textBox_Head_SSS.TabIndex = 4;
            textBox_Head_SSS.Text = "Удаление авто из базы\r\n";
            textBox_Head_SSS.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_InputNomer_SSS
            // 
            textBox_InputNomer_SSS.BackColor = Color.DimGray;
            textBox_InputNomer_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_InputNomer_SSS.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_InputNomer_SSS.ForeColor = SystemColors.MenuBar;
            textBox_InputNomer_SSS.Location = new Point(12, 135);
            textBox_InputNomer_SSS.Name = "textBox_InputNomer_SSS";
            textBox_InputNomer_SSS.Size = new Size(366, 43);
            textBox_InputNomer_SSS.TabIndex = 6;
            // 
            // textBox_GosNomer_SSS
            // 
            textBox_GosNomer_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_GosNomer_SSS.BackColor = Color.Black;
            textBox_GosNomer_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_GosNomer_SSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_GosNomer_SSS.ForeColor = SystemColors.MenuBar;
            textBox_GosNomer_SSS.Location = new Point(12, 74);
            textBox_GosNomer_SSS.Multiline = true;
            textBox_GosNomer_SSS.Name = "textBox_GosNomer_SSS";
            textBox_GosNomer_SSS.ReadOnly = true;
            textBox_GosNomer_SSS.Size = new Size(366, 55);
            textBox_GosNomer_SSS.TabIndex = 7;
            textBox_GosNomer_SSS.Text = "Гос номер автомобиля который нужно удалить:\r\n";
            // 
            // button_LookCar_SSS
            // 
            button_LookCar_SSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_LookCar_SSS.BackColor = Color.Silver;
            button_LookCar_SSS.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_LookCar_SSS.Location = new Point(12, 359);
            button_LookCar_SSS.Name = "button_LookCar_SSS";
            button_LookCar_SSS.Size = new Size(446, 47);
            button_LookCar_SSS.TabIndex = 17;
            button_LookCar_SSS.Text = "Просмотреть данные";
            button_LookCar_SSS.UseVisualStyleBackColor = false;
            button_LookCar_SSS.Click += button_LookCar_SSS_Click;
            // 
            // button_DelCar_SSS
            // 
            button_DelCar_SSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_DelCar_SSS.BackColor = Color.FromArgb(55, 0, 1);
            button_DelCar_SSS.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_DelCar_SSS.ForeColor = SystemColors.Control;
            button_DelCar_SSS.Location = new Point(12, 412);
            button_DelCar_SSS.Name = "button_DelCar_SSS";
            button_DelCar_SSS.Size = new Size(446, 99);
            button_DelCar_SSS.TabIndex = 18;
            button_DelCar_SSS.Text = "Удалить авто";
            button_DelCar_SSS.UseVisualStyleBackColor = false;
            button_DelCar_SSS.Click += button_DelCar_SSS_Click;
            // 
            // dataGridViewCar_SSS
            // 
            dataGridViewCar_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCar_SSS.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCar_SSS.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCar_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCar_SSS.GridColor = SystemColors.HighlightText;
            dataGridViewCar_SSS.Location = new Point(12, 197);
            dataGridViewCar_SSS.Name = "dataGridViewCar_SSS";
            dataGridViewCar_SSS.RowHeadersWidth = 51;
            dataGridViewCar_SSS.ScrollBars = ScrollBars.Horizontal;
            dataGridViewCar_SSS.Size = new Size(452, 112);
            dataGridViewCar_SSS.TabIndex = 19;
            // 
            // DelCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 523);
            Controls.Add(dataGridViewCar_SSS);
            Controls.Add(button_DelCar_SSS);
            Controls.Add(button_LookCar_SSS);
            Controls.Add(textBox_GosNomer_SSS);
            Controls.Add(textBox_InputNomer_SSS);
            Controls.Add(textBox_Head_SSS);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(500, 560);
            Name = "DelCarForm";
            Text = "Удалить авто из базы данных";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar_SSS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_Head_SSS;
        private TextBox textBox_InputNomer_SSS;
        private TextBox textBox_GosNomer_SSS;
        private Button button_LookCar_SSS;
        private Button button_DelCar_SSS;
        private DataGridView dataGridViewCar_SSS;
    }
}