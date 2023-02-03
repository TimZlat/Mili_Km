using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mili_Km
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtMilKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Проверка правильности ввода символов в поле textBox
            //Правильные символы у нас это: цифры, запятая, 
            //<Enter>, <Backspace>
            //Точку тоже считаем правильным символом, просто её заменим на запятую
            //Чтобы запрещенный символ не отображался в поле редактирования,
            //присвоим значение True свойству Handler параметра е
            if ((e.KeyChar>='0') && (e.KeyChar<='9'))
            {
                return; //потому что цифру нажал user
            }
            if(e.KeyChar=='.')
            {
                e.KeyChar = ','; //заменили точку запятой
            }
            if (e.KeyChar==',')
            {
                if ((txtMilKm.Text.IndexOf(',')!=-1))
                    { 
                    // если запятая уже есть в поле редактирования
                        e.Handled = true; 
                    }
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;   

        }

        private void radBtn1_CheckedChanged(object sender, EventArgs e)
        {
            txtMilKm.Visible = true;
            label2.Visible = true;
            txtKmMil.Visible = false;
            label3.Visible = false;
            label5.Text = "";
            txtMilKm.Focus();
        }

        private void radBtn2_CheckedChanged(object sender, EventArgs e)
        {
            txtKmMil.Visible = true;
            label3.Visible = true;
            txtMilKm.Visible = false;
            label2.Visible = false;
            label5.Text = "";
            txtKmMil.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double mile;
            double km;
            if(radBtn1.Checked==true) //если выбран 1-ый переключатель
            {
                try
                {
                    mile=Convert.ToDouble(txtMilKm.Text)*1.60934;
                    label4.Visible = true;
                    label5.Text = txtMilKm.Text + " миль равно " +      mile.ToString("####.##") + " км.";
                }
                catch
                {
                    MessageBox.Show("Поле ввода пустое. Повторите ввод", "Предупреждение!");
                    txtMilKm.Focus();
                }
            }
            if (radBtn2.Checked == true) // если выбран 2-й переключатель
            {
                try
                {
                    km = Convert.ToDouble(txtKmMil.Text) * 0.6213;
                    label4.Visible = true;
                    label5.Text = txtKmMil.Text + " км равно " + km.ToString("n") + " миль.";
                }
                catch
                {
                    MessageBox.Show("Поле ввода пустое. Повторите ввод", "Предупреждение!");
                    txtKmMil.Focus();
                }
                
            }

        }

        private void txtKmMil_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return; //потому что цифру нажал user
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; //заменили точку запятой
            }
            if (e.KeyChar == ',')
            {
                if ((txtKmMil.Text.IndexOf(',') != -1))
                {
                    // если запятая уже есть в поле редактирования
                    e.Handled = true;
                }
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}
