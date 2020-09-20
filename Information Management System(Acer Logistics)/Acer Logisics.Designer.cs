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
			this.Management = new System.Windows.Forms.TabControl();
			this.Inventory = new System.Windows.Forms.TabPage();
			this.Clients = new System.Windows.Forms.TabPage();
			this.receiveSo = new System.Windows.Forms.TabPage();
			this.deliverSo = new System.Windows.Forms.TabPage();
			this.reports = new System.Windows.Forms.TabPage();
			this.Management.SuspendLayout();
			this.SuspendLayout();
			// 
			// Management
			// 
			this.Management.Controls.Add(this.Inventory);
			this.Management.Controls.Add(this.Clients);
			this.Management.Controls.Add(this.receiveSo);
			this.Management.Controls.Add(this.deliverSo);
			this.Management.Controls.Add(this.reports);
			this.Management.Location = new System.Drawing.Point(13, 31);
			this.Management.Name = "Management";
			this.Management.SelectedIndex = 0;
			this.Management.Size = new System.Drawing.Size(775, 407);
			this.Management.TabIndex = 0;
			// 
			// Inventory
			// 
			this.Inventory.Location = new System.Drawing.Point(4, 22);
			this.Inventory.Name = "Inventory";
			this.Inventory.Padding = new System.Windows.Forms.Padding(3);
			this.Inventory.Size = new System.Drawing.Size(767, 381);
			this.Inventory.TabIndex = 0;
			this.Inventory.Text = "Inventory";
			this.Inventory.UseVisualStyleBackColor = true;
			// 
			// Clients
			// 
			this.Clients.Location = new System.Drawing.Point(4, 22);
			this.Clients.Name = "Clients";
			this.Clients.Padding = new System.Windows.Forms.Padding(3);
			this.Clients.Size = new System.Drawing.Size(767, 281);
			this.Clients.TabIndex = 1;
			this.Clients.Text = "Clients";
			this.Clients.UseVisualStyleBackColor = true;
			// 
			// receiveSo
			// 
			this.receiveSo.Location = new System.Drawing.Point(4, 22);
			this.receiveSo.Name = "receiveSo";
			this.receiveSo.Padding = new System.Windows.Forms.Padding(3);
			this.receiveSo.Size = new System.Drawing.Size(767, 281);
			this.receiveSo.TabIndex = 2;
			this.receiveSo.Text = "Receive SO";
			this.receiveSo.UseVisualStyleBackColor = true;
			// 
			// deliverSo
			// 
			this.deliverSo.Location = new System.Drawing.Point(4, 22);
			this.deliverSo.Name = "deliverSo";
			this.deliverSo.Padding = new System.Windows.Forms.Padding(3);
			this.deliverSo.Size = new System.Drawing.Size(767, 281);
			this.deliverSo.TabIndex = 3;
			this.deliverSo.Text = "Deliver SO";
			this.deliverSo.UseVisualStyleBackColor = true;
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
			// AcerLogisics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Management);
			this.Name = "AcerLogisics";
			this.Text = "Acer Logisics";
			this.Management.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Management;
		private System.Windows.Forms.TabPage Inventory;
		private System.Windows.Forms.TabPage Clients;
		private System.Windows.Forms.TabPage receiveSo;
		private System.Windows.Forms.TabPage deliverSo;
		private System.Windows.Forms.TabPage reports;
	}
}