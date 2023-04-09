using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;

namespace Prueba_pdf.Formularios
{
    public partial class Form_Mantenimiento_Plan : Form
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["db_conexion"].ConnectionString.Replace("\\\\", "\\");
        public Form_Mantenimiento_Plan()
        {
            InitializeComponent();
            LlenarCombo();
            LlenarActualizarDGVPlantillas();
        }

        private void LlenarCombo()
        {


            string query = "SELECT * FROM PlantillaPDF";
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion))
                {
                    adapter.Fill(dt);
                }
            }

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "planv_des";
            comboBox1.ValueMember = "plani_id";
            // Agregar un elemento adicional al ComboBox en el índice 0 con el texto deseado
            if (dt.Rows.Count > 0)
            {
                // Establecer el índice seleccionado en 0
                comboBox1.SelectedIndex = 0;
            }


        }



        private void LLenardgtxCombo(string codcombo)
        {

            int numero;
            double numeroDecimal;


            if (int.TryParse(codcombo, out numero))
            {
                // Consulta para obtener los datos de la tabla
                string query = "SELECT p.planv_des as Planilla,planidet_anio as Año  FROM PlantillaPDFDetalle pd inner join PlantillaPDF p " +
                    " on pd.plani_id=p.plani_id where p.plani_id=" + codcombo;

                // Crear una conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Crear un comando para ejecutar la consulta
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Abrir la conexión a la base de datos
                        connection.Open();

                        // Crear un DataAdapter para obtener los datos de la tabla
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Crear un DataTable para almacenar los datos de la tabla
                            DataTable dataTable = new DataTable();

                            // Llenar el DataTable con los datos de la tabla
                            adapter.Fill(dataTable);

                            // Asignar el DataTable al DataGridView
                            //dgtablaplantillas.DataSource = dataTable;
                        }
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedIndex != -1)
                {
                    string filtro = comboBox1.SelectedValue.ToString();
                    LLenardgtxCombo(filtro);
                }
            }
            catch (Exception)
            {


            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores a insertar desde los controles del formulario
            string nomplantilla = txtnomplantilla.Text;
            // query de insercción 
            string sql = "INSERT INTO PlantillaPDF (planv_des) VALUES (@nomplantilla)";
            // Crear la conexión y el comando de inserción
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Agregar los parámetros de consulta
                command.Parameters.AddWithValue("@nomplantilla", nomplantilla);

                // Abrir la conexión y ejecutar la consulta
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Actualizar la vista del DataGridView
            LlenarActualizarDGVPlantillas();

        }

        private void LlenarActualizarDGVPlantillas()
        {
            // Consulta para obtener los datos de la tabla
            string query = "SELECT plani_id,planv_des as Plantillas from PlantillaPDF";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear un comando para ejecutar la consulta
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abrir la conexión a la base de datos
                    connection.Open();

                    // Crear un DataAdapter para obtener los datos de la tabla
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Crear un DataTable para almacenar los datos de la tabla
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos de la tabla
                        adapter.Fill(dataTable);

                        // Asignar el DataTable al DataGridView
                        dgvListaPlantillas.DataSource = dataTable;
                    }
                }
            }
            dgvListaPlantillas.Refresh();
            dgvListaPlantillas.Columns["plani_id"].Visible = false;
            txtnomplantilla.Text = string.Empty;

        }

        private void dgvListaPlantillas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvListaPlantillas.Rows[e.RowIndex];
                    int id = Convert.ToInt32(row.Cells["plani_id"].Value);
                    string des = Convert.ToString(row.Cells["Plantillas"].Value);

                    // Crear un nuevo formulario o panel y pasar el valor del ID
                    //OpcionesForm opcionesForm = new OpcionesForm(id);
                    //opcionesForm.Show();
                    string des_sintildes = new string(des .Normalize(System.Text.NormalizationForm.FormD) .Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark).ToArray());
                    txtrecibeid.Text = id.ToString();
                    txtrecibeid.Enabled = false;
                    txtrecibedes.Text = des_sintildes;
                    txtrecibedes.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string planillanom = txtrecibedes.Text;
            bool validacion = false;
            //formación de tabla
            string tablaformada = "PL_" + planillanom;
            string pkformada=tablaformada.ToLower() + "_id";
            validacion = ValidacionTabla(tablaformada);
            if (validacion)
            {
                CreacionTabla(tablaformada,pkformada);
                //UpdateTable();
            }
            else {
                //UpdateTable();
              }

        }

        private bool ValidacionTabla(string tabla) {
            bool validacion = false;
            string tableName = tabla; // nombre de la tabla que se desea comprobar
            // Consulta SQL para comprobar si la tabla existe
            string checkTableQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión a la base de datos
                connection.Open();

                using (SqlCommand command = new SqlCommand(checkTableQuery, connection))
                {
                    // Ejecutar la consulta y obtener el resultado
                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        // La tabla existe en la base de datos
                        Console.WriteLine($"La tabla '{tableName}' existe en la base de datos.");

                    }
                    else
                    {
                        // La tabla no existe en la base de datos
                        Console.WriteLine($"La tabla '{tableName}' no existe en la base de datos.");
                        validacion = true;
                    }
                }
            }

            return validacion;
        }
        private void CreacionTabla(string nomtabla,string pk) {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Comando para crear la tabla
                    string createTableCommand = "CREATE TABLE " + nomtabla + " ( " + pk + " INT PRIMARY KEY NOT NULL)";

                    // Ejecutar el comando
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(createTableCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
              
            }
            catch ( Exception ex) {
                string detalle = string.Empty;
                detalle = ex.Message;

            }

        }
        private void UpdateTable() { }

      } 

    }


