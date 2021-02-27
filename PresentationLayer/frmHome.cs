using BusinessLogicalLayer;
using BusinessLogicalLayer.Helper;
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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblversion.Text = "v.1.0.0";

            //verificar se existe um evento em andamento
            int aux;
            PersonBLL personBLL = new PersonBLL();
            QueryResponse<Person> r1 = personBLL.GetAllList();
            if(r1.Data.Count != 0)
            {
                List<Person> listPerson = r1.Data;
                foreach (Person person in listPerson)
                {
                   if(person.CoffeeID == null)
                    {
                        lblTwo.Visible = false;
                        lblThree.Visible = false;
                        lblFour.Visible = false;
                        btnInsertTrainingSpace.Visible = false;
                        btnInsertCoffeeSpace.Visible = false;
                        btnExecute.Visible = false;
                        btnNext1.Visible = false;
                        btnNext2.Visible = false;
                        btnNext3.Visible = false;

                        consultaToolStripMenuItem.Visible = false;
                    }
                   else
                    {
                        lblTwo.Visible = false;
                        lblThree.Visible = false;
                        lblFour.Visible = false;
                        btnInsertTrainingSpace.Visible = false;
                        btnInsertCoffeeSpace.Visible = false;
                        btnExecute.Visible = false;
                        btnNext1.Visible = false;
                        btnNext2.Visible = false;
                        btnNext3.Visible = false;
                        lblOne.Visible = false;
                        btnNext1.Visible = false;
                        btnInsertPerson.Visible = false;

                        lblTitle.Text = "Evento em andamento, para iniciar novo evento vá para o menu EVENTO > NOVO EVENTO.";
                    }
                }
            }


               
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void novoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Criar um novo evento apagará todos os registros de pessoas e salas. Deseja continuar?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            else
            {
                SpaceTrainingBLL spaceTBLL = new SpaceTrainingBLL();
                SpaceCoffeeBLL spaceCBLL = new SpaceCoffeeBLL();
                PersonBLL personBLL = new PersonBLL();
                Response r1 = spaceTBLL.DeleteAll();
                Response r2 = personBLL.DeleteAll();
                Response r3 = spaceCBLL.DeleteAll();

                lblTwo.Visible = false;
                lblThree.Visible = false;
                lblFour.Visible = false;
                btnInsertTrainingSpace.Visible = false;
                btnInsertCoffeeSpace.Visible = false;
                btnExecute.Visible = false;
                btnNext1.Visible = false;
                btnNext2.Visible = false;
                btnNext3.Visible = false;

                consultaToolStripMenuItem.Visible = false;

                lblTitle.Text = "SIGA O PASSO A PASSO";
                lblOne.Visible = true;
                btnInsertPerson.Visible = true;
                MessageBox.Show(r1.Message);
            }
        }

        private void btnInsertPerson_Click(object sender, EventArgs e)
        {
            frmNewPerson f = new frmNewPerson();
            f.ShowDialog();
            btnNext1.Visible = true;
    }

        private void btnInsertTrainingSpace_Click(object sender, EventArgs e)
        {
            frmNewSpaceTraining f = new frmNewSpaceTraining();
            f.ShowDialog();
            btnNext2.Visible = true;
        }

        private void btnInsertCoffeeSpace_Click(object sender, EventArgs e)
        {
            frmNewSpaceCoffee f = new frmNewSpaceCoffee();
            f.ShowDialog();
            btnNext3.Visible = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            PersonBLL personBLL = new PersonBLL();
            Response r1 = personBLL.OrganizeFirstStage();
            Response r2 = personBLL.OrganizeSecondStage();
            Response r3 = personBLL.OrganizeBreakTime();

            consultaToolStripMenuItem.Visible = true;

            if (r1.Success && r2.Success && r3.Success)
                MessageBox.Show("O evento está pronto para ser realizado. Agora você pode consultar os detalhes do evento na aba CONSULTA que acabou de aparecer no menu.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Erro, contate o administrador.");

            lblTwo.Visible = false;
            lblThree.Visible = false;
            lblFour.Visible = false;
            btnInsertTrainingSpace.Visible = false;
            btnInsertCoffeeSpace.Visible = false;
            btnExecute.Visible = false;
            btnNext1.Visible = false;
            btnNext2.Visible = false;
            btnNext3.Visible = false;
            lblOne.Visible = false;
            btnNext1.Visible = false;
            btnInsertPerson.Visible = false;

            lblTitle.Text = "Evento em andamento, para iniciar novo evento vá para o menu EVENTO > NOVO EVENTO.";
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todos os participantes devem estar cadastrados antes de ir para o próximo passo, deseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            else
            {
                lblTwo.Visible = true;
                btnInsertTrainingSpace.Visible = true;
                btnInsertPerson.Visible = false;
                btnNext1.Visible = false;
                lblOne.Visible = false;
            }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            SpaceTrainingBLL spaceTBLL = new SpaceTrainingBLL();
            QueryResponse<SpaceTraining> response = spaceTBLL.GetAllList();
            if (response.Data.Count == 0)
            {
                MessageBox.Show("Você deve cadastrar as salas de treinamento antes de ir ao próximo passo.");
            }
            else
            {
                lblThree.Visible = true;
                btnInsertCoffeeSpace.Visible = true;
                btnInsertTrainingSpace.Visible = false;
                lblTwo.Visible = false;
                btnNext2.Visible = false;
            }
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            SpaceCoffeeBLL spaceCBLL = new SpaceCoffeeBLL();
            QueryResponse<SpaceCoffee> response = spaceCBLL.GetAllList();
            if (response.Data.Count == 0)
            {
                MessageBox.Show("Você deve cadastrar as salas de treinamento antes de ir ao próximo passo.");
            }
            else
            {
                lblFour.Visible = true;
                btnExecute.Visible = true;
                btnInsertCoffeeSpace.Visible = false;
                lblThree.Visible = false;
                btnNext3.Visible = false;
            }
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPerson f = new frmShowPerson();
            f.ShowDialog();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowSpace f = new frmShowSpace();
            f.ShowDialog();
        }

        
    }
}




