namespace Information_Management_System_Acer_Logistics_
{
	partial class RecoverQuiz
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
			this.label1 = new System.Windows.Forms.Label();
			this.QuizcomboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Set recover question:";
			// 
			// QuizcomboBox
			// 
			this.QuizcomboBox.FormattingEnabled = true;
			this.QuizcomboBox.Location = new System.Drawing.Point(163, 69);
			this.QuizcomboBox.Name = "QuizcomboBox";
			this.QuizcomboBox.Size = new System.Drawing.Size(196, 21);
			this.QuizcomboBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(90, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Your Answer:";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(163, 101);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(196, 20);
			this.txtAnswer.TabIndex = 3;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(150, 143);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 4;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			// 
			// Back
			// 
			this.Back.AutoSize = true;
			this.Back.ForeColor = System.Drawing.SystemColors.Highlight;
			this.Back.Location = new System.Drawing.Point(24, 152);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(32, 13);
			this.Back.TabIndex = 5;
			this.Back.Text = "Back";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cooper Std Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkCyan;
			this.label3.Location = new System.Drawing.Point(116, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "Recovery Quiz";
			// 
			// RecoverQuiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 189);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.QuizcomboBox);
			this.Controls.Add(this.label1);
			this.Name = "RecoverQuiz";
			this.Text = "RecoverQuiz";
			this.Load += new System.EventHandler(this.RecoverQuiz_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox QuizcomboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Label Back;
		private System.Windows.Forms.Label label3;
	}
}