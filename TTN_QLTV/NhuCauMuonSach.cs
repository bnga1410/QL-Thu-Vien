using System;
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
    public partial class NhuCauMuonSach : Form
    {
        public NhuCauMuonSach()
        {
            InitializeComponent();
        }

        private void NhuCauMuonSach_Load(object sender, EventArgs e)
        {
            
        }

        private bool validate()
        {
           
        }

        private void hien()
        {
           
        }

        private void binding()
        {
           
        }
        private void motxt()
        {
            txtstt.Enabled = true;
            txtso.Enabled = true;
            cmbsach.Enabled = true;
            txtsoluong1.Enabled = true;
            cmbdocgia.Enabled = true;
            dtngaymuon.Enabled = true;
            dtngayhantra.Enabled = true;
            txtghichu.Enabled = true;
            cmbnhanvien.Enabled = true;
            
        }

        private void dongtxt()
        {
            txtstt.Enabled = false;
            txtso.Enabled = false;
            cmbsach.Enabled = false;
            txtsoluong1.Enabled = false;
            cmbdocgia.Enabled = false;
            dtngaymuon.Enabled = false;
            dtngayhantra.Enabled = false;
            txtghichu.Enabled = false;
            cmbnhanvien.Enabled = false;
            
        }

        private void mobtn()
        {
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }

        private void dongbtn()
        {
            btluu.Enabled = true;
            bthuy.Enabled = true;
            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }

        string state = "";

        private void btthem_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "insert";
        }

        private void btsua_Click(object sender, EventArgs e)
        {

            motxt();
            dongbtn();
            state = "update";
            binding();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "delete";
            binding();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
           





        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            mobtn();
            dongtxt();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbdocgia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
