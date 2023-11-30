using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_tabuadaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (rdbUm.Checked == true) {
                lstRes.Items.Clear();
                int num = 1;
                for (int i = 0; i < 11; i++) {

                   int res = num * i;
                
                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }

               
                
             }

            if (rdbDois.Checked == true)
            {
                   lstRes.Items.Clear();

                int num = 2;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if(rdbTres.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 3;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if(rdbQuatro.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 4;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if (rdbCinco.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 5;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if (rdbSeis.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 6;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if (rdbSete.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 7;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if (rdbOito.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 8;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if (rdbNove.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 9;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }

            if (rdbDez.Checked == true)
            {
                lstRes.Items.Clear();

                int num = 10;
                for (int i = 0; i < 11; i++)
                {

                    int res = num * i;

                    lstRes.Items.Add(num + " X " + i + " = " + res);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
        }
    }
}
