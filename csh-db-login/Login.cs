using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace csh_db_login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            string path = @"PlanoAdicional.txt";

            if (!File.Exists(path))
                File.Create(path).Close();
        }


        private void btregistar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo r = new Registo();
            r.Show();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(str);
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT COUNT (*) FROM Login WHERE username='" + txtuser.Text + "' AND pass='" + txtpass.Text + "'", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main m = new Main();
                    m.Show();
                }
                else
                    MessageBox.Show("User/Password inválido!");
            }catch(Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }


    }
}
