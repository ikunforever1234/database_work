using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace database
{
    public partial class characters : Form
    {
        public characters()
        {
            InitializeComponent();
            populate();
        }


        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29163\Documents\sanguosha.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");


        //显示武将列表
        private void populate()
        {
            Con.Open();
            string query = "select * from character";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            wujiangset.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string key = "1";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            wujiangname.Text = wujiangset.SelectedRows[0].Cells[0].Value.ToString();
            wujiangblood.Text = wujiangset.SelectedRows[0].Cells[1].Value.ToString();
            wujiangcountry.Text = wujiangset.SelectedRows[0].Cells[2].Value.ToString();
            wujianggender.Text = wujiangset.SelectedRows[0].Cells[3].Value.ToString();
            wujiangskill.Text = wujiangset.SelectedRows[0].Cells[4].Value.ToString();

            if (wujiangname.Text == "")
            {
                key = "1";
            }
            else
            {
                key = wujiangname.Text;
            }
        }

        //保存新武将
        //private void wujiangsave_Click(object sender, EventArgs e)
        //{
        //    if (wujiangname.Text == "" || wujiangblood.Text == "" || wujiangcountry.Text == "" || wujianggender.Text == "" || wujiangskill.Text == "")
        //    {
        //        MessageBox.Show("输入信息缺失，请重新输入");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            Con.Open();
        //            string query = "insert into character values(N'" + wujiangname.Text + "',N'" + wujiangblood.Text + "',N'" + wujiangcountry.Text + "',N'" + wujianggender.Text + "',N'" + wujiangskill.Text + "')";
        //            //MessageBox.Show(query);
        //            SqlCommand cmd = new SqlCommand(query, Con);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("武将信息保存成功");
        //            Con.Close();
        //            reset();
        //        }
        //        catch (Exception Ex)
        //        {

        //            MessageBox.Show(Ex.Message);
        //        }
        //    }
        //}

        private void wujiangsave_Click(object sender, EventArgs e)
        {
            if (wujiangname.Text == "" || wujiangblood.Text == "" || wujiangcountry.Text == "" || wujianggender.Text == "" || wujiangskill.Text == "")
            {
                MessageBox.Show("输入信息缺失，请重新输入");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO character VALUES (N'" + wujiangname.Text + "', N'" + wujiangblood.Text + "', " + "N'" + wujiangcountry.Text + "', N'" + wujianggender.Text + "', N'" + wujiangskill.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("武将信息保存成功");
                    reset();
                }
                catch (SqlException ex)
                {

                    if (ex.Number == 50000)
                    {
                        MessageBox.Show("添加失败，血量必须在 1~5 之间", "插入失败"/*, MessageBoxButtons.OK, MessageBoxIcon.Warning*/);
                    }
                    else
                    {

                        MessageBox.Show("添加失败，请检查输入是否合法。", "插入失败"/*, MessageBoxButtons.OK, MessageBoxIcon.Warning*/);
                    }
                    //MessageBox.Show(ex.Message);

                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }


        private void characters_Load(object sender, EventArgs e)
        {

        }

        private void wujiangdelete_Click(object sender, EventArgs e)
        {
            if (key == "1")
            {
                MessageBox.Show("信息缺失，无法删除");
            }
            else
            {
                try
                {
                    Con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM character WHERE cname = N'" + wujiangname.Text + "'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        string deleteQuery = "DELETE FROM character WHERE cname = N'" + wujiangname.Text + "'";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, Con);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("武将删除成功");
                    }
                    else
                    {
                        MessageBox.Show("未找到该武将，无法删除");
                    }

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

        private void wujiangcountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
            reset();
        }

        private void reset()
        {
            wujiangname.Text = "";
            wujiangblood.Text = "";
            wujiangcountry.Text = "";
            wujiangskill.Text = "";
            wujianggender.Text = "";
        }
        private void wujiangreset_Click(object sender, EventArgs e)
        {
            reset();
            key = "1";
        }

        private void wujiangedit_Click(object sender, EventArgs e)
        {
            if (wujiangname.Text == "" || wujiangblood.Text == "" || wujiangcountry.Text == "" || wujianggender.Text == "" || wujiangskill.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();
                    //string query = "UPDATE character SET " + "cname = N'" + wujiangname.Text + "', " +
                    //    "cblood = N'" + wujiangblood.Text + "', " +
                    //    "ccountry = N'" + wujiangcountry.Text + "', " +
                    //    "cgender = N'" + wujianggender.Text + "', " +
                    //    "cskill = N'" + wujiangskill.Text + "' " +
                    //    "WHERE cname = N'" + key + "'";
                    //SqlCommand cmd = new SqlCommand(query, Con);
                    //cmd.ExecuteNonQuery();

                    string query = "EXEC UpdateCharacterInfo @oldCname, @cname, @cblood, @ccountry, @cgender, @cskill";

                    using (SqlCommand cmd1 = new SqlCommand(query, Con))
                    {
                        cmd1.Parameters.AddWithValue("@oldCname", key);
                        cmd1.Parameters.AddWithValue("@cname", wujiangname.Text);
                        cmd1.Parameters.AddWithValue("@cblood", wujiangblood.Text);
                        cmd1.Parameters.AddWithValue("@ccountry", wujiangcountry.Text);
                        cmd1.Parameters.AddWithValue("@cgender", wujianggender.Text);
                        cmd1.Parameters.AddWithValue("@cskill", wujiangskill.Text);


                        cmd1.ExecuteNonQuery();

                    }

                    MessageBox.Show("武将信息编辑成功");
                    key = "1";
                    reset();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("武将信息编辑失败！");

                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            jineng temp = new jineng();
            temp.Show();
            this.Hide();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            activity temp = new activity();
            temp.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            users temp = new users();
            temp.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            login temp = new login();
            temp.Show();
            this.Hide();
        }
    }
}
