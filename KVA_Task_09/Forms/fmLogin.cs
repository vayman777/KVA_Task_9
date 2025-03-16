using KVA_Task_9.Models;
using KVA_Task_09.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVA_Task_09
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (var db = new ShopDbContext())
                {
                    var users = db.Users.AsNoTracking().ToList();
                    User user = users.FirstOrDefault(p => p.Name == textBox1.Text && p.Password == textBox2.Text);
                    if (user != null)
                    {
                        if (user.Role == "admin")
                        {
                            MainWindow mainwindow = new MainWindow(user);
                            this.Hide();
                            mainwindow.Show();

                        }
                    }
                    else
                        MessageBox.Show("Неверный логин или пароль.Попробуйте ещё раз", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Не подключена БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }
    }
}
