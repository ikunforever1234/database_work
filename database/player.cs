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
    public partial class player : Form
    {

        int index = 0;
        public player()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29163\Documents\sanguosha.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");



        private void populate()
        {
            Con.Open();

            if (index == 1)
            {
                string query =
                    "SELECT cname, cblood, ccountry, cgender, cskill " +
                    "FROM character " +
                    "WHERE cname IN ( " +
                        "SELECT ocname " +
                                "FROM dbo.owncharacter " +
                        "WHERE opid = " + pid.Text +
                    " );";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                set.DataSource = ds.Tables[0];
            }
            else if (index == 2)
            {
                string query = "select * from activity";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                set.DataSource = ds.Tables[0];
            }
            else if (index == 3)
            {
                string query =
                    "SELECT * " +
                    "FROM activity " +
                    "WHERE aid IN ( " +
                        "SELECT ajid " +
                        "FROM joinactivity " +
                        "WHERE pjid = " + pid.Text +
                    " );";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                set.DataSource = ds.Tables[0];
            }


            Con.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void player_Load(object sender, EventArgs e)
        {
            pid.Text = login.idshow;
            pname.Text = login.nameshow;
            plevel.Text = login.levelshow;
        }

        private void searchcha_Click(object sender, EventArgs e)
        {
            index = 1;
            populate();
        }

        private void searchact_Click(object sender, EventArgs e)
        {
            index = 2;
            populate();
        }

        private void secrchhavejoin_Click(object sender, EventArgs e)
        {
            index = 3;
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void join_Click(object sender, EventArgs e)
        {
            if (activityname.Text == "")
            {
                MessageBox.Show("输入信息缺失，请重新输入");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO joinactivity VALUES (" + Convert.ToInt32(pid.Text) + ", " + Convert.ToInt32(activityname.Text) + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功参加活动");

                }
                catch (SqlException ex)
                {

                    MessageBox.Show("活动已加入或活动不存在，请重新输入！");

                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (activityname.Text == "")
            {
                MessageBox.Show("信息缺失，无法删除");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM joinactivity WHERE ajid = " + Convert.ToInt32(activityname.Text);
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功退出活动");

                }
                catch (SqlException ex)
                {

                    MessageBox.Show("您未参加该活动！");

                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        private void tuichu_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
