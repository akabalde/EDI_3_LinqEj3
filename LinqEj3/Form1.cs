using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LinqEj3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var estados =
                    from c in db.Estados
                    select c;

                dataGridView1.DataSource = estados;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                db.insertarEstados(textBox1.Text);
            }

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                //TXT_Editar_1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                TXT_Editar_1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }

            //if (dataGridView1.SelectedCells.Count != 0)
            //{
            //    TXT_Editar_1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            //    //TXT_Editar_1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            //}
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
