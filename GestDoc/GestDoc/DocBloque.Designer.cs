namespace GestDoc
{
    partial class DocBloque
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
            this.LBL_CodeTheme = new System.Windows.Forms.Label();
            this.CB_CodeTheme = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codedoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_CodeTheme
            // 
            this.LBL_CodeTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CodeTheme.AutoSize = true;
            this.LBL_CodeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CodeTheme.Location = new System.Drawing.Point(262, 43);
            this.LBL_CodeTheme.Name = "LBL_CodeTheme";
            this.LBL_CodeTheme.Size = new System.Drawing.Size(99, 17);
            this.LBL_CodeTheme.TabIndex = 0;
            this.LBL_CodeTheme.Text = "Code Theme";
            // 
            // CB_CodeTheme
            // 
            this.CB_CodeTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_CodeTheme.FormattingEnabled = true;
            this.CB_CodeTheme.Location = new System.Drawing.Point(383, 39);
            this.CB_CodeTheme.Name = "CB_CodeTheme";
            this.CB_CodeTheme.Size = new System.Drawing.Size(173, 21);
            this.CB_CodeTheme.TabIndex = 1;
            this.CB_CodeTheme.SelectedIndexChanged += new System.EventHandler(this.CB_CodeTheme_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codedoc,
            this.descdoc,
            this.date,
            this.nom,
            this.prenom,
            this.Supprimer});
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(811, 254);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codedoc
            // 
            this.codedoc.HeaderText = "Code Document";
            this.codedoc.Name = "codedoc";
            this.codedoc.ReadOnly = true;
            // 
            // descdoc
            // 
            this.descdoc.HeaderText = "Description Doc";
            this.descdoc.Name = "descdoc";
            this.descdoc.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom Membre";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom Membre";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // DocBloque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 368);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_CodeTheme);
            this.Controls.Add(this.LBL_CodeTheme);
            this.Name = "DocBloque";
            this.Text = "DocBloque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocBloque_FormClosing);
            this.Load += new System.EventHandler(this.DocBloque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_CodeTheme;
        private System.Windows.Forms.ComboBox CB_CodeTheme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}