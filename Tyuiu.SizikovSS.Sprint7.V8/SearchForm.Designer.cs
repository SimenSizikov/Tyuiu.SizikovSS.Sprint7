namespace Tyuiu.SizikovSS.Sprint7.V8
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            pictureBox1 = new PictureBox();
            dataGrid_Auto_SSS = new DataGridView();
            textBox_Head_SSS = new TextBox();
            textBox_Nomer_SSS = new TextBox();
            button_UpdateProbeg_SSS = new Button();
            textBox_InputProbeg_SSS = new TextBox();
            textBox_probeg_SSS = new TextBox();
            dataGridViewCar_SSS = new DataGridView();
            textBox_InputNomer_SSS = new TextBox();
            button_SearchCar_SSS = new Button();
            button_Update_Grid_SSS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Auto_SSS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar_SSS).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(931, 482);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGrid_Auto_SSS
            // 
            dataGrid_Auto_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Auto_SSS.BackgroundColor = Color.FromArgb(40, 40, 40);
            dataGrid_Auto_SSS.BorderStyle = BorderStyle.Fixed3D;
            dataGrid_Auto_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Auto_SSS.GridColor = SystemColors.ControlDark;
            dataGrid_Auto_SSS.Location = new Point(298, 118);
            dataGrid_Auto_SSS.Name = "dataGrid_Auto_SSS";
            dataGrid_Auto_SSS.RowHeadersWidth = 51;
            dataGrid_Auto_SSS.Size = new Size(622, 352);
            dataGrid_Auto_SSS.TabIndex = 1;
            // 
            // textBox_Head_SSS
            // 
            textBox_Head_SSS.BackColor = Color.Black;
            textBox_Head_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_Head_SSS.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Head_SSS.ForeColor = SystemColors.MenuBar;
            textBox_Head_SSS.Location = new Point(12, 12);
            textBox_Head_SSS.Name = "textBox_Head_SSS";
            textBox_Head_SSS.ReadOnly = true;
            textBox_Head_SSS.Size = new Size(280, 43);
            textBox_Head_SSS.TabIndex = 2;
            textBox_Head_SSS.Text = "Поиск автомобиля\r\n";
            textBox_Head_SSS.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Nomer_SSS
            // 
            textBox_Nomer_SSS.BackColor = Color.Black;
            textBox_Nomer_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_Nomer_SSS.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Nomer_SSS.ForeColor = SystemColors.MenuBar;
            textBox_Nomer_SSS.Location = new Point(12, 82);
            textBox_Nomer_SSS.Name = "textBox_Nomer_SSS";
            textBox_Nomer_SSS.ReadOnly = true;
            textBox_Nomer_SSS.Size = new Size(213, 30);
            textBox_Nomer_SSS.TabIndex = 9;
            textBox_Nomer_SSS.Text = "Введите гос. номер";
            textBox_Nomer_SSS.TextAlign = HorizontalAlignment.Center;
            // 
            // button_UpdateProbeg_SSS
            // 
            button_UpdateProbeg_SSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_UpdateProbeg_SSS.BackColor = Color.Silver;
            button_UpdateProbeg_SSS.DialogResult = DialogResult.Ignore;
            button_UpdateProbeg_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_UpdateProbeg_SSS.Location = new Point(12, 322);
            button_UpdateProbeg_SSS.Name = "button_UpdateProbeg_SSS";
            button_UpdateProbeg_SSS.Size = new Size(213, 68);
            button_UpdateProbeg_SSS.TabIndex = 23;
            button_UpdateProbeg_SSS.Text = "Обновить данные о пробеге";
            button_UpdateProbeg_SSS.UseVisualStyleBackColor = false;
            button_UpdateProbeg_SSS.Click += button_UpdateProbeg_SSS_Click;
            // 
            // textBox_InputProbeg_SSS
            // 
            textBox_InputProbeg_SSS.BackColor = Color.DimGray;
            textBox_InputProbeg_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_InputProbeg_SSS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_InputProbeg_SSS.ForeColor = SystemColors.MenuBar;
            textBox_InputProbeg_SSS.Location = new Point(12, 291);
            textBox_InputProbeg_SSS.Name = "textBox_InputProbeg_SSS";
            textBox_InputProbeg_SSS.Size = new Size(213, 38);
            textBox_InputProbeg_SSS.TabIndex = 22;
            // 
            // textBox_probeg_SSS
            // 
            textBox_probeg_SSS.BackColor = Color.Black;
            textBox_probeg_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_probeg_SSS.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_probeg_SSS.ForeColor = SystemColors.MenuBar;
            textBox_probeg_SSS.Location = new Point(12, 255);
            textBox_probeg_SSS.Name = "textBox_probeg_SSS";
            textBox_probeg_SSS.ReadOnly = true;
            textBox_probeg_SSS.Size = new Size(213, 30);
            textBox_probeg_SSS.TabIndex = 24;
            textBox_probeg_SSS.Text = "Введите гос. номер";
            textBox_probeg_SSS.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewCar_SSS
            // 
            dataGridViewCar_SSS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCar_SSS.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCar_SSS.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCar_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCar_SSS.GridColor = SystemColors.HighlightText;
            dataGridViewCar_SSS.Location = new Point(298, 0);
            dataGridViewCar_SSS.Name = "dataGridViewCar_SSS";
            dataGridViewCar_SSS.RowHeadersWidth = 51;
            dataGridViewCar_SSS.ScrollBars = ScrollBars.Horizontal;
            dataGridViewCar_SSS.Size = new Size(622, 112);
            dataGridViewCar_SSS.TabIndex = 26;
            // 
            // textBox_InputNomer_SSS
            // 
            textBox_InputNomer_SSS.BackColor = Color.DimGray;
            textBox_InputNomer_SSS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_InputNomer_SSS.Location = new Point(12, 130);
            textBox_InputNomer_SSS.Name = "textBox_InputNomer_SSS";
            textBox_InputNomer_SSS.Size = new Size(213, 38);
            textBox_InputNomer_SSS.TabIndex = 27;
            // 
            // button_SearchCar_SSS
            // 
            button_SearchCar_SSS.BackColor = Color.Silver;
            button_SearchCar_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_SearchCar_SSS.Location = new Point(12, 162);
            button_SearchCar_SSS.Name = "button_SearchCar_SSS";
            button_SearchCar_SSS.Size = new Size(213, 56);
            button_SearchCar_SSS.TabIndex = 28;
            button_SearchCar_SSS.Text = "Найти данные авто";
            button_SearchCar_SSS.UseVisualStyleBackColor = false;
            button_SearchCar_SSS.Click += button_SearchCar_SSS_Click;
            // 
            // button_Update_Grid_SSS
            // 
            button_Update_Grid_SSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Update_Grid_SSS.BackColor = Color.Silver;
            button_Update_Grid_SSS.DialogResult = DialogResult.Ignore;
            button_Update_Grid_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Update_Grid_SSS.Location = new Point(12, 402);
            button_Update_Grid_SSS.Name = "button_Update_Grid_SSS";
            button_Update_Grid_SSS.Size = new Size(213, 68);
            button_Update_Grid_SSS.TabIndex = 29;
            button_Update_Grid_SSS.Text = "Обновить таблицу";
            button_Update_Grid_SSS.UseVisualStyleBackColor = false;
            button_Update_Grid_SSS.Click += button_Update_Grid_SSS_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 482);
            Controls.Add(button_Update_Grid_SSS);
            Controls.Add(button_SearchCar_SSS);
            Controls.Add(textBox_InputNomer_SSS);
            Controls.Add(dataGridViewCar_SSS);
            Controls.Add(textBox_InputProbeg_SSS);
            Controls.Add(textBox_probeg_SSS);
            Controls.Add(button_UpdateProbeg_SSS);
            Controls.Add(textBox_Nomer_SSS);
            Controls.Add(textBox_Head_SSS);
            Controls.Add(dataGrid_Auto_SSS);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(3840, 2160);
            MinimumSize = new Size(674, 529);
            Name = "SearchForm";
            Text = "Просмотр данных об авто";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Auto_SSS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar_SSS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGrid_Auto_SSS;
        private TextBox textBox_Head_SSS;
        private TextBox textBox_Nomer_SSS;
        private Button button_UpdateProbeg_SSS;
        private TextBox textBox_InputProbeg_SSS;
        private TextBox textBox_probeg_SSS;
        private DataGridView dataGridViewCar_SSS;
        private TextBox textBox_InputNomer_SSS;
        private Button button_SearchCar_SSS;
        private Button button_Update_Grid_SSS;
    }
}