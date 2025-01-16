namespace Client
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_CountryCode = new TextBox();
            txb_CityName = new TextBox();
            txb_District = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgvResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Country code ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "City Name ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 28);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Distric name ";
            // 
            // txb_CountryCode
            // 
            txb_CountryCode.Location = new Point(158, 21);
            txb_CountryCode.Name = "txb_CountryCode";
            txb_CountryCode.Size = new Size(100, 27);
            txb_CountryCode.TabIndex = 5;
            // 
            // txb_CityName
            // 
            txb_CityName.Location = new Point(158, 88);
            txb_CityName.Name = "txb_CityName";
            txb_CityName.Size = new Size(100, 27);
            txb_CityName.TabIndex = 6;
            // 
            // txb_District
            // 
            txb_District.Location = new Point(482, 21);
            txb_District.Name = "txb_District";
            txb_District.Size = new Size(100, 27);
            txb_District.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(616, 21);
            button1.Name = "button1";
            button1.Size = new Size(172, 47);
            button1.TabIndex = 8;
            button1.Text = "getAllCountry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += getAllCountry_Click;
            // 
            // button2
            // 
            button2.Location = new Point(616, 82);
            button2.Name = "button2";
            button2.Size = new Size(172, 47);
            button2.TabIndex = 9;
            button2.Text = "getCountrybyCode";
            button2.UseVisualStyleBackColor = true;
            button2.Click += getCountrybyCode_Click;
            // 
            // button3
            // 
            button3.Location = new Point(616, 135);
            button3.Name = "button3";
            button3.Size = new Size(172, 47);
            button3.TabIndex = 10;
            button3.Text = "getCityByName";
            button3.UseVisualStyleBackColor = true;
            button3.Click += getCityByName_Click;
            // 
            // button4
            // 
            button4.Location = new Point(616, 251);
            button4.Name = "button4";
            button4.Size = new Size(172, 72);
            button4.TabIndex = 11;
            button4.Text = "getAllCityFromCountryCode";
            button4.UseVisualStyleBackColor = true;
            button4.Click += getAllCityFromCountryCode_Click;
            // 
            // button5
            // 
            button5.Location = new Point(616, 198);
            button5.Name = "button5";
            button5.Size = new Size(172, 47);
            button5.TabIndex = 12;
            button5.Text = "getCityByDistric";
            button5.UseVisualStyleBackColor = true;
            button5.Click += getCityByDistrict_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 179);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(570, 259);
            dgvResults.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResults);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txb_District);
            Controls.Add(txb_CityName);
            Controls.Add(txb_CountryCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txb_CountryCode;
        private TextBox txb_CityName;
        private TextBox txb_District;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgvResults;
    }
}
