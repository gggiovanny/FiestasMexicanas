namespace FiestasMexicanas
{
    partial class Pruebas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pruebas));
            this.fiestasMexicanasDataSet = new FiestasMexicanas.FiestasMexicanasDataSet();
            this.v_COTIZACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_COTIZACIONESTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_COTIZACIONESTableAdapter();
            this.tableAdapterManager = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager();
            this.v_COTIZACIONESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.v_COTIZACIONESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.v_COTIZACIONESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESBindingNavigator)).BeginInit();
            this.v_COTIZACIONESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fiestasMexicanasDataSet
            // 
            this.fiestasMexicanasDataSet.DataSetName = "FiestasMexicanasDataSet";
            this.fiestasMexicanasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_COTIZACIONESBindingSource
            // 
            this.v_COTIZACIONESBindingSource.DataMember = "v_COTIZACIONES";
            this.v_COTIZACIONESBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_COTIZACIONESTableAdapter
            // 
            this.v_COTIZACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTESANOS_PEDIDOSTableAdapter = null;
            this.tableAdapterManager.ARTESANOSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATALOGO_CIUDADESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_CLIENTESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_EMPLEADOS_PUESTOSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_EMPLEADOSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_ESTADOSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_PAISESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_PEDIDO_ESTATUSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_PROVEEDORESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_TAMANO_PINATATableAdapter = null;
            this.tableAdapterManager.CATALOGO_TIPO_PINATATableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PEDIDO_PINATATableAdapter = null;
            this.tableAdapterManager.PRECIO_PINATATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_SISTEMATableAdapter = null;
            // 
            // v_COTIZACIONESBindingNavigator
            // 
            this.v_COTIZACIONESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.v_COTIZACIONESBindingNavigator.BindingSource = this.v_COTIZACIONESBindingSource;
            this.v_COTIZACIONESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.v_COTIZACIONESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.v_COTIZACIONESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.v_COTIZACIONESBindingNavigatorSaveItem});
            this.v_COTIZACIONESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.v_COTIZACIONESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.v_COTIZACIONESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.v_COTIZACIONESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.v_COTIZACIONESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.v_COTIZACIONESBindingNavigator.Name = "v_COTIZACIONESBindingNavigator";
            this.v_COTIZACIONESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.v_COTIZACIONESBindingNavigator.Size = new System.Drawing.Size(1150, 25);
            this.v_COTIZACIONESBindingNavigator.TabIndex = 0;
            this.v_COTIZACIONESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // v_COTIZACIONESBindingNavigatorSaveItem
            // 
            this.v_COTIZACIONESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.v_COTIZACIONESBindingNavigatorSaveItem.Enabled = false;
            this.v_COTIZACIONESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("v_COTIZACIONESBindingNavigatorSaveItem.Image")));
            this.v_COTIZACIONESBindingNavigatorSaveItem.Name = "v_COTIZACIONESBindingNavigatorSaveItem";
            this.v_COTIZACIONESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.v_COTIZACIONESBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // v_COTIZACIONESDataGridView
            // 
            this.v_COTIZACIONESDataGridView.AutoGenerateColumns = false;
            this.v_COTIZACIONESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_COTIZACIONESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.v_COTIZACIONESDataGridView.DataSource = this.v_COTIZACIONESBindingSource;
            this.v_COTIZACIONESDataGridView.Location = new System.Drawing.Point(51, 58);
            this.v_COTIZACIONESDataGridView.Name = "v_COTIZACIONESDataGridView";
            this.v_COTIZACIONESDataGridView.Size = new System.Drawing.Size(814, 423);
            this.v_COTIZACIONESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tamaño";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tamaño";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Detalle";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Detalle";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Hay molde";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Hay molde";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CLIENTE";
            this.dataGridViewTextBoxColumn5.HeaderText = "CLIENTE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CANTIDAD";
            this.dataGridViewTextBoxColumn6.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Importe venta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Importe venta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Entregado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Entregado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 532);
            this.Controls.Add(this.v_COTIZACIONESDataGridView);
            this.Controls.Add(this.v_COTIZACIONESBindingNavigator);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Pruebas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESBindingNavigator)).EndInit();
            this.v_COTIZACIONESBindingNavigator.ResumeLayout(false);
            this.v_COTIZACIONESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FiestasMexicanasDataSet fiestasMexicanasDataSet;
        private System.Windows.Forms.BindingSource v_COTIZACIONESBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_COTIZACIONESTableAdapter v_COTIZACIONESTableAdapter;
        private FiestasMexicanasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v_COTIZACIONESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton v_COTIZACIONESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView v_COTIZACIONESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}