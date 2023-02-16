
namespace tamagotchi_goeie
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbWelZ = new System.Windows.Forms.ProgressBar();
            this.pbDorst = new System.Windows.Forms.ProgressBar();
            this.pbHonger = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEten = new System.Windows.Forms.Button();
            this.btnDrinken = new System.Windows.Forms.Button();
            this.timerWelzijn = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Uw huidige score is :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(117, 430);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 26;
            // 
            // pbWelZ
            // 
            this.pbWelZ.Location = new System.Drawing.Point(473, 24);
            this.pbWelZ.Name = "pbWelZ";
            this.pbWelZ.Size = new System.Drawing.Size(265, 43);
            this.pbWelZ.TabIndex = 25;
            this.pbWelZ.Value = 100;
            this.pbWelZ.Click += new System.EventHandler(this.pbWelZ_Click);
            // 
            // pbDorst
            // 
            this.pbDorst.Location = new System.Drawing.Point(15, 171);
            this.pbDorst.Name = "pbDorst";
            this.pbDorst.Size = new System.Drawing.Size(265, 43);
            this.pbDorst.TabIndex = 24;
            this.pbDorst.Value = 100;
            // 
            // pbHonger
            // 
            this.pbHonger.Location = new System.Drawing.Point(15, 49);
            this.pbHonger.Name = "pbHonger";
            this.pbHonger.Size = new System.Drawing.Size(265, 43);
            this.pbHonger.TabIndex = 23;
            this.pbHonger.Value = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vol";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tamagotchi_goeie.Properties.Resources.ziek;
            this.pictureBox1.Location = new System.Drawing.Point(487, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Algemene welzijn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dorst";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Honger";
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(286, 69);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(75, 23);
            this.btnEten.TabIndex = 17;
            this.btnEten.Text = "Geef eten";
            this.btnEten.UseVisualStyleBackColor = true;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // btnDrinken
            // 
            this.btnDrinken.Location = new System.Drawing.Point(286, 191);
            this.btnDrinken.Name = "btnDrinken";
            this.btnDrinken.Size = new System.Drawing.Size(90, 23);
            this.btnDrinken.TabIndex = 16;
            this.btnDrinken.Text = "Geef drinken";
            this.btnDrinken.UseVisualStyleBackColor = true;
            this.btnDrinken.Click += new System.EventHandler(this.btnDrinken_Click);
            // 
            // timerWelzijn
            // 
            this.timerWelzijn.Interval = 1;
            this.timerWelzijn.Tick += new System.EventHandler(this.timerWelzijn_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbWelZ);
            this.Controls.Add(this.pbDorst);
            this.Controls.Add(this.pbHonger);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.btnDrinken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar pbWelZ;
        private System.Windows.Forms.ProgressBar pbDorst;
        private System.Windows.Forms.ProgressBar pbHonger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Button btnDrinken;
        private System.Windows.Forms.Timer timerWelzijn;
    }
}

