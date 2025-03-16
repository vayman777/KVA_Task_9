namespace KVA_Task_09.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            buttonBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxShip = new TextBox();
            comboBoxCategory = new ComboBox();
            label4 = new Label();
            comboBoxSort = new ComboBox();
            buttonAdd = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            textBoxDesc = new TextBox();
            labelPrice = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 192);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 86);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.homer_simpson;
            pictureBox2.Location = new Point(-19, -11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(934, 21);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 0;
            label1.Text = "Каталог товаров";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(223, 28);
            label2.TabIndex = 1;
            label2.Text = "Наименование товара:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 2;
            label3.Text = "Выберите категорию:";
            // 
            // textBoxShip
            // 
            textBoxShip.Location = new Point(241, 92);
            textBoxShip.Name = "textBoxShip";
            textBoxShip.Size = new Size(237, 27);
            textBoxShip.TabIndex = 3;
            textBoxShip.TextChanged += textBoxShip_TextChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(241, 140);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(237, 28);
            comboBoxCategory.TabIndex = 4;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(511, 140);
            label4.Name = "label4";
            label4.Size = new Size(156, 28);
            label4.TabIndex = 5;
            label4.Text = "Сортировка по:";
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "По возрастанию цены", "По убыванию цены" });
            comboBoxSort.Location = new Point(688, 143);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(217, 28);
            comboBoxSort.TabIndex = 6;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(519, 92);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(148, 45);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить товар";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(182, 28);
            label5.TabIndex = 8;
            label5.Text = "Результат запроса:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(722, 431);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxDesc);
            panel2.Controls.Add(labelPrice);
            panel2.Controls.Add(labelName);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(763, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 431);
            panel2.TabIndex = 10;
            panel2.Visible = false;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(31, 303);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ReadOnly = true;
            textBoxDesc.Size = new Size(240, 111);
            textBoxDesc.TabIndex = 3;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(22, 271);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(50, 20);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "label7";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(22, 230);
            labelName.Name = "labelName";
            labelName.Size = new Size(50, 20);
            labelName.TabIndex = 1;
            labelName.Text = "label6";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 664);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1070, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(114, 20);
            toolStripStatusLabel1.Text = "Пользователь: ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(59, 20);
            toolStripStatusLabel2.Text = "Статус: ";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 690);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxSort);
            Controls.Add(label4);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxShip);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "MainWindow";
            Text = "MainWindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxShip;
        private ComboBox comboBoxCategory;
        private Label label4;
        private ComboBox comboBoxSort;
        private Button buttonAdd;
        private Label label5;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label labelPrice;
        private Label labelName;
        private PictureBox pictureBox1;
        private TextBox textBoxDesc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button buttonBack;
        private PictureBox pictureBox2;
    }
}