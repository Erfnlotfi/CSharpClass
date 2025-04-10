using ApplicationService;
using Model.DomainModel;
using Model.ServiceModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class Form2 : Form
    {
        private readonly PersonService _personService;
        public Form2()
        {
            InitializeComponent();
            _personService = new PersonService();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _personService.GetAll();
            MessageBox.Show("Done!");
        }
    }
}
