namespace IRF_Project.UserControls
{
    partial class jatekosokUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jatekosokUC));
            this.arsenalDataSet1 = new IRF_Project.ArsenalDataSet1();
            this.jatékosokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jatékosokTableAdapter = new IRF_Project.ArsenalDataSet1TableAdapters.JatékosokTableAdapter();
            this.tableAdapterManager = new IRF_Project.ArsenalDataSet1TableAdapters.TableAdapterManager();
            this.jatékosokBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.jatékosokBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jatékosokDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felvitelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arsenalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatékosokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatékosokBindingNavigator)).BeginInit();
            this.jatékosokBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jatékosokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // arsenalDataSet1
            // 
            this.arsenalDataSet1.DataSetName = "ArsenalDataSet1";
            this.arsenalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jatékosokBindingSource
            // 
            this.jatékosokBindingSource.DataMember = "Jatékosok";
            this.jatékosokBindingSource.DataSource = this.arsenalDataSet1;
            // 
            // jatékosokTableAdapter
            // 
            this.jatékosokTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JatékosokTableAdapter = this.jatékosokTableAdapter;
            this.tableAdapterManager.UpdateOrder = IRF_Project.ArsenalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jatékosokBindingNavigator
            // 
            this.jatékosokBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jatékosokBindingNavigator.BindingSource = this.jatékosokBindingSource;
            this.jatékosokBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jatékosokBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jatékosokBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.jatékosokBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jatékosokBindingNavigatorSaveItem});
            this.jatékosokBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jatékosokBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jatékosokBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jatékosokBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jatékosokBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jatékosokBindingNavigator.Name = "jatékosokBindingNavigator";
            this.jatékosokBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jatékosokBindingNavigator.Size = new System.Drawing.Size(1300, 27);
            this.jatékosokBindingNavigator.TabIndex = 0;
            this.jatékosokBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // jatékosokBindingNavigatorSaveItem
            // 
            this.jatékosokBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jatékosokBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jatékosokBindingNavigatorSaveItem.Image")));
            this.jatékosokBindingNavigatorSaveItem.Name = "jatékosokBindingNavigatorSaveItem";
            this.jatékosokBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.jatékosokBindingNavigatorSaveItem.Text = "Save Data";
            this.jatékosokBindingNavigatorSaveItem.Click += new System.EventHandler(this.jatékosokBindingNavigatorSaveItem_Click);
            // 
            // jatékosokDataGridView
            // 
            this.jatékosokDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jatékosokDataGridView.AutoGenerateColumns = false;
            this.jatékosokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jatékosokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.jatékosokDataGridView.DataSource = this.jatékosokBindingSource;
            this.jatékosokDataGridView.Location = new System.Drawing.Point(0, 34);
            this.jatékosokDataGridView.Name = "jatékosokDataGridView";
            this.jatékosokDataGridView.RowHeadersWidth = 51;
            this.jatékosokDataGridView.RowTemplate.Height = 24;
            this.jatékosokDataGridView.Size = new System.Drawing.Size(1300, 373);
            this.jatékosokDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Mezszám";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mezszám";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Név";
            this.dataGridViewTextBoxColumn2.HeaderText = "Név";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pozició";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pozició";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gól";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gól";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Gólpassz";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gólpassz";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // felvitelButton
            // 
            this.felvitelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.felvitelButton.Location = new System.Drawing.Point(970, 513);
            this.felvitelButton.Name = "felvitelButton";
            this.felvitelButton.Size = new System.Drawing.Size(270, 50);
            this.felvitelButton.TabIndex = 2;
            this.felvitelButton.Text = "Mentés";
            this.felvitelButton.UseVisualStyleBackColor = true;
            this.felvitelButton.Click += new System.EventHandler(this.felvitelButton_Click);
            // 
            // jatekosokUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.felvitelButton);
            this.Controls.Add(this.jatékosokDataGridView);
            this.Controls.Add(this.jatékosokBindingNavigator);
            this.Name = "jatekosokUC";
            this.Size = new System.Drawing.Size(1300, 650);
            ((System.ComponentModel.ISupportInitialize)(this.arsenalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatékosokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatékosokBindingNavigator)).EndInit();
            this.jatékosokBindingNavigator.ResumeLayout(false);
            this.jatékosokBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jatékosokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArsenalDataSet1 arsenalDataSet1;
        private System.Windows.Forms.BindingSource jatékosokBindingSource;
        private ArsenalDataSet1TableAdapters.JatékosokTableAdapter jatékosokTableAdapter;
        private ArsenalDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jatékosokBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jatékosokBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView jatékosokDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button felvitelButton;
    }
}
