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
    public partial class frmNewSpaceTraining2 : Form
    {
        public frmNewSpaceTraining2(int _maxCapacity)
        {
            InitializeComponent();
            space.MaxCapacity = _maxCapacity;
        }
            SpaceTraining space = new SpaceTraining();

        private void frmSpaceTraining2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Informe o nome da sala e clique em PRÓXIMO.";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            space.Name = txtName.Text;

            SpaceTrainingBLL spaceTrainingBLL = new SpaceTrainingBLL();
            Response r = spaceTrainingBLL.Insert(space);
            MessageBox.Show(r.Message);
            this.Close();
        }
    }
}
