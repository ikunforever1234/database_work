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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            populate();
        }

        private void updateset()
        {

            string query = "select * from user_player";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pset.DataSource = ds.Tables[0];
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29163\Documents\sanguosha.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from user_player";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pset.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void reset()
        {
            pid.Text = "";
            pname.Text = "";
            pregistertime.Text = "";
            plevel.Text = "";
            ppassword.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void psave_Click(object sender, EventArgs e)
        {
            if (pid.Text == "" || pname.Text == "" || ppassword.Text == "" || pregistertime.Text == "" || plevel.Text == "")
            {
                MessageBox.Show("输入信息缺失，请重新输入");
            }
            else
            {
                try
                {
                    Con.Open();


                    string query =
                        "INSERT INTO [user] VALUES ("
                        + pid.Text + ", "                  // 整数 ID
                        + "N'" + ppassword.Text + "', "     // 密码
                        + pregistertime.Text                // 整数型注册时间
                        + ");";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    query =
                        "INSERT INTO player VALUES ("
                        + pid.Text + ", "                  // 整数 ID
                        + "N'" + pname.Text + "', "     // 密码
                        + plevel.Text                // 整数型注册时间
                        + ");";

                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    updateset();
                    MessageBox.Show("玩家信息保存成功");
                    reset();

                }
                catch (SqlException ex)
                {

                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("保存失败");

                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        private void pedit_Click(object sender, EventArgs e)
        {
            if (pid.Text == "" || pname.Text == "" || ppassword.Text == "" || pregistertime.Text == "" || plevel.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE [user] SET " + "uid = " + Convert.ToInt32(pid.Text) + ", " +
                        "password = N'" + ppassword.Text + "', " +
                        "register_time = " + Convert.ToInt32(pregistertime.Text) + " " +
                        "WHERE uid = " + Convert.ToInt32(key);
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    query = "UPDATE player SET " + "pid = " + Convert.ToInt32(pid.Text) + ", " +
                        "pname = N'" + pname.Text + "', " +
                        "plevel = " + Convert.ToInt32(plevel.Text) + " " +
                        "WHERE pid = " + Convert.ToInt32(key);
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    updateset();
                    MessageBox.Show("用户信息编辑成功");
                    key = "false";
                    reset();

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        private void pdelete_Click(object sender, EventArgs e)
        {
            if (key == "false")
            {
                MessageBox.Show("信息缺失，无法删除");
            }
            else
            {
                try
                {
                    Con.Open();

                    //string query = "DELETE FROM [user] WHERE uid = " + key.Replace("'", " ") + ";";
                    string query = "DELETE FROM [user] WHERE uid = " + Convert.ToInt32(pid.Text);

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    query = "DELETE FROM player WHERE pid = " + Convert.ToInt32(pid.Text);
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    updateset();
                    MessageBox.Show("用户信息删除成功");
                    key = "false";
                    reset();

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        string key = "false";
        private void pset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pid.Text = pset.SelectedRows[0].Cells[0].Value.ToString();
            pname.Text = pset.SelectedRows[0].Cells[1].Value.ToString();
            pregistertime.Text = pset.SelectedRows[0].Cells[4].Value.ToString();
            plevel.Text = pset.SelectedRows[0].Cells[2].Value.ToString();
            ppassword.Text = pset.SelectedRows[0].Cells[3].Value.ToString();

            if (pid.Text == "")
            {
                key = "false";
                //MessageBox.Show(key);
            }
            else
            {
                key = pid.Text;
                //MessageBox.Show(key);
            }
        }

        private void users_Load(object sender, EventArgs e)
        {

        }

        private void presset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            characters temp = new characters();
            temp.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            jineng temp = new jineng();
            temp.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            activity temp = new activity();
            temp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login temp = new login();
            temp.Show();
            this.Hide();
        }
    }
}
