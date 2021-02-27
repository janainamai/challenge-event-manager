
namespace PresentationLayer
{
    partial class frmShowSpace
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilterSpace = new System.Windows.Forms.Label();
            this.cboxFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBoxStage1 = new System.Windows.Forms.ListBox();
            this.listBoxStage2 = new System.Windows.Forms.ListBox();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(216, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFilterSpace
            // 
            this.lblFilterSpace.AutoSize = true;
            this.lblFilterSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterSpace.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.lblFilterSpace.ForeColor = System.Drawing.Color.Black;
            this.lblFilterSpace.Location = new System.Drawing.Point(16, 14);
            this.lblFilterSpace.Name = "lblFilterSpace";
            this.lblFilterSpace.Size = new System.Drawing.Size(83, 18);
            this.lblFilterSpace.TabIndex = 7;
            this.lblFilterSpace.Text = "Tipo de sala:";
            // 
            // cboxFilter
            // 
            this.cboxFilter.BackColor = System.Drawing.Color.White;
            this.cboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilter.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.cboxFilter.FormattingEnabled = true;
            this.cboxFilter.Items.AddRange(new object[] {
            "Treinamento",
            "Café"});
            this.cboxFilter.Location = new System.Drawing.Point(18, 35);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Size = new System.Drawing.Size(176, 26);
            this.cboxFilter.TabIndex = 0;
            this.cboxFilter.SelectedIndexChanged += new System.EventHandler(this.cboxFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.txtSearch.Location = new System.Drawing.Point(18, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(16, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 18);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nome:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Purple;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(929, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 15.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(432, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(581, 42);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxStage1
            // 
            this.listBoxStage1.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.listBoxStage1.ForeColor = System.Drawing.Color.Black;
            this.listBoxStage1.FormattingEnabled = true;
            this.listBoxStage1.ItemHeight = 18;
            this.listBoxStage1.Location = new System.Drawing.Point(436, 120);
            this.listBoxStage1.Name = "listBoxStage1";
            this.listBoxStage1.Size = new System.Drawing.Size(282, 346);
            this.listBoxStage1.TabIndex = 5;
            // 
            // listBoxStage2
            // 
            this.listBoxStage2.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.listBoxStage2.ForeColor = System.Drawing.Color.Black;
            this.listBoxStage2.FormattingEnabled = true;
            this.listBoxStage2.ItemHeight = 18;
            this.listBoxStage2.Location = new System.Drawing.Point(735, 120);
            this.listBoxStage2.Name = "listBoxStage2";
            this.listBoxStage2.Size = new System.Drawing.Size(278, 346);
            this.listBoxStage2.TabIndex = 6;
            // 
            // lblStage1
            // 
            this.lblStage1.BackColor = System.Drawing.Color.Transparent;
            this.lblStage1.Font = new System.Drawing.Font("Corbel", 13.25F);
            this.lblStage1.ForeColor = System.Drawing.Color.Black;
            this.lblStage1.Location = new System.Drawing.Point(432, 97);
            this.lblStage1.Name = "lblStage1";
            this.lblStage1.Size = new System.Drawing.Size(282, 20);
            this.lblStage1.TabIndex = 9;
            this.lblStage1.Text = "Participantes da etapa 1";
            this.lblStage1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStage2
            // 
            this.lblStage2.BackColor = System.Drawing.Color.Transparent;
            this.lblStage2.Font = new System.Drawing.Font("Corbel", 13.25F);
            this.lblStage2.ForeColor = System.Drawing.Color.Black;
            this.lblStage2.Location = new System.Drawing.Point(732, 97);
            this.lblStage2.Name = "lblStage2";
            this.lblStage2.Size = new System.Drawing.Size(282, 20);
            this.lblStage2.TabIndex = 10;
            this.lblStage2.Text = "Participantes da etapa 2";
            this.lblStage2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(18, 121);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(398, 345);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmShowSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 540);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblStage2);
            this.Controls.Add(this.lblStage1);
            this.Controls.Add(this.listBoxStage2);
            this.Controls.Add(this.listBoxStage1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboxFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFilterSpace);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar espaços";
            this.Load += new System.EventHandler(this.frmShowSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilterSpace;
        private System.Windows.Forms.ComboBox cboxFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox listBoxStage1;
        private System.Windows.Forms.ListBox listBoxStage2;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}