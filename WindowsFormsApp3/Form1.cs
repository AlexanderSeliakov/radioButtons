using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //inicialization of var which shows flag of a country
        Bitmap flag;

        private void england_CheckedChanged(object sender, EventArgs e)
        {
            if (england.Checked == true)
                flag = new Bitmap("c:\\temp\\engl.png");
            flags(flag);
        }

        private void spain_CheckedChanged(object sender, EventArgs e)
        {
            if (spain.Checked == true)
                flag = new Bitmap("c:\\temp\\sapin.png");
            flags(flag);
        }

        private void france_CheckedChanged(object sender, EventArgs e)
        {
            if (france.Checked == true)
                flag = new Bitmap("c:\\temp\\france.png");
            flags(flag);
        }

        private void finland_CheckedChanged(object sender, EventArgs e)
        {
            if (finland.Checked == true)
                flag = new Bitmap("c:\\temp\\fin.png");
            flags(flag);
        }


        /// <summary>
        /// function shows flag 
        /// </summary>
        /// <param name="flag"></param>
        public void flags(Bitmap flag)
        {
            pictureBox1.Image = flag;
            pictureBox1.Show();

        }
    }
}
