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
    public partial class frmNewPerson : Form
    {
        public frmNewPerson()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                txtName.Clear();
                txtSurname.Clear();
                txtName.Focus();
            }
            else
            {
                Person person = new Person();
                person.Name = txtName.Text;
                person.Surname = txtSurname.Text;
                

                PersonBLL personBLL = new PersonBLL();
                Response response = personBLL.Insert(person);
                MessageBox.Show(response.Message);

                txtName.Clear();
                txtSurname.Clear();
                txtName.Focus();

                TableResponse tableResponse = personBLL.GetNamesOnly();
                dataGridView.DataSource = tableResponse.DataTable;
                dataGridView.Columns["Nome"].Width = 550;

                QueryResponse<Person> r1 = personBLL.GetAllList();
                lblTotalPersons.Text = "Total de pessoas cadastradas: " + r1.Data.Count.ToString();
            }
        }

        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            PersonBLL personBLL = new PersonBLL();
            QueryResponse<Person> r1 = personBLL.GetAllList();
            lblTotalPersons.Text = "Total de pessoas cadastradas: " + r1.Data.Count.ToString();
            TableResponse tableResponse = personBLL.GetNamesOnly();
            dataGridView.DataSource = tableResponse.DataTable;
            dataGridView.Columns["Nome"].Width = 460;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
