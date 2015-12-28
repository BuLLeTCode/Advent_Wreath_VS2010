using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventesKalendars
{
    public partial class frmAdvente : Form
    {
        public frmAdvente()
        {
            InitializeComponent();
        }

        private void frmAdvente_Load(object sender, EventArgs e)
        {
            DateTime dateNow = new DateTime();
            dateNow = DateTime.Now;
            int todayIs = int.Parse(dateNow.Day.ToString());

            DateTime advent1 = new DateTime(2015, 11, 29);
            DateTime advent2 = new DateTime(2015, 12, 6);
            DateTime advent3 = new DateTime(2015, 12, 13);
            DateTime advent4 = new DateTime(2015, 12, 20);

            Console.WriteLine(todayIs);

            if (dateNow >= advent1)
            {
                Console.WriteLine("Pirmā advente");
                pbAdventeCandle1.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle1.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle1.Parent = pbAdvente;
                pbAdventeCandle1.BackColor = Color.Transparent;
                //pbAdventeCandle1.Location = new Point(0, 0);
                //pbAdventeCandle1.BackColor = Color.Transparent;
                pbAdventeCandle2.SendToBack();
                pbAdventeCandle3.SendToBack();
                pbAdventeCandle4.SendToBack();
            }
            
            if (dateNow >= advent2)
            {
                Console.WriteLine("Otrā advente");
                pbAdventeCandle1.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle1.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle1.Parent = pbAdvente;
                pbAdventeCandle1.BackColor = Color.Transparent;

                pbAdventeCandle2.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle2.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle2.Parent = pbAdvente;
                pbAdventeCandle2.BackColor = Color.Transparent;

                pbAdventeCandle3.SendToBack();
                pbAdventeCandle4.SendToBack();
            }
            
            if (dateNow >= advent3)
            {
                Console.WriteLine("Trešā advente");

                pbAdventeCandle1.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle1.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle1.Parent = pbAdvente;
                pbAdventeCandle1.BackColor = Color.Transparent;

                pbAdventeCandle2.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle2.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle2.Parent = pbAdvente;
                pbAdventeCandle2.BackColor = Color.Transparent;

                pbAdventeCandle3.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle3.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle3.Parent = pbAdvente;
                pbAdventeCandle3.BackColor = Color.Transparent;

                pbAdventeCandle4.SendToBack();
            }
            
            if (dateNow >= advent4)
            {
                Console.WriteLine("Ceturtā advente");

                pbAdventeCandle1.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle1.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle1.Parent = pbAdvente;
                pbAdventeCandle1.BackColor = Color.Transparent;

                pbAdventeCandle2.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle2.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle2.Parent = pbAdvente;
                pbAdventeCandle2.BackColor = Color.Transparent;

                pbAdventeCandle3.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle3.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle3.Parent = pbAdvente;
                pbAdventeCandle3.BackColor = Color.Transparent;

                pbAdventeCandle4.Image = Properties.Resources.AdventeCandleReal;
                pbAdventeCandle4.SizeMode = PictureBoxSizeMode.Zoom;
                pbAdventeCandle4.Parent = pbAdvente;
                pbAdventeCandle4.BackColor = Color.Transparent;
            }
        }
    }
}
