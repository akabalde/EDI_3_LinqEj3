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

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var estados =
                from c in db.Estados
                select c;

            dataGridView1.DataSource = estados;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            db.insertarEstados(textBox1.Text);
            
        }
    }
}
