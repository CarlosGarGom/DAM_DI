namespace GD
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
            this.bibliotecaDataSet = new GD.BibliotecaDataSet();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliolecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new GD.BibliotecaDataSetTableAdapters.lectoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaDataSetBindingSource
            // 
            this.bibliotecaDataSetBindingSource.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlecDataGridViewTextBoxColumn,
            this.nombrelecDataGridViewTextBoxColumn,
            this.domiciliolecDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lectoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idlecDataGridViewTextBoxColumn
            // 
            this.idlecDataGridViewTextBoxColumn.DataPropertyName = "Id_lec";
            this.idlecDataGridViewTextBoxColumn.HeaderText = "Id_lec";
            this.idlecDataGridViewTextBoxColumn.Name = "idlecDataGridViewTextBoxColumn";
            this.idlecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrelecDataGridViewTextBoxColumn
            // 
            this.nombrelecDataGridViewTextBoxColumn.DataPropertyName = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn.HeaderText = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn.Name = "nombrelecDataGridViewTextBoxColumn";
            // 
            // domiciliolecDataGridViewTextBoxColumn
            // 
            this.domiciliolecDataGridViewTextBoxColumn.DataPropertyName = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn.HeaderText = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn.Name = "domiciliolecDataGridViewTextBoxColumn";
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private BibliotecaDataSetTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliolecDataGridViewTextBoxColumn;
    }
}

