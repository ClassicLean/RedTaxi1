namespace Red_Taxi
{
    partial class Operator
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
            this.buttonAssign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonAssign
            // 
            this.buttonAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.buttonAssign.FlatAppearance.BorderSize = 0;
            this.buttonAssign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(154)))));
            this.buttonAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssign.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssign.ForeColor = System.Drawing.Color.White;
            this.buttonAssign.Location = new System.Drawing.Point(74, 74);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(75, 58);
            this.buttonAssign.TabIndex = 0;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = false;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 264);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.panel2.Location = new System.Drawing.Point(266, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 264);
            this.panel2.TabIndex = 9;
            // 
            // Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAssign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operator_FormClosing);
            this.Load += new System.EventHandler(this.Operator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}