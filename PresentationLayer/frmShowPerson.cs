using BusinessLogicalLayer;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmShowPerson : Form
    {
        public frmShowPerson()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FullName = txtName.Text;

            PersonBLL personBLL = new PersonBLL();
            TableResponse r = personBLL.GetByNameViewModel(person);
            dataGridView.DataSource = r.DataTable;
            dataGridView.Columns["Participante"].Width = 350;
            dataGridView.Columns["SalaUm"].Width = 180;
            dataGridView.Columns["SalaDois"].Width = 180;
            dataGridView.Columns["Café"].Width = 180;
            txtName.Clear();
            txtName.Focus();
        }

        private void frmShowPerson_Load(object sender, EventArgs e)
        {
            PersonBLL personBLL = new PersonBLL();
            TableResponse tableResponse = personBLL.GetViewModel();
            dataGridView.DataSource = tableResponse.DataTable;
            dataGridView.Columns["Participante"].Width = 350;
            dataGridView.Columns["SalaUm"].Width = 180;
            dataGridView.Columns["SalaDois"].Width = 180;
            dataGridView.Columns["Café"].Width = 180;
        }

        

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PersonBLL personBLL = new PersonBLL();
            TableResponse tableResponse = personBLL.GetViewModel();
            dataGridView.DataSource = tableResponse.DataTable;
            dataGridView.Columns["Participante"].Width = 350;
            dataGridView.Columns["SalaUm"].Width = 180;
            dataGridView.Columns["SalaDois"].Width = 180;
            dataGridView.Columns["Café"].Width = 180;

        }
    }
}
