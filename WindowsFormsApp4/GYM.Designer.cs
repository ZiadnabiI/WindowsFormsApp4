namespace WindowsFormsApp4
{
    partial class GYM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gymIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet = new WindowsFormsApp4.GYMDataSet();
            this.gymTableAdapter = new WindowsFormsApp4.GYMDataSetTableAdapters.GymTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gymIDDataGridViewTextBoxColumn,
            this.gymNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gymBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(143, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // gymIDDataGridViewTextBoxColumn
            // 
            this.gymIDDataGridViewTextBoxColumn.DataPropertyName = "Gym_ID";
            this.gymIDDataGridViewTextBoxColumn.HeaderText = "Gym_ID";
            this.gymIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gymIDDataGridViewTextBoxColumn.Name = "gymIDDataGridViewTextBoxColumn";
            this.gymIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gymNameDataGridViewTextBoxColumn
            // 
            this.gymNameDataGridViewTextBoxColumn.DataPropertyName = "Gym_Name";
            this.gymNameDataGridViewTextBoxColumn.HeaderText = "Gym_Name";
            this.gymNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gymNameDataGridViewTextBoxColumn.Name = "gymNameDataGridViewTextBoxColumn";
            this.gymNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gymBindingSource
            // 
            this.gymBindingSource.DataMember = "Gym";
            this.gymBindingSource.DataSource = this.gYMDataSet;
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymTableAdapter
            // 
            this.gymTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GYM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GYM";
            this.Text = "GYM";
            this.Load += new System.EventHandler(this.GYM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.BindingSource gymBindingSource;
        private GYMDataSetTableAdapters.GymTableAdapter gymTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gymIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gymNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}