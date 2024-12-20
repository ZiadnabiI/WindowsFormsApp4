namespace WindowsFormsApp4
{
    partial class Add_trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_trainer));
            this.membershipTableAdapter = new WindowsFormsApp4.GYMDataSetTableAdapters.MembershipTableAdapter();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet = new WindowsFormsApp4.GYMDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gymIdTextBox = new System.Windows.Forms.TextBox();
            this.trainerIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.gYMDataSetBindingSource;
            // 
            // gYMDataSetBindingSource
            // 
            this.gYMDataSetBindingSource.DataSource = this.gYMDataSet;
            this.gYMDataSetBindingSource.Position = 0;
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label11.Location = new System.Drawing.Point(539, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 50;
            this.label11.Text = "Salary";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(704, 387);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(147, 22);
            this.emailTextBox.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label8.Location = new System.Drawing.Point(539, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Email";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(704, 320);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(147, 22);
            this.phoneTextBox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label7.Location = new System.Drawing.Point(539, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(539, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "GYM ID";
            // 
            // gymIdTextBox
            // 
            this.gymIdTextBox.Location = new System.Drawing.Point(704, 253);
            this.gymIdTextBox.Name = "gymIdTextBox";
            this.gymIdTextBox.Size = new System.Drawing.Size(147, 22);
            this.gymIdTextBox.TabIndex = 36;
            // 
            // trainerIdTextBox
            // 
            this.trainerIdTextBox.Location = new System.Drawing.Point(704, 193);
            this.trainerIdTextBox.Name = "trainerIdTextBox";
            this.trainerIdTextBox.Size = new System.Drawing.Size(147, 22);
            this.trainerIdTextBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(539, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Trainer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(539, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Trainer Name";
            // 
            // trainerNameTextBox
            // 
            this.trainerNameTextBox.Location = new System.Drawing.Point(704, 130);
            this.trainerNameTextBox.Name = "trainerNameTextBox";
            this.trainerNameTextBox.Size = new System.Drawing.Size(147, 22);
            this.trainerNameTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(176, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "GYM DATABASE MANAGMENT SYSTEM";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 212);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(419, 332);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 30;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(704, 445);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(147, 22);
            this.salaryTextBox.TabIndex = 49;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(300, 130);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(155, 148);
            this.guna2CircleButton1.TabIndex = 54;
            this.guna2CircleButton1.Text = "Save";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Add_trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(916, 566);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gymIdTextBox);
            this.Controls.Add(this.trainerIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trainerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "Add_trainer";
            this.Text = "Add_trainer";
            this.Load += new System.EventHandler(this.Add_trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GYMDataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private System.Windows.Forms.BindingSource gYMDataSetBindingSource;
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneTextBox;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gymIdTextBox;
        private System.Windows.Forms.TextBox trainerIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trainerNameTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.TextBox salaryTextBox;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}