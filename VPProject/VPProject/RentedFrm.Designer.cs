namespace VPProject
{
    partial class RenteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenteFrm));
            this.dgRented = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRntdExit = new VPProject.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgRented)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRented
            // 
            this.dgRented.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRented.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRented.BackgroundColor = System.Drawing.Color.Black;
            this.dgRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRented.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dgRented.Location = new System.Drawing.Point(-4, 48);
            this.dgRented.Name = "dgRented";
            this.dgRented.Size = new System.Drawing.Size(787, 470);
            this.dgRented.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Below Is The List Of Cars Which Are Rented ATM. ";
            // 
            // btnRntdExit
            // 
            this.btnRntdExit.BackColor = System.Drawing.Color.Crimson;
            this.btnRntdExit.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnRntdExit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRntdExit.FlatAppearance.BorderSize = 0;
            this.btnRntdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRntdExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRntdExit.Location = new System.Drawing.Point(729, 2);
            this.btnRntdExit.Name = "btnRntdExit";
            this.btnRntdExit.Size = new System.Drawing.Size(41, 40);
            this.btnRntdExit.TabIndex = 2;
            this.btnRntdExit.Text = "X";
            this.btnRntdExit.UseVisualStyleBackColor = false;
            this.btnRntdExit.Click += new System.EventHandler(this.btnRntdExit_Click);
            // 
            // RenteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.btnRntdExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRented);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PET";
            this.Load += new System.EventHandler(this.RenteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRented)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRented;
        private System.Windows.Forms.Label label1;
        private CircularButton btnRntdExit;
    }
}