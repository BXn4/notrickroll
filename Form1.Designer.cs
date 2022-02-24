namespace FreeRobux
{
    partial class rickrollform
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rick = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lyrcs = new System.Windows.Forms.Label();
            this.debugszamlalo = new System.Windows.Forms.Label();
            this.lyrcs2 = new System.Windows.Forms.Label();
            this.lyrcs3 = new System.Windows.Forms.Label();
            this.cimke = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rick
            // 
            this.rick.Image = global::FreeRobux.Properties.Resources.rick;
            this.rick.Location = new System.Drawing.Point(168, 156);
            this.rick.Name = "rick";
            this.rick.Size = new System.Drawing.Size(219, 156);
            this.rick.TabIndex = 4;
            this.rick.TabStop = false;
            this.rick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rick_MouseDown);
            this.rick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rick_MouseUp);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.Image = global::FreeRobux.Properties.Resources.rick;
            this.label1.Location = new System.Drawing.Point(393, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 156);
            this.label1.TabIndex = 5;
            this.label1.TabStop = false;
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lyrcs
            // 
            this.lyrcs.AutoSize = true;
            this.lyrcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lyrcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lyrcs.ForeColor = System.Drawing.Color.Black;
            this.lyrcs.Location = new System.Drawing.Point(0, 0);
            this.lyrcs.Name = "lyrcs";
            this.lyrcs.Size = new System.Drawing.Size(0, 25);
            this.lyrcs.TabIndex = 6;
            // 
            // debugszamlalo
            // 
            this.debugszamlalo.AutoSize = true;
            this.debugszamlalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.debugszamlalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.debugszamlalo.ForeColor = System.Drawing.Color.Black;
            this.debugszamlalo.Location = new System.Drawing.Point(28, 119);
            this.debugszamlalo.Name = "debugszamlalo";
            this.debugszamlalo.Size = new System.Drawing.Size(24, 25);
            this.debugszamlalo.TabIndex = 1;
            this.debugszamlalo.Text = "0";
            this.debugszamlalo.Visible = false;
            // 
            // lyrcs2
            // 
            this.lyrcs2.AutoSize = true;
            this.lyrcs2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lyrcs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lyrcs2.ForeColor = System.Drawing.Color.Black;
            this.lyrcs2.Location = new System.Drawing.Point(0, 25);
            this.lyrcs2.Name = "lyrcs2";
            this.lyrcs2.Size = new System.Drawing.Size(0, 25);
            this.lyrcs2.TabIndex = 7;
            // 
            // lyrcs3
            // 
            this.lyrcs3.AutoSize = true;
            this.lyrcs3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lyrcs3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lyrcs3.ForeColor = System.Drawing.Color.Black;
            this.lyrcs3.Location = new System.Drawing.Point(0, 50);
            this.lyrcs3.Name = "lyrcs3";
            this.lyrcs3.Size = new System.Drawing.Size(0, 25);
            this.lyrcs3.TabIndex = 8;
            // 
            // cimke
            // 
            this.cimke.AutoSize = true;
            this.cimke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cimke.ForeColor = System.Drawing.Color.Black;
            this.cimke.Location = new System.Drawing.Point(326, 578);
            this.cimke.Name = "cimke";
            this.cimke.Size = new System.Drawing.Size(31, 13);
            this.cimke.TabIndex = 9;
            this.cimke.Text = "haha";
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // rickrollform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.cimke);
            this.Controls.Add(this.debugszamlalo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rick);
            this.Controls.Add(this.lyrcs3);
            this.Controls.Add(this.lyrcs2);
            this.Controls.Add(this.lyrcs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rickrollform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RICKROLL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rickrollform_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.rickrollform_FormClosed);
            this.Load += new System.EventHandler(this.rickroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox rick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox label1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lyrcs;
        private System.Windows.Forms.Label debugszamlalo;
        private System.Windows.Forms.Label lyrcs2;
        private System.Windows.Forms.Label lyrcs3;
        private System.Windows.Forms.Label cimke;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

