namespace Red_Taxi
{
    partial class HR
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
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonVehicle = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonEmp
            // 
            this.buttonEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.buttonEmp.FlatAppearance.BorderSize = 0;
            this.buttonEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(154)))));
            this.buttonEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmp.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmp.ForeColor = System.Drawing.Color.White;
            this.buttonEmp.Location = new System.Drawing.Point(113, 75);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonEmp.TabIndex = 0;
            this.buttonEmp.Text = "Employee";
            this.buttonEmp.UseVisualStyleBackColor = false;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // buttonVehicle
            // 
            this.buttonVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.buttonVehicle.FlatAppearance.BorderSize = 0;
            this.buttonVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(154)))));
            this.buttonVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicle.ForeColor = System.Drawing.Color.White;
            this.buttonVehicle.Location = new System.Drawing.Point(113, 104);
            this.buttonVehicle.Name = "buttonVehicle";
            this.buttonVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonVehicle.TabIndex = 1;
            this.buttonVehicle.Text = "Vehicle";
            this.buttonVehicle.UseVisualStyleBackColor = false;
            this.buttonVehicle.Click += new System.EventHandler(this.buttonVehicle_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(154)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(113, 133);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 264);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(374, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 264);
            this.panel1.TabIndex = 8;
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonVehicle);
            this.Controls.Add(this.buttonEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HR_FormClosing);
            this.Load += new System.EventHandler(this.HR_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmp;
        private System.Windows.Forms.Button buttonVehicle;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}