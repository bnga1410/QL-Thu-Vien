﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QLTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void chiTiếtMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult bt = MessageBox.Show("Bạn muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (bt == DialogResult.OK)
                Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thaoTácToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
