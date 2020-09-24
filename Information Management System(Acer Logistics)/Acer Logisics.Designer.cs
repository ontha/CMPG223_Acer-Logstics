namespace Information_Management_System_Acer_Logistics_
{
	partial class AcerLogisics
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
			this.reports = new System.Windows.Forms.TabPage();
			this.receiveSo = new System.Windows.Forms.TabPage();
			this.Inventory = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.Change = new System.Windows.Forms.GroupBox();
			this.Add = new System.Windows.Forms.GroupBox();
			this.Management = new System.Windows.Forms.TabControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hRDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Inventory.SuspendLayout();
			this.Management.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// reports
			// 
			this.reports.Location = new System.Drawing.Point(4, 22);
			this.reports.Name = "reports";
			this.reports.Padding = new System.Windows.Forms.Padding(3);
			this.reports.Size = new System.Drawing.Size(767, 381);
			this.reports.TabIndex = 4;
			this.reports.Text = "Reports";
			this.reports.UseVisualStyleBackColor = true;
			// 
			// receiveSo
			// 
			this.receiveSo.Location = new System.Drawing.Point(4, 22);
			this.receiveSo.Name = "receiveSo";
			this.receiveSo.Padding = new System.Windows.Forms.Padding(3);
			this.receiveSo.Size = new System.Drawing.Size(767, 381);
			this.receiveSo.TabIndex = 2;
			this.receiveSo.Text = "Suppliers";
			this.receiveSo.UseVisualStyleBackColor = true;
			// 
			// Inventory
			// 
			this.Inventory.Controls.Add(this.groupBox3);
			this.Inventory.Controls.Add(this.Change);
			this.Inventory.Controls.Add(this.Add);
			this.Inventory.Location = new System.Drawing.Point(4, 22);
			this.Inventory.Name = "Inventory";
			this.Inventory.Padding = new System.Windows.Forms.Padding(3);
			this.Inventory.Size = new System.Drawing.Size(767, 381);
			this.Inventory.TabIndex = 0;
			this.Inventory.Text = "Inventory";
			this.Inventory.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(421, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Delete";
			// 
			// Change
			// 
			this.Change.Location = new System.Drawing.Point(214, 7);
			this.Change.Name = "Change";
			this.Change.Size = new System.Drawing.Size(200, 100);
			this.Change.TabIndex = 1;
			this.Change.TabStop = false;
			this.Change.Text = "Update";
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(7, 7);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(200, 100);
			this.Add.TabIndex = 0;
			this.Add.TabStop = false;
			this.Add.Text = "Add";
			// 
			// Management
			// 
			this.Management.Controls.Add(this.Inventory);
			this.Management.Controls.Add(this.receiveSo);
			this.Management.Controls.Add(this.reports);
			this.Management.Location = new System.Drawing.Point(13, 31);
			this.Management.Name = "Management";
			this.Management.SelectedIndex = 0;
			this.Management.Size = new System.Drawing.Size(775, 407);
			this.Management.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hRDepartmentToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// hRDepartmentToolStripMenuItem
			// 
			this.hRDepartmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hRToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.logisticsToolStripMenuItem});
			this.hRDepartmentToolStripMenuItem.Name = "hRDepartmentToolStripMenuItem";
			this.hRDepartmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.hRDepartmentToolStripMenuItem.Text = "Departments";
			// 
			// hRToolStripMenuItem
			// 
			this.hRToolStripMenuItem.Name = "hRToolStripMenuItem";
			this.hRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.hRToolStripMenuItem.Text = "HR";
			this.hRToolStripMenuItem.Click += new System.EventHandler(this.hRToolStripMenuItem_Click);
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salesToolStripMenuItem.Text = "Sales";
			// 
			// logisticsToolStripMenuItem
			// 
			this.logisticsToolStripMenuItem.Name = "logisticsToolStripMenuItem";
			this.logisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.logisticsToolStripMenuItem.Text = "Logistics";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// AcerLogisics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Management);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AcerLogisics";
			this.Text = "Management";
			this.Load += new System.EventHandler(this.AcerLogisics_Load);
			this.Inventory.ResumeLayout(false);
			this.Management.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabPage reports;
		private System.Windows.Forms.TabPage receiveSo;
		private System.Windows.Forms.TabPage Inventory;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox Change;
		private System.Windows.Forms.GroupBox Add;
		private System.Windows.Forms.TabControl Management;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hRDepartmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hRToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logisticsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}