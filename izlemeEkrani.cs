using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _163301059
{
    public partial class izlemeEkrani : Form
    {
        public izlemeEkrani()
        {
            InitializeComponent();
        }
        public int[] dizi;
        private void izlemeEkrani_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.flowLayoutPanel1.ResumeLayout();
            form1.Olustur(5,5,(int)form1.numericMayin.Value);
            form1.ButonDoldur(5,5,flwizle,dizi);
            flwizle.Enabled = false;
            foreach (Control item in flwizle.Controls)
            {
                if ((bool)item.Tag == true)
                {
                    item.BackColor = Color.Red;
                }
                else
                {
                    item.BackColor = Color.Green;
                }

            }
        }
        
      
    }
}
