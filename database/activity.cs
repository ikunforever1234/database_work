using System;
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
    public partial class activity : Form
    {
        public activity()
        {
            InitializeComponent();
            populate();
        }

        private void updateset()
        {

            string query = "select * from activity";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            aset.DataSource = ds.Tables[0];
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29163\Documents\sanguosha.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from activity";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            aset.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void reset()
        {
            aid.Text = "";
            aname.Text = "";
            astarttime.Text = "";
            aduration.Text = "";
        }

        private void asave_Click(object sender, EventArgs e)
        {
            if (aid.Text == "" || aname.Text == "" || astarttime.Text == "" || aduration.Text == "")
            {
                MessageBox.Show("输入信息缺失，请重新输入");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO activity VALUES (N'" + aid.Text + "', N'" + aname.Text + "', N'" + astarttime.Text + "', N'" + aduration.Text + "')";
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

        string key = "1";
        private void aset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aid.Text = aset.SelectedRows[0].Cells[0].Value.ToString();
            aname.Text = aset.SelectedRows[0].Cells[1].Value.ToString();
            astarttime.Text = aset.SelectedRows[0].Cells[2].Value.ToString();
            aduration.Text = aset.SelectedRows[0].Cells[3].Value.ToString();

            if (aid.Text == "")
            {
                key = "1";
            }
            else
            {
                key = aid.Text;
            }
        }

        private void areset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void adelete_Click(object sender, EventArgs e)
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
                    string query = "DELETE FROM activity WHERE aid = N'" + key.Replace("'", "''") + "'";
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

        private void aedit_Click(object sender, EventArgs e)
        {
            if (aid.Text == "" || aname.Text == "" || astarttime.Text == "" || aduration.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE activity SET " + "aid = N'" + aid.Text + "', " +
                        "aname = N'" + aname.Text + "', " +
                        "astarttime = N'" + astarttime.Text + "', " +
                        "aduration = N'" + aduration.Text + "' " +
                        "WHERE aid = N'" + key + "'";
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

        private void label5_Click(object sender, EventArgs e)
        {
            users temp = new users();
            temp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login temp = new login();
            temp.Show();
            this.Hide();
        }

        private void activity_Load(object sender, EventArgs e)
        {

        }
    }
}
