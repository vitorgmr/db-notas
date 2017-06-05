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
    public partial class PlanoAdicional : Form
    {

        public PlanoAdicional()
        {
            InitializeComponent();
            lerfich();
            double soma;
            soma = calcMedia();

        }
        string path = @"PlanoAdicional.txt";

        public List<string> planoad = new List<string>();

        private void lerfich()
        {
            StreamReader r = new StreamReader(path);
            while (!r.EndOfStream)
            {
                planoad.Add(r.ReadLine());
            }
            r.Close();
        }

        private void escreverFich()
        {
            StreamWriter w = new StreamWriter(path, false);
            foreach (string s in planoad)
            {
                w.WriteLine(s);
            }
            w.Close();
        }

        public double calcMedia()
        {
            int aic;
            int.TryParse((txtAIC.Text), out aic);
            int dp;
            int.TryParse((txtDP.Text), out dp);
            int soic;
            int.TryParse((txtSOIC.Text), out soic);
            int lic;
            int.TryParse((txtLIC.Text), out lic);
            int tr;
            int.TryParse((txtTR.Text), out tr);
            int pric;
            int.TryParse((txtPRIC.Text), out pric);
            int alg;
            int.TryParse((txtALG.Text), out alg);
            int flj;
            int.TryParse((txtFLJ.Text), out flj);
            int asi;
            int.TryParse((txtASI.Text), out asi);
            double media = 0;
            media = (aic + dp + soic + lic + tr + pric + alg + flj + asi)/9;
            return media;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int aic;
            int.TryParse((txtAIC.Text), out aic);
            int dp;
            int.TryParse((txtDP.Text), out dp);
            int soic;
            int.TryParse((txtSOIC.Text), out soic);
            int lic;
            int.TryParse((txtLIC.Text), out lic);
            int tr;
            int.TryParse((txtTR.Text), out tr);
            int pric;
            int.TryParse((txtPRIC.Text), out pric);
            int alg;
            int.TryParse((txtALG.Text), out alg);
            int flj;
            int.TryParse((txtFLJ.Text), out flj);
            int asi;
            int.TryParse((txtASI.Text), out asi);
            double media;
            double.TryParse((lbMedia.Text), out media);
            planoad.Add(aic.ToString());
            escreverFich();
            this.Hide();
            Main m = new Main();
            m.Show();
        }


    }
}
