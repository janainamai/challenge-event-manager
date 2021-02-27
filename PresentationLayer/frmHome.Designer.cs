
namespace PresentationLayer
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblversion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.btnInsertPerson = new System.Windows.Forms.Button();
            this.btnInsertTrainingSpace = new System.Windows.Forms.Button();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInsertCoffeeSpace = new System.Windows.Forms.Button();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblversion
            // 
            this.lblversion.BackColor = System.Drawing.Color.Transparent;
            this.lblversion.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.lblversion.ForeColor = System.Drawing.Color.Black;
            this.lblversion.Location = new System.Drawing.Point(455, 512);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(119, 25);
            this.lblversion.TabIndex = 14;
            this.lblversion.Text = "version";
            this.lblversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEventoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 26);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criarEventoToolStripMenuItem
            // 
            this.criarEventoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.criarEventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoEventoToolStripMenuItem});
            this.criarEventoToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarEventoToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.criarEventoToolStripMenuItem.Name = "criarEventoToolStripMenuItem";
            this.criarEventoToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.criarEventoToolStripMenuItem.Text = "EVENTO";
            // 
            // novoEventoToolStripMenuItem
            // 
            this.novoEventoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.novoEventoToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.novoEventoToolStripMenuItem.Name = "novoEventoToolStripMenuItem";
            this.novoEventoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.novoEventoToolStripMenuItem.Text = "Novo evento";
            this.novoEventoToolStripMenuItem.Click += new System.EventHandler(this.novoEventoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.salasToolStripMenuItem});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.consultaToolStripMenuItem.Text = "CONSULTA";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.pessoasToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.salasToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salasToolStripMenuItem.Text = "Salas";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Purple;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(461, 477);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.Purple;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(461, 392);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(109, 34);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Finalizar";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblOne
            // 
            this.lblOne.BackColor = System.Drawing.Color.Transparent;
            this.lblOne.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.lblOne.ForeColor = System.Drawing.Color.Black;
            this.lblOne.Location = new System.Drawing.Point(352, 79);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(326, 23);
            this.lblOne.TabIndex = 10;
            this.lblOne.Text = "1. Iniciar evento cadastrando todos os participantes.";
            this.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInsertPerson
            // 
            this.btnInsertPerson.BackColor = System.Drawing.Color.Purple;
            this.btnInsertPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPerson.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnInsertPerson.ForeColor = System.Drawing.Color.White;
            this.btnInsertPerson.Location = new System.Drawing.Point(401, 105);
            this.btnInsertPerson.Name = "btnInsertPerson";
            this.btnInsertPerson.Size = new System.Drawing.Size(109, 34);
            this.btnInsertPerson.TabIndex = 0;
            this.btnInsertPerson.Text = "Cadastrar";
            this.btnInsertPerson.UseVisualStyleBackColor = false;
            this.btnInsertPerson.Click += new System.EventHandler(this.btnInsertPerson_Click);
            // 
            // btnInsertTrainingSpace
            // 
            this.btnInsertTrainingSpace.BackColor = System.Drawing.Color.Purple;
            this.btnInsertTrainingSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertTrainingSpace.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnInsertTrainingSpace.ForeColor = System.Drawing.Color.White;
            this.btnInsertTrainingSpace.Location = new System.Drawing.Point(401, 200);
            this.btnInsertTrainingSpace.Name = "btnInsertTrainingSpace";
            this.btnInsertTrainingSpace.Size = new System.Drawing.Size(109, 34);
            this.btnInsertTrainingSpace.TabIndex = 2;
            this.btnInsertTrainingSpace.Text = "Cadastrar";
            this.btnInsertTrainingSpace.UseVisualStyleBackColor = false;
            this.btnInsertTrainingSpace.Click += new System.EventHandler(this.btnInsertTrainingSpace_Click);
            // 
            // lblTwo
            // 
            this.lblTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblTwo.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.lblTwo.ForeColor = System.Drawing.Color.Black;
            this.lblTwo.Location = new System.Drawing.Point(407, 176);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(217, 21);
            this.lblTwo.TabIndex = 11;
            this.lblTwo.Text = "2. Cadastrar salas de treinamento.";
            this.lblTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 15.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(240, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(551, 102);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "SIGA O PASSO A PASSO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInsertCoffeeSpace
            // 
            this.btnInsertCoffeeSpace.BackColor = System.Drawing.Color.Purple;
            this.btnInsertCoffeeSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertCoffeeSpace.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnInsertCoffeeSpace.ForeColor = System.Drawing.Color.White;
            this.btnInsertCoffeeSpace.Location = new System.Drawing.Point(401, 296);
            this.btnInsertCoffeeSpace.Name = "btnInsertCoffeeSpace";
            this.btnInsertCoffeeSpace.Size = new System.Drawing.Size(109, 34);
            this.btnInsertCoffeeSpace.TabIndex = 4;
            this.btnInsertCoffeeSpace.Text = "Cadastrar";
            this.btnInsertCoffeeSpace.UseVisualStyleBackColor = false;
            this.btnInsertCoffeeSpace.Click += new System.EventHandler(this.btnInsertCoffeeSpace_Click);
            // 
            // lblThree
            // 
            this.lblThree.BackColor = System.Drawing.Color.Transparent;
            this.lblThree.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.lblThree.ForeColor = System.Drawing.Color.Black;
            this.lblThree.Location = new System.Drawing.Point(389, 272);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(252, 21);
            this.lblThree.TabIndex = 12;
            this.lblThree.Text = "3. Cadastrar salas de intervalo para café.";
            this.lblThree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFour
            // 
            this.lblFour.BackColor = System.Drawing.Color.Transparent;
            this.lblFour.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.lblFour.ForeColor = System.Drawing.Color.Black;
            this.lblFour.Location = new System.Drawing.Point(381, 368);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(269, 21);
            this.lblFour.TabIndex = 13;
            this.lblFour.Text = "4. Finalizar cadastro para gerenciar evento.";
            this.lblFour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext3
            // 
            this.btnNext3.BackColor = System.Drawing.Color.Purple;
            this.btnNext3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext3.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnNext3.ForeColor = System.Drawing.Color.White;
            this.btnNext3.Location = new System.Drawing.Point(520, 296);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(109, 34);
            this.btnNext3.TabIndex = 5;
            this.btnNext3.Text = "Próximo passo";
            this.btnNext3.UseVisualStyleBackColor = false;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.BackColor = System.Drawing.Color.Purple;
            this.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext2.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnNext2.ForeColor = System.Drawing.Color.White;
            this.btnNext2.Location = new System.Drawing.Point(520, 200);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(109, 34);
            this.btnNext2.TabIndex = 3;
            this.btnNext2.Text = "Próximo passo";
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.Color.Purple;
            this.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext1.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnNext1.ForeColor = System.Drawing.Color.White;
            this.btnNext1.Location = new System.Drawing.Point(520, 105);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(109, 34);
            this.btnNext1.TabIndex = 1;
            this.btnNext1.Text = "Próximo passo";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 540);
            this.ControlBox = false;
            this.Controls.Add(this.btnNext3);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.btnInsertCoffeeSpace);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.btnInsertTrainingSpace);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.btnInsertPerson);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Manager - Seja bem vindo(a)!";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criarEventoToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ToolStripMenuItem novoEventoToolStripMenuItem;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Button btnInsertPerson;
        private System.Windows.Forms.Button btnInsertTrainingSpace;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInsertCoffeeSpace;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}