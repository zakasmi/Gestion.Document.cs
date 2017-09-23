using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GestDoc
{
    public partial class DocBloque : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DELL;Initial Catalog=GestDoc;Integrated Security=True");
        SqlDataReader dr;
        public DocBloque()
        {
            InitializeComponent();
        }
        //////////////////// DocBloque Load  ////////////////////////////
        private void DocBloque_Load(object sender, EventArgs e)
        {
            //---------------------remplir combobox CB_CodeTheme ----------------------
            try
            {
                SqlCommand cmd = new SqlCommand("select code_theme from Theme", cnx);
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_CodeTheme.Items.Add(dr[0]);

                }
                cnx.Close();

            }
            catch (Exception e1) { MessageBox.Show("" + e1.Message); }
            finally { cnx.Close(); }
        }
     //----------------------------------- DocBloque FormClosing -----------------------------------
        private void DocBloque_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }
        // -------------------- 
        private void CB_CodeTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select D.code_doc,D.description_doc,D.date_doc,M.nom,M.prenom from Document D inner join Membre M on D.[login] = M.[login]  where code_theme='"+CB_CodeTheme.SelectedItem+"'", cnx);
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);

                }
                cnx.Close();

            }
            catch (Exception e1) { MessageBox.Show("" + e1.Message); }
            finally { cnx.Close(); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) {

                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from  Document where  code_doc='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();

                    cnx.Close();
                    CB_CodeTheme_SelectedIndexChanged(sender, e);

                }
                catch (Exception e1) { MessageBox.Show("" + e1.Message); }
                finally { cnx.Close(); }
            
            }
        }
    }
}
