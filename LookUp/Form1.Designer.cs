namespace LookUp
{
    partial class AñadirOrdenes
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
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            System.Windows.Forms.Label shipViaLabel;
            System.Windows.Forms.Label freightLabel;
            System.Windows.Forms.Label shipNameLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label shipCityLabel;
            System.Windows.Forms.Label shipRegionLabel;
            System.Windows.Forms.Label shipPostalCodeLabel;
            System.Windows.Forms.Label shipCountryLabel;
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLookUpCustomers = new System.Windows.Forms.Button();
            this.bLookUpEmpleados = new System.Windows.Forms.Button();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDS = new LookUp.OrdersDS();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipViaTextBox = new System.Windows.Forms.TextBox();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.shipNameTextBox = new System.Windows.Forms.TextBox();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.shipRegionTextBox = new System.Windows.Forms.TextBox();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.clientesDS = new LookUp.ClientesDS();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new LookUp.ClientesDSTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new LookUp.ClientesDSTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new LookUp.OrdersDSTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager1 = new LookUp.OrdersDSTableAdapters.TableAdapterManager();
            this.bLookUpEmpleados2 = new System.Windows.Forms.Button();
            orderIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            shipViaLabel = new System.Windows.Forms.Label();
            freightLabel = new System.Windows.Forms.Label();
            shipNameLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            shipCityLabel = new System.Windows.Forms.Label();
            shipRegionLabel = new System.Windows.Forms.Label();
            shipPostalCodeLabel = new System.Windows.Forms.Label();
            shipCountryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(12, 31);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 26;
            orderIDLabel.Text = "Order ID:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 57);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 28;
            customerIDLabel.Text = "Customer ID:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(12, 83);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 30;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(12, 110);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 32;
            orderDateLabel.Text = "Order Date:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(12, 136);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 34;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(12, 162);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 36;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shipViaLabel
            // 
            shipViaLabel.AutoSize = true;
            shipViaLabel.Location = new System.Drawing.Point(12, 187);
            shipViaLabel.Name = "shipViaLabel";
            shipViaLabel.Size = new System.Drawing.Size(49, 13);
            shipViaLabel.TabIndex = 38;
            shipViaLabel.Text = "Ship Via:";
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(12, 213);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(42, 13);
            freightLabel.TabIndex = 40;
            freightLabel.Text = "Freight:";
            // 
            // shipNameLabel
            // 
            shipNameLabel.AutoSize = true;
            shipNameLabel.Location = new System.Drawing.Point(12, 239);
            shipNameLabel.Name = "shipNameLabel";
            shipNameLabel.Size = new System.Drawing.Size(62, 13);
            shipNameLabel.TabIndex = 42;
            shipNameLabel.Text = "Ship Name:";
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(12, 265);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(72, 13);
            shipAddressLabel.TabIndex = 44;
            shipAddressLabel.Text = "Ship Address:";
            // 
            // shipCityLabel
            // 
            shipCityLabel.AutoSize = true;
            shipCityLabel.Location = new System.Drawing.Point(12, 291);
            shipCityLabel.Name = "shipCityLabel";
            shipCityLabel.Size = new System.Drawing.Size(51, 13);
            shipCityLabel.TabIndex = 46;
            shipCityLabel.Text = "Ship City:";
            // 
            // shipRegionLabel
            // 
            shipRegionLabel.AutoSize = true;
            shipRegionLabel.Location = new System.Drawing.Point(12, 317);
            shipRegionLabel.Name = "shipRegionLabel";
            shipRegionLabel.Size = new System.Drawing.Size(68, 13);
            shipRegionLabel.TabIndex = 48;
            shipRegionLabel.Text = "Ship Region:";
            // 
            // shipPostalCodeLabel
            // 
            shipPostalCodeLabel.AutoSize = true;
            shipPostalCodeLabel.Location = new System.Drawing.Point(12, 343);
            shipPostalCodeLabel.Name = "shipPostalCodeLabel";
            shipPostalCodeLabel.Size = new System.Drawing.Size(91, 13);
            shipPostalCodeLabel.TabIndex = 50;
            shipPostalCodeLabel.Text = "Ship Postal Code:";
            // 
            // shipCountryLabel
            // 
            shipCountryLabel.AutoSize = true;
            shipCountryLabel.Location = new System.Drawing.Point(12, 369);
            shipCountryLabel.Name = "shipCountryLabel";
            shipCountryLabel.Size = new System.Drawing.Size(70, 13);
            shipCountryLabel.TabIndex = 52;
            shipCountryLabel.Text = "Ship Country:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(341, 109);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 23;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(341, 165);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 24;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLookUpCustomers
            // 
            this.bLookUpCustomers.Location = new System.Drawing.Point(341, 213);
            this.bLookUpCustomers.Name = "bLookUpCustomers";
            this.bLookUpCustomers.Size = new System.Drawing.Size(75, 23);
            this.bLookUpCustomers.TabIndex = 25;
            this.bLookUpCustomers.Text = "Clientes";
            this.bLookUpCustomers.UseVisualStyleBackColor = true;
            this.bLookUpCustomers.Click += new System.EventHandler(this.bLookUpCustomers_Click);
            // 
            // bLookUpEmpleados
            // 
            this.bLookUpEmpleados.Location = new System.Drawing.Point(0, 0);
            this.bLookUpEmpleados.Name = "bLookUpEmpleados";
            this.bLookUpEmpleados.Size = new System.Drawing.Size(75, 23);
            this.bLookUpEmpleados.TabIndex = 54;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(109, 28);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderIDTextBox.TabIndex = 27;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersDS;
            // 
            // ordersDS
            // 
            this.ordersDS.DataSetName = "OrdersDS";
            this.ordersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(109, 54);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerIDTextBox.TabIndex = 29;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(109, 80);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.employeeIDTextBox.TabIndex = 31;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(109, 106);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateDateTimePicker.TabIndex = 33;
            // 
            // requiredDateDateTimePicker
            // 
            this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "RequiredDate", true));
            this.requiredDateDateTimePicker.Location = new System.Drawing.Point(109, 132);
            this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
            this.requiredDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requiredDateDateTimePicker.TabIndex = 35;
            // 
            // shippedDateDateTimePicker
            // 
            this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ShippedDate", true));
            this.shippedDateDateTimePicker.Location = new System.Drawing.Point(109, 158);
            this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
            this.shippedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shippedDateDateTimePicker.TabIndex = 37;
            // 
            // shipViaTextBox
            // 
            this.shipViaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipVia", true));
            this.shipViaTextBox.Location = new System.Drawing.Point(109, 184);
            this.shipViaTextBox.Name = "shipViaTextBox";
            this.shipViaTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipViaTextBox.TabIndex = 39;
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Freight", true));
            this.freightTextBox.Location = new System.Drawing.Point(109, 210);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(200, 20);
            this.freightTextBox.TabIndex = 41;
            // 
            // shipNameTextBox
            // 
            this.shipNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipName", true));
            this.shipNameTextBox.Location = new System.Drawing.Point(109, 236);
            this.shipNameTextBox.Name = "shipNameTextBox";
            this.shipNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipNameTextBox.TabIndex = 43;
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(109, 262);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipAddressTextBox.TabIndex = 45;
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCity", true));
            this.shipCityTextBox.Location = new System.Drawing.Point(109, 288);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipCityTextBox.TabIndex = 47;
            // 
            // shipRegionTextBox
            // 
            this.shipRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipRegion", true));
            this.shipRegionTextBox.Location = new System.Drawing.Point(109, 314);
            this.shipRegionTextBox.Name = "shipRegionTextBox";
            this.shipRegionTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipRegionTextBox.TabIndex = 49;
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipPostalCode", true));
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(109, 340);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipPostalCodeTextBox.TabIndex = 51;
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCountry", true));
            this.shipCountryTextBox.Location = new System.Drawing.Point(109, 366);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipCountryTextBox.TabIndex = 53;
            // 
            // clientesDS
            // 
            this.clientesDS.DataSetName = "ClientesDS";
            this.clientesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.clientesDS;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = LookUp.ClientesDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager1.UpdateOrder = LookUp.OrdersDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bLookUpEmpleados2
            // 
            this.bLookUpEmpleados2.Location = new System.Drawing.Point(341, 265);
            this.bLookUpEmpleados2.Name = "bLookUpEmpleados2";
            this.bLookUpEmpleados2.Size = new System.Drawing.Size(75, 23);
            this.bLookUpEmpleados2.TabIndex = 55;
            this.bLookUpEmpleados2.Text = "Empleados";
            this.bLookUpEmpleados2.UseVisualStyleBackColor = true;
            this.bLookUpEmpleados2.Click += new System.EventHandler(this.bLookUpEmpleados2_Click);
            // 
            // AñadirOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 481);
            this.Controls.Add(this.bLookUpEmpleados2);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateDateTimePicker);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.shippedDateDateTimePicker);
            this.Controls.Add(shipViaLabel);
            this.Controls.Add(this.shipViaTextBox);
            this.Controls.Add(freightLabel);
            this.Controls.Add(this.freightTextBox);
            this.Controls.Add(shipNameLabel);
            this.Controls.Add(this.shipNameTextBox);
            this.Controls.Add(shipAddressLabel);
            this.Controls.Add(this.shipAddressTextBox);
            this.Controls.Add(shipCityLabel);
            this.Controls.Add(this.shipCityTextBox);
            this.Controls.Add(shipRegionLabel);
            this.Controls.Add(this.shipRegionTextBox);
            this.Controls.Add(shipPostalCodeLabel);
            this.Controls.Add(this.shipPostalCodeTextBox);
            this.Controls.Add(shipCountryLabel);
            this.Controls.Add(this.shipCountryTextBox);
            this.Controls.Add(this.bLookUpEmpleados);
            this.Controls.Add(this.bLookUpCustomers);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "AñadirOrdenes";
            this.Text = "Alta Pedido";
            this.Load += new System.EventHandler(this.AñadirOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientesDS clientesDS;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ClientesDSTableAdapters.CustomersTableAdapter customersTableAdapter;
        private ClientesDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLookUpCustomers;
        private System.Windows.Forms.Button bLookUpEmpleados;
        private OrdersDS ordersDS;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrdersDSTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private OrdersDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
        private System.Windows.Forms.TextBox shipViaTextBox;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.TextBox shipNameTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.TextBox shipRegionTextBox;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.Button bLookUpEmpleados2;
    }
}

