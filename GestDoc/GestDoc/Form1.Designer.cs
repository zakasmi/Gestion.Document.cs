namespace GestDoc
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_CodeTheme = new System.Windows.Forms.ComboBox();
            this.CB_login = new System.Windows.Forms.ComboBox();
            this.TB_CodeDoc = new System.Windows.Forms.TextBox();
            this.TB_Desc_Doc = new System.Windows.Forms.TextBox();
            this.TB_CheminDoc = new System.Windows.Forms.TextBox();
            this.DTP_DateDoc = new System.Windows.Forms.DateTimePicker();
            this.TB_EtatDoc = new System.Windows.Forms.TextBox();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_debut = new System.Windows.Forms.Button();
            this.BTN_precedent = new System.Windows.Forms.Button();
            this.BTN_fin = new System.Windows.Forms.Button();
            this.BTN_suivant = new System.Windows.Forms.Button();
            this.LBL_Theme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Theme ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Code Doc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description Doc";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chemin Doc";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date Doc";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Etat Doc";
            // 
            // CB_CodeTheme
            // 
            this.CB_CodeTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_CodeTheme.FormattingEnabled = true;
            this.CB_CodeTheme.Location = new System.Drawing.Point(182, 49);
            this.CB_CodeTheme.Name = "CB_CodeTheme";
            this.CB_CodeTheme.Size = new System.Drawing.Size(121, 21);
            this.CB_CodeTheme.TabIndex = 2;
            // 
            // CB_login
            // 
            this.CB_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_login.FormattingEnabled = true;
            this.CB_login.Location = new System.Drawing.Point(518, 51);
            this.CB_login.Name = "CB_login";
            this.CB_login.Size = new System.Drawing.Size(121, 21);
            this.CB_login.TabIndex = 2;
            // 
            // TB_CodeDoc
            // 
            this.TB_CodeDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_CodeDoc.Location = new System.Drawing.Point(182, 101);
            this.TB_CodeDoc.Name = "TB_CodeDoc";
            this.TB_CodeDoc.Size = new System.Drawing.Size(121, 20);
            this.TB_CodeDoc.TabIndex = 3;
            // 
            // TB_Desc_Doc
            // 
            this.TB_Desc_Doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Desc_Doc.Location = new System.Drawing.Point(182, 150);
            this.TB_Desc_Doc.Name = "TB_Desc_Doc";
            this.TB_Desc_Doc.Size = new System.Drawing.Size(121, 20);
            this.TB_Desc_Doc.TabIndex = 3;
            // 
            // TB_CheminDoc
            // 
            this.TB_CheminDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_CheminDoc.Location = new System.Drawing.Point(182, 199);
            this.TB_CheminDoc.Name = "TB_CheminDoc";
            this.TB_CheminDoc.Size = new System.Drawing.Size(121, 20);
            this.TB_CheminDoc.TabIndex = 3;
            // 
            // DTP_DateDoc
            // 
            this.DTP_DateDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTP_DateDoc.Location = new System.Drawing.Point(518, 98);
            this.DTP_DateDoc.Name = "DTP_DateDoc";
            this.DTP_DateDoc.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateDoc.TabIndex = 4;
            // 
            // TB_EtatDoc
            // 
            this.TB_EtatDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_EtatDoc.Location = new System.Drawing.Point(518, 143);
            this.TB_EtatDoc.Name = "TB_EtatDoc";
            this.TB_EtatDoc.Size = new System.Drawing.Size(121, 20);
            this.TB_EtatDoc.TabIndex = 3;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Ajouter.Location = new System.Drawing.Point(179, 281);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(91, 23);
            this.BTN_Ajouter.TabIndex = 5;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Modifier.Location = new System.Drawing.Point(347, 281);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(91, 23);
            this.BTN_Modifier.TabIndex = 5;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Supprimer.Location = new System.Drawing.Point(515, 281);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(91, 23);
            this.BTN_Supprimer.TabIndex = 5;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_debut
            // 
            this.BTN_debut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_debut.Location = new System.Drawing.Point(17, 281);
            this.BTN_debut.Name = "BTN_debut";
            this.BTN_debut.Size = new System.Drawing.Size(36, 23);
            this.BTN_debut.TabIndex = 5;
            this.BTN_debut.Text = "<<";
            this.BTN_debut.UseVisualStyleBackColor = true;
            this.BTN_debut.Click += new System.EventHandler(this.BTN_debut_Click);
            // 
            // BTN_precedent
            // 
            this.BTN_precedent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_precedent.Location = new System.Drawing.Point(66, 281);
            this.BTN_precedent.Name = "BTN_precedent";
            this.BTN_precedent.Size = new System.Drawing.Size(36, 23);
            this.BTN_precedent.TabIndex = 5;
            this.BTN_precedent.Text = "<";
            this.BTN_precedent.UseVisualStyleBackColor = true;
            this.BTN_precedent.Click += new System.EventHandler(this.BTN_precedent_Click);
            // 
            // BTN_fin
            // 
            this.BTN_fin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_fin.Location = new System.Drawing.Point(721, 281);
            this.BTN_fin.Name = "BTN_fin";
            this.BTN_fin.Size = new System.Drawing.Size(36, 23);
            this.BTN_fin.TabIndex = 5;
            this.BTN_fin.Text = ">>";
            this.BTN_fin.UseVisualStyleBackColor = true;
            this.BTN_fin.Click += new System.EventHandler(this.BTN_fin_Click);
            // 
            // BTN_suivant
            // 
            this.BTN_suivant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_suivant.Location = new System.Drawing.Point(672, 281);
            this.BTN_suivant.Name = "BTN_suivant";
            this.BTN_suivant.Size = new System.Drawing.Size(36, 23);
            this.BTN_suivant.TabIndex = 5;
            this.BTN_suivant.Text = ">";
            this.BTN_suivant.UseVisualStyleBackColor = true;
            this.BTN_suivant.Click += new System.EventHandler(this.BTN_suivant_Click);
            // 
            // LBL_Theme
            // 
            this.LBL_Theme.AutoSize = true;
            this.LBL_Theme.Location = new System.Drawing.Point(37, 9);
            this.LBL_Theme.Name = "LBL_Theme";
            this.LBL_Theme.Size = new System.Drawing.Size(55, 13);
            this.LBL_Theme.TabIndex = 6;
            this.LBL_Theme.Text = "Theme >>";
            this.LBL_Theme.Click += new System.EventHandler(this.LBL_Theme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 351);
            this.Controls.Add(this.LBL_Theme);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_fin);
            this.Controls.Add(this.BTN_precedent);
            this.Controls.Add(this.BTN_suivant);
            this.Controls.Add(this.BTN_debut);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DTP_DateDoc);
            this.Controls.Add(this.TB_EtatDoc);
            this.Controls.Add(this.TB_CheminDoc);
            this.Controls.Add(this.TB_Desc_Doc);
            this.Controls.Add(this.TB_CodeDoc);
            this.Controls.Add(this.CB_login);
            this.Controls.Add(this.CB_CodeTheme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_CodeTheme;
        private System.Windows.Forms.ComboBox CB_login;
        private System.Windows.Forms.TextBox TB_CodeDoc;
        private System.Windows.Forms.TextBox TB_Desc_Doc;
        private System.Windows.Forms.TextBox TB_CheminDoc;
        private System.Windows.Forms.DateTimePicker DTP_DateDoc;
        private System.Windows.Forms.TextBox TB_EtatDoc;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_debut;
        private System.Windows.Forms.Button BTN_precedent;
        private System.Windows.Forms.Button BTN_fin;
        private System.Windows.Forms.Button BTN_suivant;
        private System.Windows.Forms.Label LBL_Theme;
    }
}

