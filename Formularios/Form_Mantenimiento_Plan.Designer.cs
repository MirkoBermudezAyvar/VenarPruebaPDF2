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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnomplantilla = new TextBox();
            button1 = new Button();
            dgvListaPlantillas = new DataGridView();
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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaPlantillas).BeginInit();
            pnlmetadatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAtributos).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1157, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1090, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Planillas";
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
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Plantilla";
            label3.Click += label3_Click;
            // 
            // txtnomplantilla
            // 
            txtnomplantilla.Location = new Point(67, 35);
            txtnomplantilla.Name = "txtnomplantilla";
            txtnomplantilla.Size = new Size(100, 23);
            txtnomplantilla.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(190, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvListaPlantillas
            // 
            dgvListaPlantillas.AllowUserToAddRows = false;
            dgvListaPlantillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaPlantillas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPlantillas.Location = new Point(12, 96);
            dgvListaPlantillas.Name = "dgvListaPlantillas";
            dgvListaPlantillas.RowTemplate.Height = 25;
            dgvListaPlantillas.Size = new Size(230, 315);
            dgvListaPlantillas.TabIndex = 7;
            dgvListaPlantillas.CellClick += dgvListaPlantillas_CellClick;
            // 
            // pnlmetadatos
            // 
            pnlmetadatos.Controls.Add(cbotipodato);
            pnlmetadatos.Controls.Add(lbltipodato);
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
            cbotipodato.Location = new Point(15, 193);
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
            btnagregar.Location = new Point(749, 24);
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
            dgAtributos.Location = new Point(911, 105);
            dgAtributos.Name = "dgAtributos";
            dgAtributos.RowTemplate.Height = 25;
            dgAtributos.Size = new Size(343, 92);
            dgAtributos.TabIndex = 10;
            dgAtributos.CellPainting += dgAtributos_CellPainting;
            // 
            // guna2Button1
            // 
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(922, 258);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 11;
            guna2Button1.Text = "guna2Button1";
            // 
            // Form_Mantenimiento_Plan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 450);
            Controls.Add(guna2Button1);
            Controls.Add(dgAtributos);
            Controls.Add(btnagregar);
            Controls.Add(pnlmetadatos);
            Controls.Add(dgvListaPlantillas);
            Controls.Add(button1);
            Controls.Add(txtnomplantilla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
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

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnomplantilla;
        private Button button1;
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
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}