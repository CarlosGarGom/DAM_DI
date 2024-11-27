namespace Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbIzquierda = new ListBox();
            tbIzquierda = new TextBox();
            bAñadirIzquierda = new Button();
            bAñadirDerecha = new Button();
            tbDerecha = new TextBox();
            lbDerecha = new ListBox();
            bMoverIzquierda = new Button();
            bMoverTodosIzquierda = new Button();
            bMoverTodosDerecha = new Button();
            bMoverDerecha = new Button();
            SuspendLayout();
            // 
            // lbIzquierda
            // 
            lbIzquierda.FormattingEnabled = true;
            resources.ApplyResources(lbIzquierda, "lbIzquierda");
            lbIzquierda.Name = "lbIzquierda";
            // 
            // tbIzquierda
            // 
            resources.ApplyResources(tbIzquierda, "tbIzquierda");
            tbIzquierda.Name = "tbIzquierda";
            // 
            // bAñadirIzquierda
            // 
            resources.ApplyResources(bAñadirIzquierda, "bAñadirIzquierda");
            bAñadirIzquierda.Name = "bAñadirIzquierda";
            bAñadirIzquierda.UseVisualStyleBackColor = true;
            bAñadirIzquierda.Click += AñadirIzquierda_Click;
            // 
            // bAñadirDerecha
            // 
            resources.ApplyResources(bAñadirDerecha, "bAñadirDerecha");
            bAñadirDerecha.Name = "bAñadirDerecha";
            bAñadirDerecha.UseVisualStyleBackColor = true;
            bAñadirDerecha.Click += AñadirDerecha_Click;
            // 
            // tbDerecha
            // 
            resources.ApplyResources(tbDerecha, "tbDerecha");
            tbDerecha.Name = "tbDerecha";
            // 
            // lbDerecha
            // 
            lbDerecha.FormattingEnabled = true;
            resources.ApplyResources(lbDerecha, "lbDerecha");
            lbDerecha.Name = "lbDerecha";
            lbDerecha.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // bMoverIzquierda
            // 
            resources.ApplyResources(bMoverIzquierda, "bMoverIzquierda");
            bMoverIzquierda.Name = "bMoverIzquierda";
            bMoverIzquierda.UseVisualStyleBackColor = true;
            bMoverIzquierda.Click += UnoDerechaIzquierda_Click;
            // 
            // bMoverTodosIzquierda
            // 
            resources.ApplyResources(bMoverTodosIzquierda, "bMoverTodosIzquierda");
            bMoverTodosIzquierda.Name = "bMoverTodosIzquierda";
            bMoverTodosIzquierda.UseVisualStyleBackColor = true;
            bMoverTodosIzquierda.Click += TodosDerechaIzquierda_Click;
            // 
            // bMoverTodosDerecha
            // 
            resources.ApplyResources(bMoverTodosDerecha, "bMoverTodosDerecha");
            bMoverTodosDerecha.Name = "bMoverTodosDerecha";
            bMoverTodosDerecha.UseVisualStyleBackColor = true;
            bMoverTodosDerecha.Click += TodosIzquierdaDerecha_Click;
            // 
            // bMoverDerecha
            // 
            resources.ApplyResources(bMoverDerecha, "bMoverDerecha");
            bMoverDerecha.Name = "bMoverDerecha";
            bMoverDerecha.UseVisualStyleBackColor = true;
            bMoverDerecha.Click += UnoIzquierdaDerecha_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bMoverDerecha);
            Controls.Add(bMoverTodosDerecha);
            Controls.Add(bMoverTodosIzquierda);
            Controls.Add(bMoverIzquierda);
            Controls.Add(bAñadirDerecha);
            Controls.Add(tbDerecha);
            Controls.Add(lbDerecha);
            Controls.Add(bAñadirIzquierda);
            Controls.Add(tbIzquierda);
            Controls.Add(lbIzquierda);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbIzquierda;
        private TextBox tbIzquierda;
        private Button bAñadirIzquierda;
        private Button bAñadirDerecha;
        private TextBox tbDerecha;
        private ListBox lbDerecha;
        private Button bMoverIzquierda;
        private Button bMoverTodosIzquierda;
        private Button bMoverTodosDerecha;
        private Button bMoverDerecha;
    }
}
