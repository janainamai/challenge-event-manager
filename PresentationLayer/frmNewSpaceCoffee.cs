using BusinessLogicalLayer;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmNewSpaceCoffee : Form
    {
        public frmNewSpaceCoffee()
        {
            InitializeComponent();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Preencha o nome.");
                txtName.Focus();
            }
            else
            {
                SpaceCoffee space = new SpaceCoffee();
                SpaceCoffeeBLL spaceBLL = new SpaceCoffeeBLL();
                space.Name = txtName.Text;
                Response response = spaceBLL.Insert(space);

                TableResponse tableResponse = spaceBLL.GetAllTable();
                dataGridView.DataSource = tableResponse.DataTable;
                dataGridView.Columns["Nome"].Width = 270;

                MessageBox.Show(response.Message);

                //chamar método que verifica se já tem cadastrado duas salas de café, se já tem, o botão cadastrar ficadesativado
                Response r0 = spaceBLL.ExistTwoSpaces();
                if (r0.Success)
                {
                    btnInsert.Enabled = false;
                    MessageBox.Show("Duas salas de café cadastradas, vá ao próximo passo.");
                    this.Close();
                }
                
                txtName.Focus();
                txtName.Clear();
            }
        }
 
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewSpaceCoffee_Load(object sender, EventArgs e)
        {
            lblTitleSpace.Text = "Salas de intervalo para café:";

            SpaceCoffeeBLL spaceBLL = new SpaceCoffeeBLL();
            TableResponse tableResponse = spaceBLL.GetAllTable();
            if (tableResponse.Success)
            {
                dataGridView.DataSource = tableResponse.DataTable;
                dataGridView.Columns["Nome"].Width = 270;
            }
            Response r0 = spaceBLL.ExistTwoSpaces();
            if (r0.Success)
            {
                btnInsert.Enabled = false;
                MessageBox.Show(r0.Message);
                this.Close();
            }
            else
            {
                MessageBox.Show("Você deve cadastrar dois espaços de intervalo para café informando o nome. Cada espaço irá alocar pelo menos metade das pessoas que participarão do treinamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
