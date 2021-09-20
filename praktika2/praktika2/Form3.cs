using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "222")
            {
                Form4 f = new Form4();
                f.Show();
            }
            else MessageBox.Show("Неверный пароль или имя пользователя! Попробуйте заново!");
        }
    }
}
