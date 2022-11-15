namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelWarningMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxCar1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CarFinishedPicture1 = new System.Windows.Forms.PictureBox();
            this.labelSuccessMessage = new System.Windows.Forms.Label();
            this.pictureBoxCar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarFinishedPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Race";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelWarningMessage
            // 
            this.labelWarningMessage.AutoSize = true;
            this.labelWarningMessage.ForeColor = System.Drawing.Color.Red;
            this.labelWarningMessage.Location = new System.Drawing.Point(516, 155);
            this.labelWarningMessage.Name = "labelWarningMessage";
            this.labelWarningMessage.Size = new System.Drawing.Size(186, 13);
            this.labelWarningMessage.TabIndex = 3;
            this.labelWarningMessage.Text = "Must be a number/ between 2 and 10";
            this.labelWarningMessage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the number of players";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TEST";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle 1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "N°1";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBoxCar1
            // 
            this.pictureBoxCar1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar1.Image")));
            this.pictureBoxCar1.Location = new System.Drawing.Point(80, 118);
            this.pictureBoxCar1.Name = "pictureBoxCar1";
            this.pictureBoxCar1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCar1.TabIndex = 11;
            this.pictureBoxCar1.TabStop = false;
            this.pictureBoxCar1.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBoxBackground1
            // 
            this.pictureBoxBackground1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxBackground1.Location = new System.Drawing.Point(45, 118);
            this.pictureBoxBackground1.Name = "pictureBoxBackground1";
            this.pictureBoxBackground1.Size = new System.Drawing.Size(108, 50);
            this.pictureBoxBackground1.TabIndex = 12;
            this.pictureBoxBackground1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(40, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 2);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // CarFinishedPicture1
            // 
            this.CarFinishedPicture1.BackColor = System.Drawing.Color.Transparent;
            this.CarFinishedPicture1.Image = ((System.Drawing.Image)(resources.GetObject("CarFinishedPicture1.Image")));
            this.CarFinishedPicture1.Location = new System.Drawing.Point(447, 101);
            this.CarFinishedPicture1.Name = "CarFinishedPicture1";
            this.CarFinishedPicture1.Size = new System.Drawing.Size(63, 63);
            this.CarFinishedPicture1.TabIndex = 15;
            this.CarFinishedPicture1.TabStop = false;
            this.CarFinishedPicture1.Visible = false;
            // 
            // labelSuccessMessage
            // 
            this.labelSuccessMessage.AutoSize = true;
            this.labelSuccessMessage.ForeColor = System.Drawing.Color.Green;
            this.labelSuccessMessage.Location = new System.Drawing.Point(518, 155);
            this.labelSuccessMessage.Name = "labelSuccessMessage";
            this.labelSuccessMessage.Size = new System.Drawing.Size(43, 13);
            this.labelSuccessMessage.TabIndex = 16;
            this.labelSuccessMessage.Text = "START";
            this.labelSuccessMessage.Visible = false;
            this.labelSuccessMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxCar2
            // 
            this.pictureBoxCar2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar2.Image")));
            this.pictureBoxCar2.Location = new System.Drawing.Point(80, 177);
            this.pictureBoxCar2.Name = "pictureBoxCar2";
            this.pictureBoxCar2.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCar2.TabIndex = 17;
            this.pictureBoxCar2.TabStop = false;
            this.pictureBoxCar2.Visible = false;
            // 
            // pictureBoxBackground2
            // 
            this.pictureBoxBackground2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxBackground2.Location = new System.Drawing.Point(45, 177);
            this.pictureBoxBackground2.Name = "pictureBoxBackground2";
            this.pictureBoxBackground2.Size = new System.Drawing.Size(108, 50);
            this.pictureBoxBackground2.TabIndex = 18;
            this.pictureBoxBackground2.TabStop = false;
            this.pictureBoxBackground2.Visible = false;
            // 
            // pictureBoxCar3
            // 
            this.pictureBoxCar3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar3.Image")));
            this.pictureBoxCar3.Location = new System.Drawing.Point(80, 233);
            this.pictureBoxCar3.Name = "pictureBoxCar3";
            this.pictureBoxCar3.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCar3.TabIndex = 19;
            this.pictureBoxCar3.TabStop = false;
            this.pictureBoxCar3.Visible = false;
            // 
            // pictureBoxBackground3
            // 
            this.pictureBoxBackground3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxBackground3.Location = new System.Drawing.Point(45, 233);
            this.pictureBoxBackground3.Name = "pictureBoxBackground3";
            this.pictureBoxBackground3.Size = new System.Drawing.Size(108, 50);
            this.pictureBoxBackground3.TabIndex = 20;
            this.pictureBoxBackground3.TabStop = false;
            this.pictureBoxBackground3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(40, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 2);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(40, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(472, 2);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(447, 166);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 63);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(447, 225);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 63);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxCar3);
            this.Controls.Add(this.pictureBoxBackground3);
            this.Controls.Add(this.pictureBoxCar2);
            this.Controls.Add(this.pictureBoxBackground2);
            this.Controls.Add(this.labelSuccessMessage);
            this.Controls.Add(this.CarFinishedPicture1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxCar1);
            this.Controls.Add(this.pictureBoxBackground1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWarningMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarFinishedPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelWarningMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxCar1;
        private System.Windows.Forms.PictureBox pictureBoxBackground1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox CarFinishedPicture1;
        private System.Windows.Forms.Label labelSuccessMessage;
        private System.Windows.Forms.PictureBox pictureBoxCar2;
        private System.Windows.Forms.PictureBox pictureBoxBackground2;
        private System.Windows.Forms.PictureBox pictureBoxCar3;
        private System.Windows.Forms.PictureBox pictureBoxBackground3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

