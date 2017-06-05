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

namespace csh_db_login
{
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            Utilizador u = new Utilizador(user, pass);
            try
            {
                string str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand();
                string sql = "insert into " +
                    "Login (username, pass) values ('"
                    + u.getUser() + "','" +
                    u.getPass() + "')";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registo efetuado!");
                this.Hide();
                Login l = new Login();
                l.Show();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
