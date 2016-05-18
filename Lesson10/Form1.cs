#define TRIAL
using System;
using System.Windows.Forms;

namespace Lesson10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if TRIAL
            MessageBox.Show("Купите продукт!");
#else
//#error Не дописал проверки

            //todo доделать проверки
            richTextBox3.Text = (int.Parse(richTextBox1.Text) + int.Parse(richTextBox2.Text)).ToString();
#endif
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Обработка нажатия клавиши клавиатуры
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                return;
            }
            #endregion
        }
    }
}
