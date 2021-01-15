using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRAKTIKUMWEEKTERAKHIR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelBuDewi_Click(object sender, EventArgs e)
        {
            
        }     

        private void labelHargaOtomatis_Click(object sender, EventArgs e)
        {
            if( comboBoxMenu.SelectedItem.ToString() == a)
            {
                labelHargaOtomatis.Text = "10000";
            }
            else if (comboBoxMenu.SelectedItem.ToString() == b)
            {
                labelHargaOtomatis.Text = "12000";
            }
            else if (comboBoxMenu.SelectedItem.ToString() == c)
            {
                labelHargaOtomatis.Text = "15000";
            }
            else if (comboBoxMenu.SelectedItem.ToString() == d)
            {
                labelHargaOtomatis.Text = "15000";
            }
            else if (comboBoxMenu.SelectedItem.ToString() == i )
            {
                labelHargaOtomatis.Text = "5000";
            }
           
            else if (comboBoxMenu.SelectedItem.ToString() == f)
            {
                labelHargaOtomatis.Text = "3000";
            }
            else if (comboBoxMenu.SelectedItem.ToString() == g)
            {
                labelHargaOtomatis.Text = "6000";
            }
            else if (comboBoxMenu.SelectedItem.ToString() == h)
            {
                labelHargaOtomatis.Text = "2000";
            }
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                radioButtonNormal.Enabled = true;
            }
            else
            {
                radioButtonNormal.Enabled = false;
            }
        }

        private void radioButtonJumbo_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static string a = "Nasi Goreng";
        public static string b = "Nasi Goreng Spesial";
        public static string c = "Nasi Goreng Pete";
        public static string d = "Ayam Bakar";
        private void radioButtonoMakanan_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Clear();

            if( radioButtonoMakanan.Checked == true)
            {
                comboBoxMenu.Items.Add(a);
                comboBoxMenu.Items.Add(b);
                comboBoxMenu.Items.Add(c);
                comboBoxMenu.Items.Add(d);
            }


        }
        public static string i = "Es Teh";
        public static string f = "Teh Hangat";
        public static string g = "Nutrisari";
        public static string h = "Aqua";
        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Clear();
            if (radioButtonMinuman.Checked == true)
            {
                comboBoxMenu.Items.Add(i);
                comboBoxMenu.Items.Add(f);
                comboBoxMenu.Items.Add(g);
                comboBoxMenu.Items.Add(h);
            }
        }
        private void labelHarga_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            // UNTUK REMOVE SELEKSI KEDUA OPSI ( MENU DAN HARGA ) LALU DELETE :)
            listBoxMenu.Items.Remove(listBoxMenu.SelectedItem);
            listBoxHarga.Items.Remove(listBoxHarga.SelectedItem);
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if(radioButtonoMakanan==true)
            {

            }
        }
        public int total = 0;
        private void buttonBUY_Click(object sender, EventArgs e)
        {
           
            if (comboBoxMenu.SelectedItem.ToString() == a)
            {
                listBoxMenu.Items.Add(a);
                listBoxHarga.Items.Add("10000");
            }
            else if (comboBoxMenu.SelectedItem.ToString() == b)
            {
                listBoxMenu.Items.Add(b);
                listBoxHarga.Items.Add("12000");
            }
            else if (comboBoxMenu.SelectedItem.ToString() == c)
            {
                listBoxMenu.Items.Add(c);
                listBoxHarga.Items.Add("15000");
            }
            else if (comboBoxMenu.SelectedItem.ToString() == d)
            {
                listBoxMenu.Items.Add(d);
                listBoxHarga.Items.Add("15000");
            }
            else if (comboBoxMenu.SelectedItem.ToString() == i)
            {
                listBoxMenu.Items.Add(i );
                listBoxHarga.Items.Add("5000");
            }
            else if (comboBoxMenu.SelectedItem.ToString() == f)
            {
                listBoxMenu.Items.Add(f );
                listBoxHarga.Items.Add("3000");
            }
            else if (comboBoxMenu.SelectedItem.ToString() == g)
            {
                listBoxMenu.Items.Add(g );
                listBoxHarga.Items.Add("6000");
            }
            else if (comboBoxMenu.SelectedItem.ToString() == h)
            {
                listBoxMenu.Items.Add(h );
                listBoxHarga.Items.Add("2000");
            }
           

            //ON OFF DELETE
            if (listBoxMenu.Items.Count != 0)
            {
                buttonDelete.Enabled = true;
                //button2.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = false;
            }

        }

        private void listBoxHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void labelSize_Click(object sender, EventArgs e)
        {
            if(radioButtonMinuman.Checked == true)
            {
                //labelSize.Text == labelSize.Text.Visible;
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if(listBoxMenu.Items.Count==0)
            {
                MessageBox.Show("Choose Menu");
            }
            else
            {
                Form2 formbaru = new Form2();
                formbaru.Show();
            }
        }
    }
}
