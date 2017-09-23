using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace GestDoc
{
    public partial class Form1 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DELL;Initial Catalog=GestDoc;Integrated Security=True");
        SqlDataReader dr;
        int pos = 0;

        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //------- remplir CB_CodeTheme -----------------
            try {
                SqlCommand cmd = new SqlCommand("select code_theme from Theme",cnx);
                cnx.Open();
                dr=cmd.ExecuteReader();
                while(dr.Read()){

                    CB_CodeTheme.Items.Add(dr[0]);
               
                }
                cnx.Close();
          
            }
            catch (Exception e1) { MessageBox.Show(""+e1.Message); }
            finally { cnx.Close(); }
            //----------- remplir CB_login ---------------------
            try
            {
                SqlCommand cmd = new SqlCommand("select [login] from Membre", cnx);
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    CB_login.Items.Add(dr[0]);

                }
                cnx.Close();

            }
            catch (Exception e1) { MessageBox.Show("" + e1.Message); }
            finally { cnx.Close(); }
            //------------ remplir les controls -----------
            BTN_debut_Click(sender, e);

            

        }
        //////////////////// Ajouter Document ////////////////////////////
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Document values ('"+TB_CodeDoc.Text+"','"+TB_Desc_Doc.Text+"','"+TB_CheminDoc.Text+"','"+DTP_DateDoc.Value+"',"+TB_EtatDoc.Text+",'"+CB_CodeTheme.SelectedItem+"','"+CB_login.SelectedItem+"')", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
              
                cnx.Close();
                MessageBox.Show("Ajoute est reussie ","Ajouter");

            }
            catch (Exception e1) { MessageBox.Show("" + e1.Message); }
            finally { cnx.Close(); }
        }
        //////////////////// Supprimer Document ////////////////////////////

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
             try
            {
                SqlCommand cmd = new SqlCommand("Delete from  Document where  code_doc='"+TB_CodeDoc.Text+"'", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
              
                cnx.Close();
                BTN_precedent_Click(sender, e);
                MessageBox.Show("Suppression  reussie ","Supprimer");

            }
            catch (Exception e1) { MessageBox.Show("" + e1.Message); }
            finally { cnx.Close(); }
        
        }
        //////////////////// Modifier Document ////////////////////////////

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update  Document set description_doc='" + TB_Desc_Doc.Text + "',chemin_doc='" + TB_CheminDoc.Text + "',date_doc='" + DTP_DateDoc.Value + "',etat_doc=" + TB_EtatDoc.Text + ",code_theme='" + CB_CodeTheme.SelectedItem + "',[login]='" + CB_login.SelectedItem + "' where code_doc ='" + TB_CodeDoc.Text + "' ", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();

                cnx.Close();
                MessageBox.Show("Modification est reussie ", "Modifier");

            }
            catch (Exception e1) { MessageBox.Show("" + e1.Message); }
            finally { cnx.Close(); }
        }
        //////////////////// Buttons de navigation ////////////////////////////
        //----------------------------- Debut----------------------------- 
        private void BTN_debut_Click(object sender, EventArgs e)
        {
            pos = 0;
            bouge(0);
        }
        //----------------------------- Fin----------------------------- 
        private void BTN_fin_Click(object sender, EventArgs e)
        {
            pos = rowcount() - 1;
            bouge(pos);
        }
        //----------------------------- Precedent----------------------------- 
        private void BTN_precedent_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos -= 1;
                bouge(pos);
            }
            else MessageBox.Show("Fin de list ", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        
        }
        //----------------------------- suivant ----------------------------- 
        private void BTN_suivant_Click(object sender, EventArgs e)
        {
            if (pos < rowcount()-1)
            {
                pos += 1;
                bouge(pos);
            }
            else MessageBox.Show("Fin de list ", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        
        }

        //////////////////// Remplir Document ////////////////////////////
        public void remplir() {

            TB_CodeDoc.Text = dr[0].ToString();
            TB_Desc_Doc.Text = dr[1].ToString();
            TB_CheminDoc.Text = dr[2].ToString();
            DTP_DateDoc.Value = DateTime.Parse(dr[3].ToString());
            TB_EtatDoc.Text = dr[4].ToString();
            CB_CodeTheme.Text = dr[5].ToString();
            CB_login.Text = dr[6].ToString();

        }
        //////////////////// bouge Document ////////////////////////////
        public void bouge(int i) { 
        int x=0;
        try { 
       SqlCommand cmd = new SqlCommand("select *from Document",cnx);
               cnx.Open();
               dr=cmd.ExecuteReader();
               for (x = 0; x <= i;x++)
               {
                   dr.Read();

               }
               remplir();
               cnx.Close();
        }
           catch (Exception e1) { MessageBox.Show(""+e1.Message); }
        finally { cnx.Close(); }
        
        
        }

        //////////////////////////////// Count The number of rows //////////////////////////////// 
        public int rowcount() {
            int k = 0;
            try
            {
               
                SqlCommand cmd = new SqlCommand("select count(*) from Document", cnx);
                cnx.Open();
            k = int.Parse(cmd.ExecuteScalar().ToString());
            if (k <= 0) { MessageBox.Show("La Base De données est Vide "); }
            
                cnx.Close();
                
            }
            catch (Exception e1) { MessageBox.Show("" + e1.Message); }
            finally { cnx.Close();
           
            }

            return k;  
        }

        private void LBL_Theme_Click(object sender, EventArgs e)
        {
            DocBloque D1 = new DocBloque();
            D1.Show();
            this.Hide();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  System.Windows.Forms.Application.Exit();
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

   
      



       
    }

    /*try { 
     *  SqlCommand cmd = new SqlCommand("select code_theme from Theme",cnx);
               cnx.Open();
               dr=cmd.ExecuteReader();
               while(dr.Read()){

                   CB_CodeTheme.Items.Add(dr[0]);
               
               }
               cnx.Close();}
           catch (Exception e1) { MessageBox.Show(""+e1.Message); }
           finally{}*/
}
