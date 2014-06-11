namespace AsyncSamples
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
            this.btnNormalString = new System.Windows.Forms.Button();
            this.btnAsyncString = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNormalPicture = new System.Windows.Forms.Button();
            this.btnAsyncPicture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNormalSleep = new System.Windows.Forms.Button();
            this.btnAsyncSleep = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNormalString
            // 
            this.btnNormalString.Location = new System.Drawing.Point(6, 19);
            this.btnNormalString.Name = "btnNormalString";
            this.btnNormalString.Size = new System.Drawing.Size(272, 23);
            this.btnNormalString.TabIndex = 0;
            this.btnNormalString.Text = "Senkron Olarak Çağır";
            this.btnNormalString.UseVisualStyleBackColor = true;
            this.btnNormalString.Click += new System.EventHandler(this.btnNormalString_Click);
            // 
            // btnAsyncString
            // 
            this.btnAsyncString.Location = new System.Drawing.Point(6, 48);
            this.btnAsyncString.Name = "btnAsyncString";
            this.btnAsyncString.Size = new System.Drawing.Size(272, 23);
            this.btnAsyncString.TabIndex = 1;
            this.btnAsyncString.Text = "Asenkron Olarak Çağır";
            this.btnAsyncString.UseVisualStyleBackColor = true;
            this.btnAsyncString.Click += new System.EventHandler(this.btnAsyncString_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnNormalPicture);
            this.groupBox2.Controls.Add(this.btnAsyncPicture);
            this.groupBox2.Location = new System.Drawing.Point(27, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asenkron Olarak Resim İsteme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 135);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNormalPicture
            // 
            this.btnNormalPicture.Location = new System.Drawing.Point(5, 161);
            this.btnNormalPicture.Name = "btnNormalPicture";
            this.btnNormalPicture.Size = new System.Drawing.Size(272, 23);
            this.btnNormalPicture.TabIndex = 0;
            this.btnNormalPicture.Text = "Senkron Olarak Çağır";
            this.btnNormalPicture.UseVisualStyleBackColor = true;
            this.btnNormalPicture.Click += new System.EventHandler(this.btnNormalPicture_Click);
            // 
            // btnAsyncPicture
            // 
            this.btnAsyncPicture.Location = new System.Drawing.Point(5, 190);
            this.btnAsyncPicture.Name = "btnAsyncPicture";
            this.btnAsyncPicture.Size = new System.Drawing.Size(272, 23);
            this.btnAsyncPicture.TabIndex = 1;
            this.btnAsyncPicture.Text = "Asenkron Olarak Çağır";
            this.btnAsyncPicture.UseVisualStyleBackColor = true;
            this.btnAsyncPicture.Click += new System.EventHandler(this.btnAsyncPicture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNormalString);
            this.groupBox1.Controls.Add(this.btnAsyncString);
            this.groupBox1.Location = new System.Drawing.Point(27, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asenkron/Senkron olarak StringVeri İsteme";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNormalSleep);
            this.groupBox3.Controls.Add(this.btnAsyncSleep);
            this.groupBox3.Location = new System.Drawing.Point(23, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 80);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asenkron/Senkron Thread.Sleep Uygulama";
            // 
            // btnNormalSleep
            // 
            this.btnNormalSleep.Location = new System.Drawing.Point(6, 19);
            this.btnNormalSleep.Name = "btnNormalSleep";
            this.btnNormalSleep.Size = new System.Drawing.Size(272, 23);
            this.btnNormalSleep.TabIndex = 0;
            this.btnNormalSleep.Text = "Senkron Olarak Çağır";
            this.btnNormalSleep.UseVisualStyleBackColor = true;
            this.btnNormalSleep.Click += new System.EventHandler(this.btnNormalSleep_Click);
            // 
            // btnAsyncSleep
            // 
            this.btnAsyncSleep.Location = new System.Drawing.Point(6, 48);
            this.btnAsyncSleep.Name = "btnAsyncSleep";
            this.btnAsyncSleep.Size = new System.Drawing.Size(272, 23);
            this.btnAsyncSleep.TabIndex = 1;
            this.btnAsyncSleep.Text = "Asenkron Olarak Çağır";
            this.btnAsyncSleep.UseVisualStyleBackColor = true;
            this.btnAsyncSleep.Click += new System.EventHandler(this.btnAsyncSleep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Asenkron/Senkron Örnekler";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormalString;
        private System.Windows.Forms.Button btnAsyncString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNormalPicture;
        private System.Windows.Forms.Button btnAsyncPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNormalSleep;
        private System.Windows.Forms.Button btnAsyncSleep;
    }
}

