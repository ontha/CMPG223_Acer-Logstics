using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Information_Management_System_Acer_Logistics_
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private SqlDataAdapter adp;
		private SqlCommand comm;
		private DataSet ds;
		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
		public bool authenticate(string userName, string password)
		{
			bool results = false;
			
			
			con.Open();
			MessageBox.Show("Opened");
			con.Close();


			return results; 
		}
		private void button1_Click(object sender, EventArgs e)
		{
			/*AcerLogisics my = new AcerLogisics();
			my.ShowDialog();*/
			authenticate(txtID.Text, txtPassword.Text);
		}

		private void showCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (showCheckBox.Checked)
				txtPassword.PasswordChar = '\0';
			else
				txtPassword.PasswordChar = '*';
		}

		private void label6_Click(object sender, EventArgs e)
		{
			Create_Account newUser = new Create_Account();
			newUser.ShowDialog();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			Forgot_Password forgotPass = new Forgot_Password();
			forgotPass.ShowDialog();
		}
	}
}
