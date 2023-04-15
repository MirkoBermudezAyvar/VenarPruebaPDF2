using Microsoft.Data.SqlClient;
using Prueba_pdf.Formularios;
using Prueba_pdf.Formularios.OCR;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Prueba_pdf
{
    public partial class Form1 : Form
    {
        private string currentDirectory;
        private static readonly string connectionString = "Data Source=DESKTOP-UFQBKNN\\MIRKO;TrustServerCertificate=True;Initial Catalog=BD_ARCHIVOS_VENAR;User Id=sa;Password=piloto;";
        private void MostrarArchivos(string directorio)
        {
            //listView1.Items.Clear();

            currentDirectory = directorio;

            try
            {
                string[] dirs = Directory.GetDirectories(directorio);
                foreach (string dir in dirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    ListViewItem item = new ListViewItem(di.Name, 0);
                    item.SubItems.Add("Folder");
                    item.SubItems.Add(di.LastAccessTime.ToString());
                    //listView1.Items.Add(item);
                }

                string[] files = Directory.GetFiles(directorio);
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    ListViewItem item = new ListViewItem(fi.Name, 1);
                    item.SubItems.Add(fi.Extension);
                    item.SubItems.Add(fi.LastAccessTime.ToString());
                    //listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Form1()
        {

            InitializeComponent();

            CrearCarpetas();

            string path2 = Path.Combine(Application.StartupPath, "imagenes\\carpeta.png");
            ImageList imageList = new ImageList();
            imageList.Images.Add("Folder", Image.FromFile("D:\\PROYECTOS_VS\\Prueba_pdf\\Prueba_pdf\\imagenes\\carpeta.png")); // El nombre "Folder" se usa como clave para recuperar esta imagen en el futuro
            //treeView1.ImageList = imageList;
            string path = @"D:\CarpetasPDF"; // Ruta del directorio que desea mostrar
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            TreeNode rootNode = new TreeNode(dirInfo.Name);
            rootNode.Tag = dirInfo;
            GetDirectories(dirInfo.GetDirectories(), rootNode);
            //treeView1.Nodes.Add(rootNode);

            // Configura el ListView en modo de detalle
            //listView1.View = View.Details;

            //// Agrega las columnas al ListView
            //listView1.Columns.Add("Nombre", 200);
            //listView1.Columns.Add("Fecha de modificación", 120);
            //listView1.Columns.Add("Tipo", 80);
            //listView1.Columns.Add("Tamaño", 80);
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "Folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string ruta = e.Node.FullPath;
            if (ruta.StartsWith(@"\")) ruta = ruta.Substring(1);
            ruta = @"D:\" + ruta;

            //listView1.Clear();
            //listView1.Columns.Add("Nombre", 200); // Columna para el nombre de la subcarpeta
            //listView1.Columns.Add("Fecha de creación", 150); // Columna para la fecha de creación de la subcarpeta
            MostrarArchivos(e.Node.FullPath);
            try
            {
                string[] subDirectorios = Directory.GetDirectories(ruta);
                foreach (string subDirectorio in subDirectorios)
                {
                    string nombreDirectorio = Path.GetFileName(subDirectorio);
                    string fechaCreacion = Directory.GetCreationTime(subDirectorio).ToString();
                    ListViewItem item = new ListViewItem(new string[] { nombreDirectorio, fechaCreacion });
                    //listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void listView1_ItemActivate_1(object sender, EventArgs e)


        {
            ////ListViewItem selectedItem = listView1.SelectedItems[0];

            //if (selectedItem.SubItems[1].Text == "Folder")
            //{
            //    string newDirectory = Path.Combine(currentDirectory, selectedItem.Text);
            //    MostrarArchivos(newDirectory);
            //}
            //else
            //{
            //    string fileName = selectedItem.Text;
            //    string filePath = Path.Combine(currentDirectory, fileName);
            //    MessageBox.Show($"Abriendo archivo {filePath}");
            //}
        }

        private void CrearCarpetas()
        {
            // Generar un número aleatorio de subcarpetas
            Random random = new Random();
            int numSubcarpetas = random.Next(1, 11);

            // Crear la carpeta principal
            string carpetaPrincipal = @"D:\CarpetasPDF";
            if (!Directory.Exists(carpetaPrincipal))
            {
                Directory.CreateDirectory(carpetaPrincipal);
            }

            // Crear las subcarpetas con nombres generados automáticamente
            for (int i = 1; i <= numSubcarpetas; i++)
            {
                string nombreSubcarpeta = "F00" + i.ToString();
                string rutaSubcarpeta = Path.Combine(carpetaPrincipal, nombreSubcarpeta);
                Directory.CreateDirectory(rutaSubcarpeta);

            }
        }

        private void mantenimientoDePlantillasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Mantenimiento_Plan form2 = new Form_Mantenimiento_Plan();
            form2.ShowDialog();


        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OCR form3 = new Form_OCR();
            form3.ShowDialog();

        }
    }


}
