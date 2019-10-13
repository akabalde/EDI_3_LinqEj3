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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Estados_Refresh();
        }

        private void Estados_Refresh()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var estados =
                    from c in db.Estados
                    select c;

                DGV_Estados.DataSource = estados;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                db.insertarEstados(TXT_Agregar.Text);
                TXT_Agregar.Text = "";
                Estados_Refresh();
            }

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Estados.SelectedRows.Count != 0)
            {
                //TXT_Editar_1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                TXT_Editar_1.Text = DGV_Estados.SelectedRows[0].Cells[0].Value.ToString();
                TXT_Editar_2.Text = DGV_Estados.SelectedRows[0].Cells[1].Value.ToString();
            }

            //if (dataGridView1.SelectedCells.Count != 0)
            //{
            //    TXT_Editar_1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            //    //TXT_Editar_1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            //}
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (DGV_Estados.SelectedRows.Count != 0)
            {
                TXT_Editar_1.Text = DGV_Estados.SelectedRows[0].Cells[0].Value.ToString();

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.borrarEstados(int.Parse(TXT_Editar_1.Text));
                    TXT_Editar_1.Text = "";
                    TXT_Editar_2.Text = "";
                    Estados_Refresh();
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            if (DGV_Estados.SelectedRows.Count != 0)
            {
                TXT_Editar_1.Text = DGV_Estados.SelectedRows[0].Cells[0].Value.ToString();

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.editarEstados(int.Parse(TXT_Editar_1.Text), TXT_Editar_3.Text);
                    
                    TXT_Editar_1.Text = "";
                    TXT_Editar_2.Text = "";
                    TXT_Editar_3.Text = "";
                    
                    Estados_Refresh();
                }
            }
        }
    }
}
