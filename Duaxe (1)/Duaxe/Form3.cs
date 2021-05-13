using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duaxe
{
    public partial class Form3 : Form
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string _diem)
        {
            InitializeComponent();
            label3.Text = _diem;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private DataTable getScore()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from Bang order by Diem desc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        private void addScore(int diem, string ten)
        {
            cmd.CommandText = "Insert into Bang values (N'" + ten + "'," + diem + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
        }
        private void updScore(int diem, string ten, string tentruoc)
        {
            cmd.CommandText = @"update Bang set Ten=N'" + ten +"' where Ten=N'" + tentruoc +"' and Diem="+ diem;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
        }
        private void delScore(int diem, string ten)
        {
            cmd.CommandText = @"delete Bang where Ten = '" + ten + "' and Diem =" + diem;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Ten");
            label3.DataBindings.Clear();
            label3.DataBindings.Add("Text", dataGridView1.DataSource, "Diem");
            tam = textBox1.Text.Trim();
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;
        }
        string tam;
        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = getScore();
            dataGridView1.DataSource = dtDS;
        }
        private void reLoad()
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = getScore();
            dataGridView1.DataSource = dtDS;
            textBox1.Text = "";
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addScore(Int32.Parse(label3.Text.Trim()),textBox1.Text.Trim());
            reLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delScore(Int32.Parse(label3.Text.Trim()),textBox1.Text.Trim());
            reLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updScore(Int32.Parse(label3.Text.Trim()), textBox1.Text.Trim(),tam);
            reLoad();
        }
    }
}
