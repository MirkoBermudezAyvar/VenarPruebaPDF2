namespace Prueba_pdf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            hola1ToolStripMenuItem = new ToolStripMenuItem();
            hi1ToolStripMenuItem = new ToolStripMenuItem();
            h2ToolStripMenuItem = new ToolStripMenuItem();
            hola2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            hola1ToolStripMenuItem1 = new ToolStripMenuItem();
            mantenimientoDePlantillasToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            hola2ToolStripMenuItem1 = new ToolStripMenuItem();
            hi2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            documentosToolStripMenuItem = new ToolStripMenuItem();
            ventanasToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            printDialog1 = new PrintDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            openFileDialog1 = new OpenFileDialog();
            imageList1 = new ImageList(components);
            process1 = new System.Diagnostics.Process();
            openFileDialog2 = new OpenFileDialog();
            bindingSource1 = new BindingSource(components);
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { hola1ToolStripMenuItem, hola2ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(106, 48);
            contextMenuStrip1.UseWaitCursor = true;
            // 
            // hola1ToolStripMenuItem
            // 
            hola1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hi1ToolStripMenuItem, h2ToolStripMenuItem });
            hola1ToolStripMenuItem.Name = "hola1ToolStripMenuItem";
            hola1ToolStripMenuItem.Size = new Size(105, 22);
            hola1ToolStripMenuItem.Text = "Hola1";
            // 
            // hi1ToolStripMenuItem
            // 
            hi1ToolStripMenuItem.Name = "hi1ToolStripMenuItem";
            hi1ToolStripMenuItem.Size = new Size(90, 22);
            hi1ToolStripMenuItem.Text = "hi1";
            // 
            // h2ToolStripMenuItem
            // 
            h2ToolStripMenuItem.Name = "h2ToolStripMenuItem";
            h2ToolStripMenuItem.Size = new Size(90, 22);
            h2ToolStripMenuItem.Text = "h2";
            // 
            // hola2ToolStripMenuItem
            // 
            hola2ToolStripMenuItem.Name = "hola2ToolStripMenuItem";
            hola2ToolStripMenuItem.Size = new Size(105, 22);
            hola2ToolStripMenuItem.Text = "Hola2";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hola1ToolStripMenuItem1, hola2ToolStripMenuItem1, toolStripMenuItem1, documentosToolStripMenuItem, ventanasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1600, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hola1ToolStripMenuItem1
            // 
            hola1ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { mantenimientoDePlantillasToolStripMenuItem, mantenimientoDeUsuariosToolStripMenuItem, cerrarSesiónToolStripMenuItem, salirToolStripMenuItem });
            hola1ToolStripMenuItem1.Name = "hola1ToolStripMenuItem1";
            hola1ToolStripMenuItem1.Size = new Size(60, 20);
            hola1ToolStripMenuItem1.Text = "Archivo";
            // 
            // mantenimientoDePlantillasToolStripMenuItem
            // 
            mantenimientoDePlantillasToolStripMenuItem.Name = "mantenimientoDePlantillasToolStripMenuItem";
            mantenimientoDePlantillasToolStripMenuItem.Size = new Size(222, 22);
            mantenimientoDePlantillasToolStripMenuItem.Text = "Mantenimiento de Plantillas";
            mantenimientoDePlantillasToolStripMenuItem.Click += mantenimientoDePlantillasToolStripMenuItem_Click;
            // 
            // mantenimientoDeUsuariosToolStripMenuItem
            // 
            mantenimientoDeUsuariosToolStripMenuItem.Name = "mantenimientoDeUsuariosToolStripMenuItem";
            mantenimientoDeUsuariosToolStripMenuItem.Size = new Size(222, 22);
            mantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de Usuarios";
            mantenimientoDeUsuariosToolStripMenuItem.Click += mantenimientoDeUsuariosToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(222, 22);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(222, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // hola2ToolStripMenuItem1
            // 
            hola2ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { hi2ToolStripMenuItem });
            hola2ToolStripMenuItem1.Name = "hola2ToolStripMenuItem1";
            hola2ToolStripMenuItem1.Size = new Size(35, 20);
            hola2ToolStripMenuItem1.Text = "Ver";
            // 
            // hi2ToolStripMenuItem
            // 
            hi2ToolStripMenuItem.Name = "hi2ToolStripMenuItem";
            hi2ToolStripMenuItem.Size = new Size(90, 22);
            hi2ToolStripMenuItem.Text = "hi2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(76, 20);
            toolStripMenuItem1.Text = "Busquedas";
            // 
            // documentosToolStripMenuItem
            // 
            documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            documentosToolStripMenuItem.Size = new Size(87, 20);
            documentosToolStripMenuItem.Text = "Documentos";
            // 
            // ventanasToolStripMenuItem
            // 
            ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            ventanasToolStripMenuItem.Size = new Size(66, 20);
            ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 570);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1600, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 592);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem hola1ToolStripMenuItem;
        private ToolStripMenuItem hi1ToolStripMenuItem;
        private ToolStripMenuItem h2ToolStripMenuItem;
        private ToolStripMenuItem hola2ToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hola1ToolStripMenuItem1;
        private ToolStripMenuItem hola2ToolStripMenuItem1;
        private ToolStripMenuItem hi2ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private PrintDialog printDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private OpenFileDialog openFileDialog1;
        private ImageList imageList1;
        private System.Diagnostics.Process process1;
        private OpenFileDialog openFileDialog2;
        private BindingSource bindingSource1;
        private ToolStripMenuItem documentosToolStripMenuItem;
        private ToolStripMenuItem ventanasToolStripMenuItem;
        private ToolStripMenuItem mantenimientoDePlantillasToolStripMenuItem;
        private ToolStripMenuItem mantenimientoDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }

}
