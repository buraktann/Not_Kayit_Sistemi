using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi;

public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("��rencinin numaras�n� giriniz!");
            }
            else
            {
                FrmOgrenciDetay frm = new FrmOgrenciDetay();
                frm.numara = maskedTextBox1.Text;
                frm.Show();
            }

        }

        
    }
