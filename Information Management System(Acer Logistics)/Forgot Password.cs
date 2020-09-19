using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_System_Acer_Logistics_
{
	public partial class Forgot_Password : Form
	{
		public Forgot_Password()
		{
			InitializeComponent();
		}

		private void PasscheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (PasscheckBox.Checked)
				txtPassword.PasswordChar = '\0';
			else
				txtPassword.PasswordChar = '*';
		}

		private void Forgot_Password_Load(object sender, EventArgs e)
		{

		}
	}
}
