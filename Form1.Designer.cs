namespace Web_Capture
{
    partial class Form1
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
            this.comboBoxCam = new System.Windows.Forms.ComboBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnSaveImg = new System.Windows.Forms.Button();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCam
            // 
            this.comboBoxCam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxCam.DropDownHeight = 130;
            this.comboBoxCam.FormattingEnabled = true;
            this.comboBoxCam.IntegralHeight = false;
            this.comboBoxCam.Location = new System.Drawing.Point(16, 15);
            this.comboBoxCam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCam.Name = "comboBoxCam";
            this.comboBoxCam.Size = new System.Drawing.Size(255, 24);
            this.comboBoxCam.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnStart.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(290, 11);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(115, 34);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnSaveImg
            // 
            this.BtnSaveImg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSaveImg.Font = new System.Drawing.Font("Romantic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BtnSaveImg.Location = new System.Drawing.Point(536, 11);
            this.BtnSaveImg.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveImg.Name = "BtnSaveImg";
            this.BtnSaveImg.Size = new System.Drawing.Size(131, 34);
            this.BtnSaveImg.TabIndex = 2;
            this.BtnSaveImg.Text = "Save Image";
            this.BtnSaveImg.UseVisualStyleBackColor = false;
            this.BtnSaveImg.Click += new System.EventHandler(this.BtnSaveImg_Click);
            // 
            // BtnCapture
            // 
            this.BtnCapture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCapture.Font = new System.Drawing.Font("PanRoman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BtnCapture.Location = new System.Drawing.Point(413, 11);
            this.BtnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(115, 34);
            this.BtnCapture.TabIndex = 3;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = false;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.IndianRed;
            this.BtnExit.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1314, 14);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(123, 48);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 70);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1422, 647);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // picBox1
            // 
            this.picBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox1.Location = new System.Drawing.Point(4, 4);
            this.picBox1.Margin = new System.Windows.Forms.Padding(4);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(703, 639);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // picBox2
            // 
            this.picBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox2.Location = new System.Drawing.Point(715, 4);
            this.picBox2.Margin = new System.Windows.Forms.Padding(4);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(703, 639);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.BtnSaveImg);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.comboBoxCam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "WebCapture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCam;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnSaveImg;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
    }
}

