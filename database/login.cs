using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace database
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29163\Documents\sanguosha.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");


        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string idshow = "", nameshow = "", levelshow = "";
        private void denglu_Click(object sender, EventArgs e)
        {

            Con.Open();

            string idtext = id.Text.ToString();
            string passwordtext = password.Text.ToString();

            string query1 = "select count(*) from user_designer where uid = N'" + idtext + "' and password = N'" + passwordtext + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            string query2 = "select count(*) from user_player where pid = N'" + idtext + "' and password = N'" + passwordtext + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            

            if (dt1.Rows[0][0].ToString() == "1")
            {
                characters character = new characters();
                character.Show();
                this.Hide();
                
                Con.Close();
            }
            else if(dt2.Rows[0][0].ToString() == "1")
            {

                string query3 = "select * from user_player where pid = N'" + idtext + "' and password = N'" + passwordtext + "'";
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, Con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                idshow = dt3.Rows[0][0].ToString();
                nameshow = dt3.Rows[0][1].ToString();
                levelshow = dt3.Rows[0][2].ToString();

                player playwindow = new player();
                playwindow.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }


           
            Con.Close();

        }
    }
}
