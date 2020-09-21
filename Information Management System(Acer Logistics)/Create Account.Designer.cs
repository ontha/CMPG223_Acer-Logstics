namespace Information_Management_System_Acer_Logistics_
{
	partial class Create_Account
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
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.lblBack = new System.Windows.Forms.Label();
			this.lblSuggested = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(183, 95);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(100, 20);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(183, 121);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter your username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Enter your password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Confirm password:";
			// 
			// txtConfirm
			// 
			this.txtConfirm.Location = new System.Drawing.Point(183, 147);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.Size = new System.Drawing.Size(100, 20);
			this.txtConfirm.TabIndex = 5;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(165, 205);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 28);
			this.btnEnter.TabIndex = 6;
			this.btnEnter.Text = "Enter";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// lblBack
			// 
			this.lblBack.AutoSize = true;
			this.lblBack.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblBack.Location = new System.Drawing.Point(71, 220);
			this.lblBack.Name = "lblBack";
			this.lblBack.Size = new System.Drawing.Size(32, 13);
			this.lblBack.TabIndex = 7;
			this.lblBack.Text = "Back";
			// 
			// lblSuggested
			// 
			this.lblSuggested.AutoSize = true;
			this.lblSuggested.ForeColor = System.Drawing.Color.Red;
			this.lblSuggested.Location = new System.Drawing.Point(33, 177);
			this.lblSuggested.Name = "lblSuggested";
			this.lblSuggested.Size = new System.Drawing.Size(58, 13);
			this.lblSuggested.TabIndex = 8;
			this.lblSuggested.Text = "Suggested";
			this.lblSuggested.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cooper Std Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkCyan;
			this.label4.Location = new System.Drawing.Point(112, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "New User";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(107, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Enter your Id:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(183, 67);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 11;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Create_Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 258);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblSuggested);
			this.Controls.Add(this.lblBack);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Name = "Create_Account";
			this.Text = "Create_Account";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label lblBack;
		private System.Windows.Forms.Label lblSuggested;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}