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

namespace Class_Task_GUI__11_04_21_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string s_id = tb_sNamee.Text;
            string s_name = tb_sName.Text;  
            string s_cgpa = tb_sCgpa.Text;
            string connString = @"Server=DESKTOP-CVSU4IE\SQLEXPRESS;Database=Practice;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            string query = string.Format("insert into StudentInfo values ('{0}','{1}','{2}')", s_id, s_name, s_cgpa);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Could not insert data");
            }
            conn.Close();
        }

        private void LoadAllButton(object sender, EventArgs e)
        {
            string connString = @"Server=DESKTOP-CVSU4IE\SQLEXPRESS;Database=Practice;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            string query = "select * from StudentInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList list = new ArrayList();

            while (reader.Read())
            {
                Student s = new Student();
                s.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                s.Name = reader.GetString(reader.GetOrdinal("Name"));
                s.Cgpa = reader.GetString(reader.GetOrdinal("Cgpa"));
                list.Add(s);
            }
            dt_Student.DataSource = list;
        }

        
    }
}
