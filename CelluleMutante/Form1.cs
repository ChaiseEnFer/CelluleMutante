﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelluleMutante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_simulation_Click(object sender, EventArgs e)
        {

        }

        private void pnl_cell_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.pnl_cell.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            g.FillEllipse(myBrush, 120, 130, 20, 20);
            myBrush.Dispose();
            g.Dispose();
        }
    }
}
