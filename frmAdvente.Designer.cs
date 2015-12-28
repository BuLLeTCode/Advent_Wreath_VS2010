namespace AdventesKalendars
{
    partial class frmAdvente
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
            this.pbAdventeCandle1 = new System.Windows.Forms.PictureBox();
            this.pbAdvente = new System.Windows.Forms.PictureBox();
            this.pbAdventeCandle2 = new System.Windows.Forms.PictureBox();
            this.pbAdventeCandle3 = new System.Windows.Forms.PictureBox();
            this.pbAdventeCandle4 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAdventeCandle1
            // 
            this.pbAdventeCandle1.BackColor = System.Drawing.Color.Transparent;
            this.pbAdventeCandle1.Location = new System.Drawing.Point(0, 216);
            this.pbAdventeCandle1.Name = "pbAdventeCandle1";
            this.pbAdventeCandle1.Size = new System.Drawing.Size(129, 112);
            this.pbAdventeCandle1.TabIndex = 1;
            this.pbAdventeCandle1.TabStop = false;
            // 
            // pbAdvente
            // 
            this.pbAdvente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAdvente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAdvente.Image = global::AdventesKalendars.Properties.Resources.wreath_23374_640;
            this.pbAdvente.Location = new System.Drawing.Point(0, 0);
            this.pbAdvente.Name = "pbAdvente";
            this.pbAdvente.Size = new System.Drawing.Size(628, 582);
            this.pbAdvente.TabIndex = 0;
            this.pbAdvente.TabStop = false;
            // 
            // pbAdventeCandle2
            // 
            this.pbAdventeCandle2.Location = new System.Drawing.Point(262, 0);
            this.pbAdventeCandle2.Name = "pbAdventeCandle2";
            this.pbAdventeCandle2.Size = new System.Drawing.Size(100, 129);
            this.pbAdventeCandle2.TabIndex = 2;
            this.pbAdventeCandle2.TabStop = false;
            // 
            // pbAdventeCandle3
            // 
            this.pbAdventeCandle3.Location = new System.Drawing.Point(496, 216);
            this.pbAdventeCandle3.Name = "pbAdventeCandle3";
            this.pbAdventeCandle3.Size = new System.Drawing.Size(132, 112);
            this.pbAdventeCandle3.TabIndex = 3;
            this.pbAdventeCandle3.TabStop = false;
            // 
            // pbAdventeCandle4
            // 
            this.pbAdventeCandle4.Location = new System.Drawing.Point(262, 462);
            this.pbAdventeCandle4.Name = "pbAdventeCandle4";
            this.pbAdventeCandle4.Size = new System.Drawing.Size(100, 120);
            this.pbAdventeCandle4.TabIndex = 4;
            this.pbAdventeCandle4.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmAdvente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 578);
            this.Controls.Add(this.pbAdventeCandle4);
            this.Controls.Add(this.pbAdventeCandle3);
            this.Controls.Add(this.pbAdventeCandle2);
            this.Controls.Add(this.pbAdventeCandle1);
            this.Controls.Add(this.pbAdvente);
            this.Name = "frmAdvente";
            this.Text = "Adventes kalendārs";
            this.Load += new System.EventHandler(this.frmAdvente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventeCandle4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdvente;
        private System.Windows.Forms.PictureBox pbAdventeCandle1;
        private System.Windows.Forms.PictureBox pbAdventeCandle2;
        private System.Windows.Forms.PictureBox pbAdventeCandle3;
        private System.Windows.Forms.PictureBox pbAdventeCandle4;
        private System.Windows.Forms.ImageList imageList1;
    }
}