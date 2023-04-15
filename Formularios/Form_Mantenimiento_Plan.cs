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
using System.ComponentModel.DataAnnotations;



namespace Prueba_pdf.Formularios
{
    public partial class Form_Mantenimiento_Plan : Form
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["db_conexion"].ConnectionString.Replace("\\\\", "\\");
        public Form_Mantenimiento_Plan()
        {
            InitializeComponent();
            LlenarActualizarDGVPlantillas();
            LlenarComboTipodato();
            OcultarCampos();


            //dgAtributos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //dgAtributos.ColumnHeadersHeight = 50;
            //dgAtributos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
        }

        private void LlenarAtributos(string nombre)
        {
            bool validaciontabla = ValidacionTabla("PL_" + nombre);

            if (!validaciontabla)
            {
                try
                {
                    // Consulta para obtener los datos de la tabla
                    string query = "SELECT  * from PL_" + nombre;

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
                                System.Data.DataTable dataTable = new System.Data.DataTable();

                                // Llenar el DataTable con los datos de la tabla
                                adapter.Fill(dataTable);

                                // Asignar el DataTable al DataGridView
                                dgAtributos.DataSource = dataTable;
                            }
                        }
                    }
                    dgAtributos.Refresh();
                    //dgvListaPlantillas.Columns["plani_id"].Visible = false;
                    //txtnomplantilla.Text = string.Empty;
                }

                catch (Exception ex)
                {

                }
            }
            else
            {
                dgAtributos.DataSource = "";
            }

        }





        private void LlenarComboTipodato()
        {
            string[] elementos = new string[] { "varchar", "int", "date" };
            cbotipodato.Items.AddRange(elementos);
            cbotipodato.SelectedIndex = 0;
            cbotipodato.Visible = true;
            //// Agregar un elemento adicional al ComboBox en el índice 0 con el texto deseado
            //if (dt.Rows.Count > 0)
            //{
            //    // Establecer el índice seleccionado en 0
            //    comboBox1.SelectedIndex = 0;
            //}


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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            bool bandera = false;
            DataGridViewRow row = this.dgvListaPlantillas.Rows[e.RowIndex];
            string tabla = Convert.ToString(row.Cells["Plantillas"].Value);
            string tabla_sintildes = new string(tabla.Normalize(System.Text.NormalizationForm.FormD).Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark).ToArray());

            bool validaciontabla = ValidacionTabla("PL_" + tabla_sintildes);
            if (e.ColumnIndex == dgvListaPlantillas.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                if (!validaciontabla)
                {
                    // Mostrar un mensaje de confirmación
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro, ya contiene la tabla?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario hace clic en Sí, eliminar el registro de la base de datos
                    if (result == DialogResult.Yes)
                    {

                        int id = Convert.ToInt32(dgvListaPlantillas.Rows[e.RowIndex].Cells["plani_id"].Value);
                        string query = "DELETE FROM PlantillaPDF WHERE plani_id = @id";
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        //Eliminado la tabla
                        string query2 = "DROP TABLE " + "PL_" + tabla_sintildes;
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(query2, conn))
                        {
                            //cmd.Parameters.AddWithValue("@id", id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        dgvListaPlantillas.Rows.RemoveAt(e.RowIndex);
                        bandera = true;
                        OcultarCampos();

                    }

                }

                else
                {
                    int id = Convert.ToInt32(dgvListaPlantillas.Rows[e.RowIndex].Cells["plani_id"].Value);
                    string query = "DELETE FROM PlantillaPDF WHERE plani_id = @id";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    bandera = true;
                    MessageBox.Show("Se eliminó satisfactoriamente el elemento");
                }
            }
            if (!bandera)
            {
                string des = string.Empty;
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row2 = this.dgvListaPlantillas.Rows[e.RowIndex];
                        int id = Convert.ToInt32(row2.Cells["plani_id"].Value);
                        des = Convert.ToString(row2.Cells["Plantillas"].Value);

                        // Crear un nuevo formulario o panel y pasar el valor del ID
                        //OpcionesForm opcionesForm = new OpcionesForm(id);
                        //opcionesForm.Show();
                        string des_sintildes = new string(des.Normalize(System.Text.NormalizationForm.FormD).Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark).ToArray());
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
                MostrarCampos();

                string des_sintildesx = new string(des.Normalize(System.Text.NormalizationForm.FormD).Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark).ToArray());
                LlenarAtributos(des_sintildesx);
            }
            LlenarActualizarDGVPlantillas();
            dgvListaPlantillas.Refresh();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            bool validacion_campos = true;
            validacion_campos = ValidarcamposAtributos();
            if (!validacion_campos)
            {
                string planillanom = txtrecibedes.Text;
                string flaglongitud = "N";
                string elementoSeleccionado = (string)cbotipodato.SelectedItem;
                string nomcolum = txtnomcolumn.Text;
                //Logica para determinar si tiene longitud
                int longitud = 0;

                if (!string.IsNullOrEmpty(txtlongitud.Text))
                {
                    longitud = Convert.ToInt32(txtlongitud.Text);
                    int valorEntero;
                    if (int.TryParse(txtlongitud.Text, out valorEntero))
                    {
                        longitud = Convert.ToInt32(txtlongitud.Text);
                        flaglongitud = "S";


                    }
                }

                bool validacion = false;
                //formación de tabla
                string tablaformada = "PL_" + planillanom;
                string pkformada = tablaformada.ToLower() + "_id";
                validacion = ValidacionTabla(tablaformada);
                if (validacion)
                {
                    CreacionTabla(tablaformada, pkformada);
                    UpdateTable(nomcolum, elementoSeleccionado, longitud, tablaformada, flaglongitud);
                    LlenarAtributos(planillanom);
                    LimpiarAtributos();
                }
                else
                {
                    UpdateTable(nomcolum, elementoSeleccionado, longitud, tablaformada, flaglongitud);
                    LlenarAtributos(planillanom);
                    LimpiarAtributos();
                }
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos");
            }
        }

        private bool ValidacionTabla(string tabla)
        {
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
        private void CreacionTabla(string nomtabla, string pk)
        {

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
            catch (Exception ex)
            {
                string detalle = string.Empty;
                detalle = ex.Message;

            }

        }
        private void UpdateTable(string nomcolum, string tipodato, int tamanio, string tablaformada, string flaglongitud)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string columnName = "pl_" + nomcolum;
                string dataType = tipodato;
                int length = tamanio;
                if (flaglongitud == "N")
                {
                    string alterTableQuery = string.Format("ALTER TABLE {2} ADD {0} {1}", columnName, dataType, tablaformada);

                    using (SqlCommand command = new SqlCommand(alterTableQuery, connection))
                    {
                        // Ejecuta la consulta
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("La columna se agregó con éxito.");

                    }
                }
                else
                {
                    if (dataType.ToLower() == "date")
                    {
                        length = -1; // Si el tipo de dato es un date, la longitud se establece en -1
                    }

                    string alterTableQuery = string.Format("ALTER TABLE {3} ADD {0} {1}{2}", columnName, dataType, length > 0 ? "(" + length + ")" : "", tablaformada);

                    using (SqlCommand command = new SqlCommand(alterTableQuery, connection))
                    {
                        // Ejecuta la consulta
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("La columna se agregó con éxito.");
                    }
                }
            }
        }

        private void txtnomcolumn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtlongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007f')
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                int valor = int.Parse(txtlongitud.Text + e.KeyChar);
                if (valor < 1 || valor > 255)
                {
                    e.Handled = true;
                }
            }

        }



        private void dgAtributos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgAtributos.Columns["EliminarA"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icon = Recursos.icons8_eliminar_261; // cambie 'DeleteIcon' con el nombre del icono que desea utilizar
                var x = e.CellBounds.Left + (e.CellBounds.Width - icon.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - icon.Height) / 2;
                e.Graphics.DrawImage(icon, new Point(x, y));
                e.Handled = true;
            }

        }

        private void OcultarCampos()
        {

            txtrecibeid.Hide();
            lblplantilla.Hide();
            txtrecibedes.Hide();
            lblnomcolum.Hide();
            txtnomcolumn.Hide();
            lbltipodato.Hide();
            cbotipodato.Hide();
            lbllongitud.Hide();
            txtlongitud.Hide();
            btnagregar.Hide();
            dgAtributos.Hide();

        }


        private void MostrarCampos()
        {

            //txtrecibeid.Show();
            lblplantilla.Show();
            txtrecibedes.Show();
            lblnomcolum.Show();
            txtnomcolumn.Show();
            lbltipodato.Show();
            cbotipodato.Show();
            lbllongitud.Show();
            txtlongitud.Show();
            btnagregar.Show();
            dgAtributos.Show();
        }

        private void LimpiarAtributos()
        {
            txtlongitud.Text = "";
            txtnomcolumn.Text = "";
            cbotipodato.SelectedIndex = 0;
        }

        private void btnAgregarPlantilla_Click(object sender, EventArgs e)
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



        private void btnAgregar_Plan_Click(object sender, EventArgs e)
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

        private void cbotipodato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipodato.SelectedIndex != 0)
            {
                txtlongitud.Visible = false;
                //txtnomcolumn.Visible = false;
                lbllongitud.Visible = false;
                txtlongitud.Text = string.Empty;

            }
            else
            {
                txtlongitud.Visible = true;
                //txtnomcolumn.Visible = true;
                lbllongitud.Visible = true;
            }

        }

        private void dgvListaPlantillas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex == dgvListaPlantillas.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icon = Recursos.icons8_eliminar_261; // cambie 'DeleteIcon' con el nombre del icono que desea utilizar
                var x = e.CellBounds.Left + (e.CellBounds.Width - icon.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - icon.Height) / 2;
                e.Graphics.DrawImage(icon, new Point(x, y));
                e.Handled = true;
            }
        }

        private bool ValidarcamposAtributos()
        {
            bool camposvacios = false;
            if (cbotipodato.SelectedIndex != 0)
            {
                if (txtnomcolumn.Text == string.Empty)
                {
                    camposvacios = true;
                }

            }

            else if (txtlongitud.Text == string.Empty || txtnomcolumn.Text == string.Empty)
            {
                camposvacios = true;
            }

            return camposvacios;
        }
    }

}


