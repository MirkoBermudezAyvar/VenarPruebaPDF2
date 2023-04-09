namespace Prueba_pdf.Formularios.OCR
{
    partial class Form_OCR
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
            selectfile = new Button();
            guardarocr = new Button();
            selectimg = new Button();
            btnocr = new Button();
            txtOCR = new TextBox();
            pbxImage = new PictureBox();
            btnword = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            SuspendLayout();
            // 
            // selectfile
            // 
            selectfile.Location = new Point(156, 56);
            selectfile.Name = "selectfile";
            selectfile.Size = new Size(75, 23);
            selectfile.TabIndex = 0;
            selectfile.Text = "select";
            selectfile.UseVisualStyleBackColor = true;
            selectfile.Click += selectfile_Click;
            // 
            // guardarocr
            // 
            guardarocr.Location = new Point(274, 56);
            guardarocr.Name = "guardarocr";
            guardarocr.Size = new Size(75, 23);
            guardarocr.TabIndex = 1;
            guardarocr.Text = "guardar ocr";
            guardarocr.UseVisualStyleBackColor = true;
            guardarocr.Click += guardarocr_Click;
            // 
            // selectimg
            // 
            selectimg.Location = new Point(369, 56);
            selectimg.Name = "selectimg";
            selectimg.Size = new Size(107, 23);
            selectimg.TabIndex = 2;
            selectimg.Text = "selecct imagen";
            selectimg.UseVisualStyleBackColor = true;
            selectimg.Click += selectimg_Click;
            // 
            // btnocr
            // 
            btnocr.Location = new Point(501, 56);
            btnocr.Name = "btnocr";
            btnocr.Size = new Size(102, 23);
            btnocr.TabIndex = 3;
            btnocr.Text = "bnutton ocr";
            btnocr.UseVisualStyleBackColor = true;
            btnocr.Click += btnocr_Click;
            // 
            // txtOCR
            // 
            txtOCR.Location = new Point(171, 134);
            txtOCR.Name = "txtOCR";
            txtOCR.Size = new Size(535, 23);
            txtOCR.TabIndex = 4;
            // 
            // pbxImage
            // 
            pbxImage.Location = new Point(171, 182);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(221, 112);
            pbxImage.TabIndex = 5;
            pbxImage.TabStop = false;
            // 
            // btnword
            // 
            btnword.Location = new Point(631, 56);
            btnword.Name = "btnword";
            btnword.Size = new Size(75, 23);
            btnword.TabIndex = 6;
            btnword.Text = "Convertir WORD";
            btnword.UseVisualStyleBackColor = true;
            btnword.Click += btnword_Click;
            // 
            // Form_OCR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnword);
            Controls.Add(pbxImage);
            Controls.Add(txtOCR);
            Controls.Add(btnocr);
            Controls.Add(selectimg);
            Controls.Add(guardarocr);
            Controls.Add(selectfile);
            Name = "Form_OCR";
            Text = "Form_OCR";
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectfile;
        private Button guardarocr;
        private Button selectimg;
        private Button btnocr;
        private TextBox txtOCR;
        private PictureBox pbxImage;
        private Button btnword;
    }
}