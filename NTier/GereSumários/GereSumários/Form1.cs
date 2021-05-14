using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace GereSumários
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            //this.professoresTableAdapter.Fill(this.sumariosDataSet.Professores);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString))
            {
                if (comboBox1.SelectedValue!=null && Seguranca.UserAccess(2))        //Validações
                {
                    string query = @"select * from Sumarios where sigla_p like @prof";

                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);        //acede a dados da BD
                    //Instanciar parâmetros
                    da.SelectCommand.Parameters.Add("@prof", OleDbType.VarChar).Value = comboBox1.SelectedValue;

                    da.Fill(ds, "Sumarios");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Sumarios";                          //mostra dados na DataGrid
                    conn.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void professoresBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
