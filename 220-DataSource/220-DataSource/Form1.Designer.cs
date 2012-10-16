namespace _220_DataSource
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label cOD_PESSOALabel;
            System.Windows.Forms.Label nOME_PESSOALabel;
            System.Windows.Forms.Label sEXO_PESSOALabel;
            this.dataSet1 = new _220_DataSource.DataSet1();
            this.pESSOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOATableAdapter = new _220_DataSource.DataSet1TableAdapters.PESSOATableAdapter();
            this.tableAdapterManager = new _220_DataSource.DataSet1TableAdapters.TableAdapterManager();
            this.pESSOABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pESSOABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cOD_PESSOATextBox = new System.Windows.Forms.TextBox();
            this.nOME_PESSOATextBox = new System.Windows.Forms.TextBox();
            this.sEXO_PESSOATextBox = new System.Windows.Forms.TextBox();
            cOD_PESSOALabel = new System.Windows.Forms.Label();
            nOME_PESSOALabel = new System.Windows.Forms.Label();
            sEXO_PESSOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingNavigator)).BeginInit();
            this.pESSOABindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pESSOABindingSource
            // 
            this.pESSOABindingSource.DataMember = "PESSOA";
            this.pESSOABindingSource.DataSource = this.dataSet1;
            // 
            // pESSOATableAdapter
            // 
            this.pESSOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PESSOATableAdapter = this.pESSOATableAdapter;
            this.tableAdapterManager.UpdateOrder = _220_DataSource.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pESSOABindingNavigator
            // 
            this.pESSOABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pESSOABindingNavigator.BindingSource = this.pESSOABindingSource;
            this.pESSOABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pESSOABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pESSOABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pESSOABindingNavigatorSaveItem});
            this.pESSOABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pESSOABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pESSOABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pESSOABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pESSOABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pESSOABindingNavigator.Name = "pESSOABindingNavigator";
            this.pESSOABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pESSOABindingNavigator.Size = new System.Drawing.Size(388, 25);
            this.pESSOABindingNavigator.TabIndex = 0;
            this.pESSOABindingNavigator.Text = "bindingNavigator1";
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
            // pESSOABindingNavigatorSaveItem
            // 
            this.pESSOABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pESSOABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pESSOABindingNavigatorSaveItem.Image")));
            this.pESSOABindingNavigatorSaveItem.Name = "pESSOABindingNavigatorSaveItem";
            this.pESSOABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pESSOABindingNavigatorSaveItem.Text = "Save Data";
            this.pESSOABindingNavigatorSaveItem.Click += new System.EventHandler(this.pESSOABindingNavigatorSaveItem_Click_1);
            // 
            // cOD_PESSOALabel
            // 
            cOD_PESSOALabel.AutoSize = true;
            cOD_PESSOALabel.Location = new System.Drawing.Point(17, 38);
            cOD_PESSOALabel.Name = "cOD_PESSOALabel";
            cOD_PESSOALabel.Size = new System.Drawing.Size(79, 13);
            cOD_PESSOALabel.TabIndex = 1;
            cOD_PESSOALabel.Text = "COD PESSOA:";
            // 
            // cOD_PESSOATextBox
            // 
            this.cOD_PESSOATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOABindingSource, "COD_PESSOA", true));
            this.cOD_PESSOATextBox.Location = new System.Drawing.Point(111, 35);
            this.cOD_PESSOATextBox.Name = "cOD_PESSOATextBox";
            this.cOD_PESSOATextBox.Size = new System.Drawing.Size(64, 20);
            this.cOD_PESSOATextBox.TabIndex = 2;
            // 
            // nOME_PESSOALabel
            // 
            nOME_PESSOALabel.AutoSize = true;
            nOME_PESSOALabel.Location = new System.Drawing.Point(17, 64);
            nOME_PESSOALabel.Name = "nOME_PESSOALabel";
            nOME_PESSOALabel.Size = new System.Drawing.Size(88, 13);
            nOME_PESSOALabel.TabIndex = 3;
            nOME_PESSOALabel.Text = "NOME PESSOA:";
            // 
            // nOME_PESSOATextBox
            // 
            this.nOME_PESSOATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOABindingSource, "NOME_PESSOA", true));
            this.nOME_PESSOATextBox.Location = new System.Drawing.Point(111, 61);
            this.nOME_PESSOATextBox.Name = "nOME_PESSOATextBox";
            this.nOME_PESSOATextBox.Size = new System.Drawing.Size(248, 20);
            this.nOME_PESSOATextBox.TabIndex = 4;
            // 
            // sEXO_PESSOALabel
            // 
            sEXO_PESSOALabel.AutoSize = true;
            sEXO_PESSOALabel.Location = new System.Drawing.Point(17, 90);
            sEXO_PESSOALabel.Name = "sEXO_PESSOALabel";
            sEXO_PESSOALabel.Size = new System.Drawing.Size(85, 13);
            sEXO_PESSOALabel.TabIndex = 5;
            sEXO_PESSOALabel.Text = "SEXO PESSOA:";
            // 
            // sEXO_PESSOATextBox
            // 
            this.sEXO_PESSOATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOABindingSource, "SEXO_PESSOA", true));
            this.sEXO_PESSOATextBox.Location = new System.Drawing.Point(111, 87);
            this.sEXO_PESSOATextBox.Name = "sEXO_PESSOATextBox";
            this.sEXO_PESSOATextBox.Size = new System.Drawing.Size(100, 20);
            this.sEXO_PESSOATextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 320);
            this.Controls.Add(cOD_PESSOALabel);
            this.Controls.Add(this.cOD_PESSOATextBox);
            this.Controls.Add(nOME_PESSOALabel);
            this.Controls.Add(this.nOME_PESSOATextBox);
            this.Controls.Add(sEXO_PESSOALabel);
            this.Controls.Add(this.sEXO_PESSOATextBox);
            this.Controls.Add(this.pESSOABindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingNavigator)).EndInit();
            this.pESSOABindingNavigator.ResumeLayout(false);
            this.pESSOABindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pESSOABindingSource;
        private DataSet1TableAdapters.PESSOATableAdapter pESSOATableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pESSOABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pESSOABindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cOD_PESSOATextBox;
        private System.Windows.Forms.TextBox nOME_PESSOATextBox;
        private System.Windows.Forms.TextBox sEXO_PESSOATextBox;

    }
}

