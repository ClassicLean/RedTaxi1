namespace Red_Taxi
{
    partial class Vehicle
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPNumber = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.textBoxCNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(154)))));
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.ForeColor = System.Drawing.Color.White;
            this.buttonInsert.Location = new System.Drawing.Point(44, 341);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(74, 23);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(154)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(126, 341);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(74, 23);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(154)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(206, 341);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(74, 23);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Back";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Location = new System.Drawing.Point(108, 12);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(121, 14);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plate Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxPNumber
            // 
            this.textBoxPNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.textBoxPNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPNumber.Location = new System.Drawing.Point(108, 198);
            this.textBoxPNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPNumber.Name = "textBoxPNumber";
            this.textBoxPNumber.Size = new System.Drawing.Size(121, 14);
            this.textBoxPNumber.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "",
            "Active",
            "Repair",
            "Decomission"});
            this.comboBoxStatus.Location = new System.Drawing.Point(108, 309);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(120, 21);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vehicle Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Chasis Number:";
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.comboBoxVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVehicle.FormattingEnabled = true;
            this.comboBoxVehicle.Items.AddRange(new object[] {
            "",
            "Single motorcycle",
            "Tricycle",
            "Common",
            "Van",
            "Mini Truck"});
            this.comboBoxVehicle.Location = new System.Drawing.Point(108, 226);
            this.comboBoxVehicle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(120, 21);
            this.comboBoxVehicle.TabIndex = 2;
            // 
            // textBoxCNumber
            // 
            this.textBoxCNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.textBoxCNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCNumber.Location = new System.Drawing.Point(108, 257);
            this.textBoxCNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxCNumber.Name = "textBoxCNumber";
            this.textBoxCNumber.Size = new System.Drawing.Size(121, 14);
            this.textBoxCNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Boundary Amount:";
            // 
            // textBoxBAmount
            // 
            this.textBoxBAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.textBoxBAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBAmount.Location = new System.Drawing.Point(108, 283);
            this.textBoxBAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxBAmount.Name = "textBoxBAmount";
            this.textBoxBAmount.Size = new System.Drawing.Size(121, 14);
            this.textBoxBAmount.TabIndex = 4;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(324, 379);
            this.Controls.Add(this.textBoxBAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCNumber);
            this.Controls.Add(this.comboBoxVehicle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxPNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vehicle_FormClosing);
            this.Load += new System.EventHandler(this.Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPNumber;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVehicle;
        private System.Windows.Forms.TextBox textBoxCNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBAmount;
    }
}