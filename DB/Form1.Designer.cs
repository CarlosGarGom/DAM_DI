namespace DB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId_lec = new System.Windows.Forms.TextBox();
            this.tbNom_lec = new System.Windows.Forms.TextBox();
            this.tbDom_lec = new System.Windows.Forms.TextBox();
            this.lectoresDS = new DB.LectoresDS();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new DB.LectoresDSTableAdapters.lectoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domicilio";
            // 
            // tbId_lec
            // 
            this.tbId_lec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "Id_lec", true));
            this.tbId_lec.Location = new System.Drawing.Point(158, 50);
            this.tbId_lec.Name = "tbId_lec";
            this.tbId_lec.Size = new System.Drawing.Size(100, 20);
            this.tbId_lec.TabIndex = 3;
            // 
            // tbNom_lec
            // 
            this.tbNom_lec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.tbNom_lec.Location = new System.Drawing.Point(158, 100);
            this.tbNom_lec.Name = "tbNom_lec";
            this.tbNom_lec.Size = new System.Drawing.Size(100, 20);
            this.tbNom_lec.TabIndex = 4;
            // 
            // tbDom_lec
            // 
            this.tbDom_lec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.tbDom_lec.Location = new System.Drawing.Point(158, 157);
            this.tbDom_lec.Name = "tbDom_lec";
            this.tbDom_lec.Size = new System.Drawing.Size(100, 20);
            this.tbDom_lec.TabIndex = 5;
            // 
            // lectoresDS
            // 
            this.lectoresDS.DataSetName = "LectoresDS";
            this.lectoresDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.lectoresDS;
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
            this.Controls.Add(this.tbDom_lec);
            this.Controls.Add(this.tbNom_lec);
            this.Controls.Add(this.tbId_lec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId_lec;
        private System.Windows.Forms.TextBox tbNom_lec;
        private System.Windows.Forms.TextBox tbDom_lec;
        private LectoresDS lectoresDS;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private LectoresDSTableAdapters.lectoresTableAdapter lectoresTableAdapter;
    }
}

