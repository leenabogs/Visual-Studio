using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class example1 : Form
    {
        public example1()
        {
            InitializeComponent();
        }
        tervitus lause = new tervitus();
        private void example1_Load(object sender, EventArgs e)
        {
            lause.nimi = txtNimi.Text;
            lblTulemus.Text = lause.tere();
            txtNimi.Focus();


        }

        private void btnTere_Click(object sender, EventArgs e)
        {
            lause.nimi = txtNimi.Text;
            lblTulemus.Text = lause.tere();
            txtNimi.Focus();
        }

        private void btnV2lja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите завершить проект?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)

                this.Close();
        }

       

        private void btnArv_Click(object sender, EventArgs e)
        {
            summa arvu = new summa();
            try
            {
                arvu.number1 = Convert.ToSingle(txtArv1.Text);
                arvu.number2 = Convert.ToSingle(txtArv2.Text);
                if (chkTehing.Checked)
                {
                    arvu.tehing = "+";
                    chkTehing.Text = "Сумма";

                }
                else 
                {
                    arvu.tehing = "-";
                    chkTehing.Text = "Разность";
                }
                Single tulemused = arvu.arvutus();
                lblSumma1.Text = Convert.ToString(arvu.number1) + arvu.tehing
                    + Convert.ToString(arvu.number2) + " = " + Convert.ToString(tulemused);
            }
            catch
            {
                lblSumma1.Text = "";
                MessageBox.Show("Введите числа", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
;            }
        }

        private void chkTehing_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTehing.Checked == true)
                chkTehing.Text = "Сумма";
            else
                chkTehing.Text = "Разность";


        }

        private void btnV2rv_Click(object sender, EventArgs e)
        {
            if (btnRed.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if (btnBlue.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("Выбери цвет!", "Form Color", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnTyhi_Click(object sender, EventArgs e)
        {
            btnBlue.Checked = false;
            btnRed.Checked = false;
            this.BackColor = SystemColors.Control;
        }
    }
}
