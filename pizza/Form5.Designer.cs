namespace pizza
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectpizzaDataSet = new pizza.projectpizzaDataSet();
            this.announcements1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.announcements1TableAdapter = new pizza.projectpizzaDataSetTableAdapters.announcementsTableAdapter();
            this.idannouncementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpizzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcements1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idannouncementsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.announcements1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(324, 229);
            this.dataGridView1.TabIndex = 3;
            // 
            // projectpizzaDataSet
            // 
            this.projectpizzaDataSet.DataSetName = "projectpizzaDataSet";
            this.projectpizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // announcements1BindingSource
            // 
            this.announcements1BindingSource.DataMember = "announcements1";
            this.announcements1BindingSource.DataSource = this.projectpizzaDataSet;
            // 
            // announcements1TableAdapter
            // 
            this.announcements1TableAdapter.ClearBeforeFill = true;
            // 
            // idannouncementsDataGridViewTextBoxColumn
            // 
            this.idannouncementsDataGridViewTextBoxColumn.DataPropertyName = "idannouncements";
            this.idannouncementsDataGridViewTextBoxColumn.HeaderText = "idannouncements";
            this.idannouncementsDataGridViewTextBoxColumn.Name = "idannouncementsDataGridViewTextBoxColumn";
            this.idannouncementsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 308);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Announcements";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpizzaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private projectpizzaDataSet projectpizzaDataSet;
        private System.Windows.Forms.BindingSource announcements1BindingSource;
        private projectpizzaDataSetTableAdapters.announcementsTableAdapter announcements1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idannouncementsDataGridViewTextBoxColumn;
    }
}