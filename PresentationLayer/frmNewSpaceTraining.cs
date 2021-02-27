using BusinessLogicalLayer;
using Common;
using Entities;
using Entities.Helper;
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
    public partial class frmNewSpaceTraining : Form
    {
        public frmNewSpaceTraining()
        {
            InitializeComponent();
        }

        private void frmNewSpaceTraining_Load(object sender, EventArgs e)
        {
            PersonBLL personBLL = new PersonBLL();
            QueryResponse<Person> r0 = personBLL.GetAllList();
            int maxCapacity = r0.Data.Count / 2;

            lblTitle.Text = "Informe a sala que tem a menor capacidade máxima, pois a partir dela nós facilitaremos o processo de cadastro de salas para você.\n\nA capacidade máxima não pode ser maior que: " + maxCapacity + ". \n\nIsso garante que o evento será gerenciado com 100% de sucesso.";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtMaxCapacity.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                txtName.Clear();
                txtMaxCapacity.Clear();
                txtName.Focus();
            }
            else
            {
                SpaceTraining space = new SpaceTraining();
                space.Name = txtName.Text;
                space.MaxCapacity = Convert.ToInt32(txtMaxCapacity.Text);

                SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();
                spaceBLL.Insert(space);

                SingleResponse<Operator> r0 = spaceBLL.CheckHowToCreate(space);

                if (r0.Success)
                {
                    Operator op = r0.Data;
                    if (op.IsAllFull)
                    {
                        int totalSpaces = op.TotalSpaceFull - 1;
                        int maxCapacity = op.PersonsPerFullRoom;

                        if (MessageBox.Show(lblTitle.Text = "Serão cadastradas " + op.TotalSpaceFull + " salas.\n\nCada sala terá uma capacidade para " + op.PersonsPerFullRoom + " pessoas.\n\nSe deseja prosseguir clique em sim, mas se deseja informar outra sala para melhorar a distribuição, clique em não.", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //chamar a tela de cadastro das salas restantes, conforme totalSpaces
                            for (int i = 1; i <= totalSpaces; i++)
                            {
                                frmNewSpaceTraining2 f = new frmNewSpaceTraining2(maxCapacity);
                                f.ShowDialog();
                            }

                            MessageBox.Show("Salas cadastradas com sucesso, siga para o próximo passo.");
                            this.Close();
                        }
                        else
                        {
                            spaceBLL.DeleteAll();
                            txtName.Clear();
                            txtMaxCapacity.Clear();
                            txtName.Focus();
                            return;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(lblTitle.Text = "Haverá um total de " + (op.TotalSpaceFull + op.TotalSpaceNotFull) + " salas.\n\n" + op.TotalSpaceFull + " salas com capacidade para " + op.PersonsPerFullRoom + " pessoas.\n\n" + op.TotalSpaceNotFull + " salas com capacidade para " + op.PersonsPerNotFullRoom + " pessoas.\n\nSe deseja prosseguir clique em sim, mas se deseja informar outra sala para melhorar a distribuição, clique em não", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            int totalSpaceFull = op.TotalSpaceFull;
                            int maxCapacityFull = op.PersonsPerFullRoom;
                            //chamar a tela de cadastro das salas cheias
                            for (int i = 1; i < totalSpaceFull; i++)
                            {
                                frmNewSpaceTraining2 f = new frmNewSpaceTraining2(maxCapacityFull);
                                f.ShowDialog();
                            }

                            int totalSpaceNotFull = op.TotalSpaceNotFull;
                            int maxCapacityNotFull = op.PersonsPerNotFullRoom;
                            //chamar a tela de cadastro das salas não cheias
                            for (int i = 1; i <= totalSpaceNotFull; i++)
                            {
                                frmNewSpaceTraining2 f = new frmNewSpaceTraining2(maxCapacityNotFull);
                                f.ShowDialog();
                            }

                            MessageBox.Show("Salas cadastradas com sucesso, siga para o próximo passo.");
                            this.Close();
                        }
                        else
                        {
                            spaceBLL.DeleteAll();
                            txtName.Clear();
                            txtMaxCapacity.Clear();
                            txtName.Focus();
                            return;
                        }
                    }
                }
                else
                    MessageBox.Show("Erro, contate o administrador.");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != null)
                btnInsert.Enabled = true;
        }
    }
}
