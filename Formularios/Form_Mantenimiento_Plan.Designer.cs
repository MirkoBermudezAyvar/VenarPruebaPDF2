using System.Windows.Forms;

namespace Prueba_pdf.Formularios
{
    partial class Form_Mantenimiento_Plan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            txtnomplantilla = new TextBox();
            dgvListaPlantillas = new DataGridView();
            Eliminar = new DataGridViewTextBoxColumn();
            pnlmetadatos = new Panel();
            cbotipodato = new ComboBox();
            lbltipodato = new Label();
            lbllongitud = new Label();
            txtlongitud = new TextBox();
            txtnomcolumn = new TextBox();
            lblnomcolum = new Label();
            lblplantilla = new Label();
            txtrecibedes = new TextBox();
            txtrecibeid = new TextBox();
            btnagregar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgAtributos = new DataGridView();
            EliminarA = new DataGridViewTextBoxColumn();
            btnAgregar_Plan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaPlantillas).BeginInit();
            pnlmetadatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAtributos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(399, 9);
            label2.Name = "label2";
            label2.Size = new Size(240, 32);
            label2.TabIndex = 2;
            label2.Text = "Detalle de Plantillas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 38);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Plantilla";
            label3.Click += label3_Click;
            // 
            // txtnomplantilla
            // 
            txtnomplantilla.Location = new Point(54, 30);
            txtnomplantilla.Name = "txtnomplantilla";
            txtnomplantilla.Size = new Size(100, 23);
            txtnomplantilla.TabIndex = 5;
            // 
            // dgvListaPlantillas
            // 
            dgvListaPlantillas.AllowUserToAddRows = false;
            dgvListaPlantillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaPlantillas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPlantillas.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dgvListaPlantillas.Location = new Point(12, 96);
            dgvListaPlantillas.Name = "dgvListaPlantillas";
            dgvListaPlantillas.RowTemplate.Height = 25;
            dgvListaPlantillas.Size = new Size(230, 315);
            dgvListaPlantillas.TabIndex = 7;
            dgvListaPlantillas.CellClick += dgvListaPlantillas_CellClick;
            dgvListaPlantillas.CellPainting += dgvListaPlantillas_CellPainting;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlmetadatos
            // 
            pnlmetadatos.Controls.Add(cbotipodato);
            pnlmetadatos.Controls.Add(lbltipodato);
            pnlmetadatos.Controls.Add(btnagregar);
            pnlmetadatos.Controls.Add(lbllongitud);
            pnlmetadatos.Controls.Add(txtlongitud);
            pnlmetadatos.Controls.Add(txtnomcolumn);
            pnlmetadatos.Controls.Add(lblnomcolum);
            pnlmetadatos.Controls.Add(lblplantilla);
            pnlmetadatos.Controls.Add(txtrecibedes);
            pnlmetadatos.Controls.Add(txtrecibeid);
            pnlmetadatos.Location = new Point(322, 53);
            pnlmetadatos.Name = "pnlmetadatos";
            pnlmetadatos.Size = new Size(574, 358);
            pnlmetadatos.TabIndex = 8;
            // 
            // cbotipodato
            // 
            cbotipodato.FormattingEnabled = true;
            cbotipodato.Location = new Point(15, 195);
            cbotipodato.Name = "cbotipodato";
            cbotipodato.Size = new Size(223, 23);
            cbotipodato.TabIndex = 8;
            cbotipodato.Visible = false;
            cbotipodato.SelectedIndexChanged += cbotipodato_SelectedIndexChanged;
            // 
            // lbltipodato
            // 
            lbltipodato.AutoSize = true;
            lbltipodato.Location = new Point(18, 166);
            lbltipodato.Name = "lbltipodato";
            lbltipodato.Size = new Size(73, 15);
            lbltipodato.TabIndex = 7;
            lbltipodato.Text = "Tipo de dato";
            // 
            // lbllongitud
            // 
            lbllongitud.AutoSize = true;
            lbllongitud.Location = new Point(21, 235);
            lbllongitud.Name = "lbllongitud";
            lbllongitud.Size = new Size(55, 15);
            lbllongitud.TabIndex = 6;
            lbllongitud.Text = "Longitud";
            // 
            // txtlongitud
            // 
            txtlongitud.Location = new Point(15, 263);
            txtlongitud.Name = "txtlongitud";
            txtlongitud.Size = new Size(223, 23);
            txtlongitud.TabIndex = 5;
            txtlongitud.KeyPress += txtlongitud_KeyPress;
            // 
            // txtnomcolumn
            // 
            txtnomcolumn.Location = new Point(15, 128);
            txtnomcolumn.Name = "txtnomcolumn";
            txtnomcolumn.Size = new Size(223, 23);
            txtnomcolumn.TabIndex = 4;
            txtnomcolumn.KeyPress += txtnomcolumn_KeyPress;
            // 
            // lblnomcolum
            // 
            lblnomcolum.AutoSize = true;
            lblnomcolum.Location = new Point(15, 110);
            lblnomcolum.Name = "lblnomcolum";
            lblnomcolum.Size = new Size(117, 15);
            lblnomcolum.TabIndex = 3;
            lblnomcolum.Text = "Nombre de columna";
            // 
            // lblplantilla
            // 
            lblplantilla.AutoSize = true;
            lblplantilla.Location = new Point(15, 60);
            lblplantilla.Name = "lblplantilla";
            lblplantilla.Size = new Size(49, 15);
            lblplantilla.TabIndex = 2;
            lblplantilla.Text = "Plantilla";
            // 
            // txtrecibedes
            // 
            txtrecibedes.Location = new Point(70, 52);
            txtrecibedes.Name = "txtrecibedes";
            txtrecibedes.Size = new Size(168, 23);
            txtrecibedes.TabIndex = 1;
            // 
            // txtrecibeid
            // 
            txtrecibeid.Enabled = false;
            txtrecibeid.Location = new Point(76, 13);
            txtrecibeid.Name = "txtrecibeid";
            txtrecibeid.Size = new Size(100, 23);
            txtrecibeid.TabIndex = 0;
            txtrecibeid.Visible = false;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(379, 3);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 9;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgAtributos
            // 
            dgAtributos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAtributos.Columns.AddRange(new DataGridViewColumn[] { EliminarA });
            dgAtributos.Location = new Point(911, 105);
            dgAtributos.Name = "dgAtributos";
            dgAtributos.RowTemplate.Height = 25;
            dgAtributos.Size = new Size(343, 92);
            dgAtributos.TabIndex = 10;
            dgAtributos.CellPainting += dgAtributos_CellPainting;
            // 
            // EliminarA
            // 
            EliminarA.HeaderText = "Eliminar";
            EliminarA.Name = "EliminarA";
            // 
            // btnAgregar_Plan
            // 
            btnAgregar_Plan.Location = new Point(167, 29);
            btnAgregar_Plan.Name = "btnAgregar_Plan";
            btnAgregar_Plan.Size = new Size(122, 23);
            btnAgregar_Plan.TabIndex = 12;
            btnAgregar_Plan.Text = "Agregar Plantilla";
            btnAgregar_Plan.UseVisualStyleBackColor = true;
            btnAgregar_Plan.Click += btnAgregar_Plan_Click;
            // 
            // Form_Mantenimiento_Plan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 450);
            Controls.Add(btnAgregar_Plan);
            Controls.Add(dgAtributos);
            Controls.Add(pnlmetadatos);
            Controls.Add(dgvListaPlantillas);
            Controls.Add(txtnomplantilla);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form_Mantenimiento_Plan";
            Text = "Form_Mantenimiento_Plan";
            ((System.ComponentModel.ISupportInitialize)dgvListaPlantillas).EndInit();
            pnlmetadatos.ResumeLayout(false);
            pnlmetadatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAtributos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtnomplantilla;
        private DataGridView dgvListaPlantillas;
        private Panel pnlmetadatos;
        private TextBox txtrecibeid;
        private Button btnagregar;
        private Label lblplantilla;
        private TextBox txtrecibedes;
        private ComboBox cbotipodato;
        private Label lbltipodato;
        private Label lbllongitud;
        private TextBox txtlongitud;
        private TextBox txtnomcolumn;
        private Label lblnomcolum;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgAtributos;
        private Button btnAgregar_Plan;
        private DataGridViewTextBoxColumn Eliminar;
        private DataGridViewTextBoxColumn EliminarA;
    }
}