using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//se necesita la biblioteca para la conexion

namespace AccesBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCrearBD_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Server=Julls\\SQLEXPRESS;" + "Database=master;" + "User Id=sa;" + "Password=12345";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cdm = new SqlCommand();
                cdm.Connection = conn;
                cdm.CommandText = "CREATE DATABASE ESCOLAR";
                cdm.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error de sistema");
            }
        }

        private void btCrearTabla_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Server=Julls\\SQLEXPRESS;" + "Database=ESCOLAR;" + "User Id=sa;" + "Password=12345";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cdm = new SqlCommand();
                cdm.Connection = conn;
                cdm.CommandText = "CREATE TABLE " + "Alumnos (NoControl varchar (10), nombre varchar(50), carrera varchar(50))";
                cdm.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error de sistema");
            }
        }


        private void btInsertar_Click(object sender, EventArgs e)
        {/*
            try
            {
                string strConn = "Server=Julls\\SQLEXPRESS;" + "Database=master;" + "User Id=sa;" + "Password=julinley";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cdm = new SqlCommand();
                cdm.Connection = conn;
                cdm.CommandText = "INSERT INTO " + "Alumnos (NoControl,  nombre, carrera)"+ "VALUES ()"
                cdm.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error de sistema");
            }
        }*/
        }
    }
}
        

