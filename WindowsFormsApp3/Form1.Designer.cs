namespace WindowsFormsApp3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finland = new System.Windows.Forms.RadioButton();
            this.france = new System.Windows.Forms.RadioButton();
            this.spain = new System.Windows.Forms.RadioButton();
            this.england = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finland);
            this.groupBox1.Controls.Add(this.france);
            this.groupBox1.Controls.Add(this.spain);
            this.groupBox1.Controls.Add(this.england);
            this.groupBox1.Location = new System.Drawing.Point(134, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // finland
            // 
            this.finland.AutoSize = true;
            this.finland.Location = new System.Drawing.Point(0, 412);
            this.finland.Name = "finland";
            this.finland.Size = new System.Drawing.Size(114, 29);
            this.finland.TabIndex = 4;
            this.finland.Text = "Finland";
            this.finland.UseVisualStyleBackColor = true;
            this.finland.CheckedChanged += new System.EventHandler(this.finland_CheckedChanged);
            // 
            // france
            // 
            this.france.AutoSize = true;
            this.france.Location = new System.Drawing.Point(0, 288);
            this.france.Name = "france";
            this.france.Size = new System.Drawing.Size(110, 29);
            this.france.TabIndex = 3;
            this.france.Text = "France";
            this.france.UseVisualStyleBackColor = true;
            this.france.CheckedChanged += new System.EventHandler(this.france_CheckedChanged);
            // 
            // spain
            // 
            this.spain.AutoSize = true;
            this.spain.Location = new System.Drawing.Point(0, 180);
            this.spain.Name = "spain";
            this.spain.Size = new System.Drawing.Size(98, 29);
            this.spain.TabIndex = 2;
            this.spain.Text = "Spain";
            this.spain.UseVisualStyleBackColor = true;
            this.spain.CheckedChanged += new System.EventHandler(this.spain_CheckedChanged);
            // 
            // england
            // 
            this.england.AutoSize = true;
            this.england.Location = new System.Drawing.Point(0, 76);
            this.england.Name = "england";
            this.england.Size = new System.Drawing.Size(122, 29);
            this.england.TabIndex = 1;
            this.england.Text = "England";
            this.england.UseVisualStyleBackColor = true;
            this.england.CheckedChanged += new System.EventHandler(this.england_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(461, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton finland;
        private System.Windows.Forms.RadioButton france;
        private System.Windows.Forms.RadioButton spain;
        private System.Windows.Forms.RadioButton england;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

