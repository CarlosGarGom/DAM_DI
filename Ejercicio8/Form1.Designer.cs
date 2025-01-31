namespace Ejercicio8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bibliotecaDataSet = new Ejercicio8.BibliotecaDataSet();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new Ejercicio8.BibliotecaDataSetTableAdapters.lectoresTableAdapter();
            this.idlecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliolecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Ejercicio8.BibliotecaDataSetTableAdapters.librosTableAdapter();
            this.idlibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulolibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorlibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestadosnlibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLectores = new System.Windows.Forms.DataGridView();
            this.lectoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idlecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliolecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.librosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idlibDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulolibDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorlibDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestadosnlibDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // idlecDataGridViewTextBoxColumn
            // 
            this.idlecDataGridViewTextBoxColumn.Name = "idlecDataGridViewTextBoxColumn";
            // 
            // nombrelecDataGridViewTextBoxColumn
            // 
            this.nombrelecDataGridViewTextBoxColumn.Name = "nombrelecDataGridViewTextBoxColumn";
            // 
            // domiciliolecDataGridViewTextBoxColumn
            // 
            this.domiciliolecDataGridViewTextBoxColumn.Name = "domiciliolecDataGridViewTextBoxColumn";
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // idlibDataGridViewTextBoxColumn
            // 
            this.idlibDataGridViewTextBoxColumn.Name = "idlibDataGridViewTextBoxColumn";
            // 
            // titulolibDataGridViewTextBoxColumn
            // 
            this.titulolibDataGridViewTextBoxColumn.Name = "titulolibDataGridViewTextBoxColumn";
            // 
            // autorlibDataGridViewTextBoxColumn
            // 
            this.autorlibDataGridViewTextBoxColumn.Name = "autorlibDataGridViewTextBoxColumn";
            // 
            // prestadosnlibDataGridViewTextBoxColumn
            // 
            this.prestadosnlibDataGridViewTextBoxColumn.Name = "prestadosnlibDataGridViewTextBoxColumn";
            // 
            // dgvLectores
            // 
            this.dgvLectores.AllowUserToDeleteRows = false;
            this.dgvLectores.AutoGenerateColumns = false;
            this.dgvLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlecDataGridViewTextBoxColumn1,
            this.nombrelecDataGridViewTextBoxColumn1,
            this.domiciliolecDataGridViewTextBoxColumn1});
            this.dgvLectores.DataSource = this.lectoresBindingSource1;
            this.dgvLectores.Location = new System.Drawing.Point(12, 24);
            this.dgvLectores.Name = "dgvLectores";
            this.dgvLectores.Size = new System.Drawing.Size(348, 150);
            this.dgvLectores.TabIndex = 0;
            // 
            // lectoresBindingSource1
            // 
            this.lectoresBindingSource1.DataMember = "lectores";
            this.lectoresBindingSource1.DataSource = this.bibliotecaDataSet;
            // 
            // idlecDataGridViewTextBoxColumn1
            // 
            this.idlecDataGridViewTextBoxColumn1.DataPropertyName = "Id_lec";
            this.idlecDataGridViewTextBoxColumn1.HeaderText = "Id_lec";
            this.idlecDataGridViewTextBoxColumn1.Name = "idlecDataGridViewTextBoxColumn1";
            this.idlecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombrelecDataGridViewTextBoxColumn1
            // 
            this.nombrelecDataGridViewTextBoxColumn1.DataPropertyName = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn1.HeaderText = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn1.Name = "nombrelecDataGridViewTextBoxColumn1";
            // 
            // domiciliolecDataGridViewTextBoxColumn1
            // 
            this.domiciliolecDataGridViewTextBoxColumn1.DataPropertyName = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn1.HeaderText = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn1.Name = "domiciliolecDataGridViewTextBoxColumn1";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AutoGenerateColumns = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibDataGridViewTextBoxColumn1,
            this.titulolibDataGridViewTextBoxColumn1,
            this.autorlibDataGridViewTextBoxColumn1,
            this.prestadosnlibDataGridViewTextBoxColumn1});
            this.dgvLibros.DataSource = this.librosBindingSource1;
            this.dgvLibros.Location = new System.Drawing.Point(12, 209);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(446, 150);
            this.dgvLibros.TabIndex = 1;
            // 
            // librosBindingSource1
            // 
            this.librosBindingSource1.DataMember = "libros";
            this.librosBindingSource1.DataSource = this.bibliotecaDataSet;
            // 
            // idlibDataGridViewTextBoxColumn1
            // 
            this.idlibDataGridViewTextBoxColumn1.DataPropertyName = "Id_lib";
            this.idlibDataGridViewTextBoxColumn1.HeaderText = "Id_lib";
            this.idlibDataGridViewTextBoxColumn1.Name = "idlibDataGridViewTextBoxColumn1";
            this.idlibDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titulolibDataGridViewTextBoxColumn1
            // 
            this.titulolibDataGridViewTextBoxColumn1.DataPropertyName = "titulo_lib";
            this.titulolibDataGridViewTextBoxColumn1.HeaderText = "titulo_lib";
            this.titulolibDataGridViewTextBoxColumn1.Name = "titulolibDataGridViewTextBoxColumn1";
            // 
            // autorlibDataGridViewTextBoxColumn1
            // 
            this.autorlibDataGridViewTextBoxColumn1.DataPropertyName = "autor_lib";
            this.autorlibDataGridViewTextBoxColumn1.HeaderText = "autor_lib";
            this.autorlibDataGridViewTextBoxColumn1.Name = "autorlibDataGridViewTextBoxColumn1";
            // 
            // prestadosnlibDataGridViewTextBoxColumn1
            // 
            this.prestadosnlibDataGridViewTextBoxColumn1.DataPropertyName = "prestado_sn_lib";
            this.prestadosnlibDataGridViewTextBoxColumn1.HeaderText = "prestado_sn_lib";
            this.prestadosnlibDataGridViewTextBoxColumn1.Name = "prestadosnlibDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 600);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.dgvLectores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private BibliotecaDataSetTableAdapters.lectoresTableAdapter lectoresTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliolecDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.librosTableAdapter librosTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorlibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestadosnlibDataGridViewTextBoxColumn;
        private BibliotecaDataSetTableAdapters.librosTableAdapter librosTableAdapter;
        private BibliotecaDataSetTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.DataGridView dgvLectores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliolecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource lectoresBindingSource1;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolibDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorlibDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestadosnlibDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource librosBindingSource1;
    }
}

