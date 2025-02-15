﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio_14._1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DESKTOP-539IR1D\SQLEXPRESS;Database=NombreDeTuBaseDeDatos;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        bool nuevo;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            nuevo = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;


        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if(nuevo)
            {
                string sql = "INSERT INTO Laptops (NOMBRE, PRECIO, STOCK)"
                    + "VALUES('" + txtNombre.Text + "', '" + txtPrecio.Text + "', '" + txtStock.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro ingresado correctamente !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE Laptops SET NOMBRE='" + txtNombre.Text +
                    "', PRECIO='" + txtPrecio.Text +
                    "'," + "STOCK='" + txtPrecio.Text + "' WHERE id=" + txtId.Text + "";

                SqlConnection con = new SqlConnection( connectionString);
                SqlCommand cmd = new SqlCommand (sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open ();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    con.Close ();
                }
            }
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            string sql = "delete from Laptops where id='" + this.txtId.Text + "';";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro eliminado correctamente !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Laptops WHERE ID=" + tstId.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    txtId.Enabled = false;
                    tsbBuscar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    txtNombre.Focus();
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtPrecio.Text = reader[2].ToString();
                    txtStock.Text = reader[3].ToString();
                    nuevo = false;
                }
                else
                    MessageBox.Show("Ningun registro encontrado con el Id ingresado !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            tstId.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
