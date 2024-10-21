using System;
using System.Windows.Forms;

namespace Software1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(0, "Wheel", 15, 12);
            dataGridView1.Rows.Add(1, "Pedal", 11, 8);
            dataGridView1.Rows.Add(2, "Chain", 12, 8);
            dataGridView1.Rows.Add(3, "Seat", 8, 4);

            dataGridView2.Rows.Add(0, "Red Bicycle", 15, 11);
            dataGridView2.Rows.Add(1, "Yellow Bicycle", 19, 9);
            dataGridView2.Rows.Add(2, "Blue Bicycle", 5, 12);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart();
            addPartForm.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.ShowDialog();
        }

        private void Modify1_Click(object sender, EventArgs e)
        {
            ModifyPart modifyPartForm = new ModifyPart();
            modifyPartForm.ShowDialog();
        }

        private void Modify2_Click(object sender, EventArgs e)
        {
            ModifyProd modifyProdForm = new ModifyProd();
            modifyProdForm.ShowDialog();
        }
    }
}
