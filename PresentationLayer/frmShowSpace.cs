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
    public partial class frmShowSpace : Form
    {
        public frmShowSpace()
        {
            InitializeComponent();
        }

        private void frmShowSpace_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Selecione a sala desejada para visualizar a lista de participantes.";
            txtSearch.Visible = false;
            btnSearch.Visible = false;
            lblName.Text = "Selecione o tipo de sala para liberar a pesquisa por nome.";
            dataGridView1.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Selecione a sala desejada para visualizar a lista de participantes.";
            listBoxStage1.DataSource = null;
            listBoxStage2.DataSource = null;
            lblName.Text = "Nome:";

            txtSearch.Visible = true;
            btnSearch.Visible = true;

            if (cboxFilter.Text == "Treinamento")
            {
                lblStage1.Text = "Participantes da etapa 1:";
                lblStage2.Text = "Participantes da etapa 2:";
                listBoxStage2.Visible = true;
                lblStage2.Visible = true;
                SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();
                TableResponse r = spaceBLL.GetAllTable();
                dataGridView1.DataSource = r.DataTable;
                dataGridView1.Columns["Nome"].Width = 375;
                dataGridView1.Columns["LotaçãoMáxima"].Visible = false;
            }
            else
            {
                lblStage1.Text = "Participantes da etapa 1 e 2:";
                listBoxStage2.Visible = false;
                lblStage2.Visible = false;
                SpaceCoffeeBLL spaceBLL = new SpaceCoffeeBLL();
                TableResponse r = spaceBLL.GetAllTable();
                dataGridView1.DataSource = r.DataTable;
                dataGridView1.Columns["Nome"].Width = 375;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cboxFilter.Text == "Treinamento")
            {
                //chamar método para pegar o ID da sala: id
                SpaceTraining space = new SpaceTraining();
                space.Name = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                space.MaxCapacity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["LotaçãoMáxima"].Value.ToString());
                SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();
                SingleResponse<SpaceTraining> r = spaceBLL.Get(space);
                SpaceTraining newSpace = r.Data;

                //chamar método para apresentar participantes da etapa 1 e 2
                PersonBLL personBLL = new PersonBLL();
                TableResponse r1 = personBLL.GetAllByStage1ID(newSpace);
                TableResponse r2 = personBLL.GetAllByStage2ID(newSpace);


                //list1: 
                listBoxStage1.DataSource = null;
                listBoxStage1.DataSource = r1.DataTable;
                listBoxStage1.DisplayMember = "Nome";
                //list2: 
                listBoxStage2.DataSource = null;
                listBoxStage2.DataSource = r2.DataTable;
                listBoxStage2.DisplayMember = "Nome";

                lblTitle.Text = "Mostrando participantes da sala de treinamento: " + space.Name;
            }
            else
            {
                //chamar método para pegar o ID do espaço de café: id
                SpaceCoffee space = new SpaceCoffee();
                space.Name = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                SpaceCoffeeBLL spaceBLL = new SpaceCoffeeBLL();
                SingleResponse<SpaceCoffee> r = spaceBLL.Get(space);
                SpaceCoffee newSpace = r.Data;

                //chamar método para apresentar participantes do intervalo para café
                PersonBLL personBLL = new PersonBLL();
                TableResponse r1 = personBLL.GetAllByCoffeeID(newSpace);

                //list1: select * from persons where coffeeid1 = id
                listBoxStage1.DataSource = null;
                listBoxStage1.DataSource = r1.DataTable;
                listBoxStage1.DisplayMember = "Nome";
                lblTitle.Text = "Mostrando participantes do espaço para café: " + space.Name;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxStage1.DataSource = null;
            listBoxStage2.DataSource = null;
            if (cboxFilter.Text == "Treinamento")
            {
                SpaceTraining space = new SpaceTraining();
                space.Name = txtSearch.Text;
                SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();
                TableResponse r = spaceBLL.GetByName(space);
                dataGridView1.DataSource = r.DataTable;
            }
            else
            {
                SpaceCoffee space = new SpaceCoffee();
                space.Name = txtSearch.Text;
                SpaceCoffeeBLL spaceBLL = new SpaceCoffeeBLL();
                TableResponse r = spaceBLL.GetByName(space);
                dataGridView1.DataSource = r.DataTable;
            }
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboxFilter.Text == "Treinamento" || cboxFilter.Text == "Café")
            {
                btnSearch.Enabled = true;
            }
        }

      
    }
}
