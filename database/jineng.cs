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
using Microsoft.Data.SqlClient;

namespace database
{
    public partial class jineng : Form
    {
        public jineng()
        {
            InitializeComponent();
            populate();
        }

        private void updateset()
        {

            string query = "select * from skill";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            jinengset.DataSource = ds.Tables[0];
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29163\Documents\sanguosha.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from skill";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            jinengset.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jinengname.Text == "" || jinengtype.Text == "" || jinengintro.Text == "")
            {
                MessageBox.Show("输入信息缺失，请重新输入");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO skill VALUES (N'" + jinengname.Text + "', N'" + jinengtype.Text + "', N'" + jinengintro.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    updateset();
                    MessageBox.Show("技能信息保存成功");
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
        private void reset()
        {
            jinengname.Text = "";
            jinengtype.Text = "";
            jinengintro.Text = "";
        }

        string key = "1";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            jinengname.Text = jinengset.SelectedRows[0].Cells[0].Value.ToString();
            jinengtype.Text = jinengset.SelectedRows[0].Cells[1].Value.ToString();
            jinengintro.Text = jinengset.SelectedRows[0].Cells[2].Value.ToString();

            if (jinengname.Text == "")
            {
                key = "1";
            }
            else
            {
                key = jinengname.Text;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (jinengname.Text == "" || jinengtype.Text == "" || jinengintro.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE skill SET " + "sname = N'" + jinengname.Text + "', " +
                        "stype = N'" + jinengtype.Text + "', " +
                        "sintro = N'" + jinengintro.Text + "' " +
                        "WHERE sname = N'" + key + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    updateset();
                    MessageBox.Show("技能信息编辑成功");
                    key = "1";
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

        private void jinengdelete_Click(object sender, EventArgs e)
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
                    string query = "DELETE FROM skill WHERE sname = N'" + key.Replace("'", "''") + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    updateset();
                    MessageBox.Show("技能删除成功");
                    key = "1";
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

        private void jinengchongzhi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            characters temp = new characters();
            temp.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            login temp = new login();
            temp.Show();
            this.Hide();
        }
    }
}
