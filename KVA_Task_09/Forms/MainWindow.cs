using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KVA_Task_9.Models;
using Microsoft.EntityFrameworkCore;

namespace KVA_Task_09.Forms
{
    public partial class MainWindow : Form
    {
        private KVA_Task_9.Models.User _currentUser;
        public MainWindow(KVA_Task_9.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            toolStripStatusLabel1.Text += _currentUser.Name;
            toolStripStatusLabel2.Text += _currentUser.Role;
            LoadCategoryInComboBox();
            UpdateData();
        }

        private async void LoadCategoryInComboBox()
        {
            using var context = new ShopDbContext();
            var categoryList = await context.Categorys.ToArrayAsync();
            comboBoxCategory.Items.Add("Всё категории");
            comboBoxCategory.Items.AddRange(categoryList);
            comboBoxCategory.SelectedIndex = 0;
        }

        public async void UpdateData()
        {
            using var context = new ShopDbContext();
            var goods = await context.Goods
                .Include(g => g.Category)
                .Select(g => new
                {
                    Id = g.Id,
                    Name = g.GoodName,
                    Price = g.Price,
                    //Image = g.Picture,
                    Description = g.Description,
                    Category = g.Category.CategoryName
                }).Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToListAsync();

            //goods = goods.Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToList();

            if (comboBoxCategory.SelectedIndex > 0)
            {
                goods = goods.Where(g => g.Category == comboBoxCategory.Text).ToList();
            }
            else
            {
                goods = await context.Goods
                .Include(g => g.Category)
                .Select(g => new
                {
                    Id = g.Id,
                    Name = g.GoodName,
                    Price = g.Price,
                    //Image = g.Picture,
                    Description = g.Description,
                    Category = g.Category.CategoryName
                }).Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToListAsync();
            }

            if (comboBoxSort.SelectedIndex >= 0)
            {
                if (comboBoxSort.SelectedIndex == 0)
                    goods = goods.OrderBy(g => g.Price).ToList();
                if (comboBoxSort.SelectedIndex == 1)
                    goods = goods.OrderByDescending(g => g.Price).ToList();
            }

            dataGridView1.DataSource = goods;
            UpdateColumns();
        }

        private static System.Drawing.Image? ConvertByteArrayToImage(byte[]? byteArray)
        {
            if (byteArray == null)
            {
                //throw new ArgumentException("Массив байтов пуст или null.");
                return null;
            }

            try
            {
                using var ms = new MemoryStream(byteArray);
                return System.Drawing.Image.FromStream(ms);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка: массив байтов не содержит корректное изображение." + ex.ToString());
                return null;
            }
        }

        private void UpdateColumns()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название товара";
            dataGridView1.Columns[2].HeaderText = "Цена";
            //dataGridView1.Columns[2].HeaderText = "Изображение";
            dataGridView1.Columns[3].HeaderText = "Описание";
            dataGridView1.Columns[4].HeaderText = "Категория";
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void textBoxShip_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddGoodForm(this);
            addForm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            using ShopDbContext dbContext = new ShopDbContext();

            int selectedIndex = dataGridView1.Rows[e.RowIndex].Index;

            var selectedGood = dbContext.Goods.FirstOrDefault(g => g.Id == (int)dataGridView1.Rows[selectedIndex].Cells[0].Value);

            if (selectedGood != null)
            {
                labelName.Text = selectedGood.GoodName;
                labelPrice.Text = selectedGood.Price.ToString();
                textBoxDesc.Text = selectedGood.Description;
                pictureBox1.Image = ConvertByteArrayToImage(selectedGood.Picture);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            fmLogin fmlogin = new fmLogin();
            fmlogin.Show();
            this.Close();
        }
    }
}
