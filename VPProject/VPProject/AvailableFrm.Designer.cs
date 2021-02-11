namespace VPProject
{
    partial class AvailableFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGavailable = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new VPProject.CircularButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateAvail = new System.Windows.Forms.Button();
            this.btnAddavailable = new System.Windows.Forms.Button();
            this.btnExitavailable = new System.Windows.Forms.Button();
            this.btnDeletavailable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarsel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCarsRented = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGavailable)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarsRented)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.DGavailable);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnUpdateAvail);
            this.tabPage1.Controls.Add(this.btnAddavailable);
            this.tabPage1.Controls.Add(this.btnExitavailable);
            this.tabPage1.Controls.Add(this.btnDeletavailable);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGavailable
            // 
            this.DGavailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGavailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGavailable.BackgroundColor = System.Drawing.Color.Black;
            this.DGavailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGavailable.Location = new System.Drawing.Point(0, 95);
            this.DGavailable.Name = "DGavailable";
            this.DGavailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGavailable.Size = new System.Drawing.Size(1006, 417);
            this.DGavailable.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(220, 54);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 44);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            this.btnRefresh.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(365, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 44);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnUpdateAvail
            // 
            this.btnUpdateAvail.BackColor = System.Drawing.Color.Gray;
            this.btnUpdateAvail.FlatAppearance.BorderSize = 0;
            this.btnUpdateAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAvail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAvail.Location = new System.Drawing.Point(463, 54);
            this.btnUpdateAvail.Name = "btnUpdateAvail";
            this.btnUpdateAvail.Size = new System.Drawing.Size(101, 44);
            this.btnUpdateAvail.TabIndex = 19;
            this.btnUpdateAvail.Text = "Update Availability";
            this.btnUpdateAvail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateAvail.UseVisualStyleBackColor = false;
            this.btnUpdateAvail.Click += new System.EventHandler(this.btnUpdateAvail_Click_1);
            this.btnUpdateAvail.MouseLeave += new System.EventHandler(this.btnUpdateAvail_MouseLeave);
            this.btnUpdateAvail.MouseHover += new System.EventHandler(this.btnUpdateAvail_MouseHover);
            // 
            // btnAddavailable
            // 
            this.btnAddavailable.BackColor = System.Drawing.Color.Gray;
            this.btnAddavailable.FlatAppearance.BorderSize = 0;
            this.btnAddavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddavailable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddavailable.Location = new System.Drawing.Point(267, 54);
            this.btnAddavailable.Name = "btnAddavailable";
            this.btnAddavailable.Size = new System.Drawing.Size(101, 44);
            this.btnAddavailable.TabIndex = 18;
            this.btnAddavailable.Text = "Add";
            this.btnAddavailable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddavailable.UseVisualStyleBackColor = false;
            this.btnAddavailable.Click += new System.EventHandler(this.btnAddavailable_Click_1);
            this.btnAddavailable.MouseLeave += new System.EventHandler(this.btnAddavailable_MouseLeave_1);
            this.btnAddavailable.MouseHover += new System.EventHandler(this.btnAddavailable_MouseHover_1);
            // 
            // btnExitavailable
            // 
            this.btnExitavailable.BackColor = System.Drawing.Color.Gray;
            this.btnExitavailable.FlatAppearance.BorderSize = 0;
            this.btnExitavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitavailable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitavailable.Location = new System.Drawing.Point(659, 54);
            this.btnExitavailable.Name = "btnExitavailable";
            this.btnExitavailable.Size = new System.Drawing.Size(101, 44);
            this.btnExitavailable.TabIndex = 17;
            this.btnExitavailable.Text = "Exit";
            this.btnExitavailable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExitavailable.UseVisualStyleBackColor = false;
            this.btnExitavailable.Click += new System.EventHandler(this.btnExitavailable_Click_1);
            this.btnExitavailable.MouseLeave += new System.EventHandler(this.btnExitavailable_MouseLeave_1);
            this.btnExitavailable.MouseHover += new System.EventHandler(this.btnExitavailable_MouseHover_1);
            // 
            // btnDeletavailable
            // 
            this.btnDeletavailable.BackColor = System.Drawing.Color.Gray;
            this.btnDeletavailable.FlatAppearance.BorderSize = 0;
            this.btnDeletavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletavailable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletavailable.Location = new System.Drawing.Point(561, 54);
            this.btnDeletavailable.Name = "btnDeletavailable";
            this.btnDeletavailable.Size = new System.Drawing.Size(101, 44);
            this.btnDeletavailable.TabIndex = 16;
            this.btnDeletavailable.Text = "Delete";
            this.btnDeletavailable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletavailable.UseVisualStyleBackColor = false;
            this.btnDeletavailable.Click += new System.EventHandler(this.btnDeletavailable_Click_1);
            this.btnDeletavailable.MouseLeave += new System.EventHandler(this.btnDeletavailable_MouseLeave_1);
            this.btnDeletavailable.MouseHover += new System.EventHandler(this.btnDeletavailable_MouseHover_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 52);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Vehicles";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCarsel);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgCarsRented);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1007, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rented";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car:";
            this.label3.Visible = false;
            // 
            // txtCarsel
            // 
            this.txtCarsel.Location = new System.Drawing.Point(871, 80);
            this.txtCarsel.Name = "txtCarsel";
            this.txtCarsel.Size = new System.Drawing.Size(125, 20);
            this.txtCarsel.TabIndex = 3;
            this.txtCarsel.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(467, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Veh Returned";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 58);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cars Rented At The Moment.";
            // 
            // dgCarsRented
            // 
            this.dgCarsRented.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCarsRented.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCarsRented.BackgroundColor = System.Drawing.Color.Black;
            this.dgCarsRented.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCarsRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarsRented.Location = new System.Drawing.Point(0, 106);
            this.dgCarsRented.Name = "dgCarsRented";
            this.dgCarsRented.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarsRented.Size = new System.Drawing.Size(1011, 397);
            this.dgCarsRented.TabIndex = 0;
            this.dgCarsRented.SelectionChanged += new System.EventHandler(this.dgCarsRented_SelectionChanged);
            // 
            // AvailableFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 526);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvailableFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvailableFrm";
            this.Load += new System.EventHandler(this.AvailableFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGavailable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarsRented)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGavailable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateAvail;
        private CircularButton btnRefresh;
        private System.Windows.Forms.Button btnAddavailable;
        private System.Windows.Forms.Button btnExitavailable;
        private System.Windows.Forms.Button btnDeletavailable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgCarsRented;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarsel;
    }
}