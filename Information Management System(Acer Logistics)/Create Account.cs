using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Information_Management_System_Acer_Logistics_
{
	public partial class Create_Account : Form
	{
		public Create_Account()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private SqlDataAdapter adp;
		private SqlCommand comm;
		private DataSet ds;
		private SqlDataReader dRead;
		private string userFirstName = null;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";

		private bool validateID(string userInput)
		{
			bool validity = false;
			
			con = new SqlConnection(conStr);
			con.Open();
			string readALL = "SELECT * FROM Employees";
			comm = new SqlCommand(readALL, con);
			dRead = comm.ExecuteReader();

			while(dRead.Read())
			{
				if (dRead.GetValue(0).ToString() == userInput)
				{
					validity = true;     // set to true if the ID is in the database
					userFirstName = dRead.GetValue(1).ToString();
					if (dRead.GetValue(8).ToString() != string.Empty)
					{
						errorProvider1.SetError(txtId, "Account already exist for this ID, please try again");
						validity = false;    //set to false if the user already have an account
					}
				}
			}
			MessageBox.Show("Done user " + validity.ToString());
			con.Close();
			return validity;
		}
		private string generateUser(string userName)
		{
			Random num = new Random();

			string autoname = userName + num.Next(99, 9999);    //generates username

			return autoname;
		}
		public void validateUsername(string userInput)
		{
			string userName = null;   // read from the database

			con = new SqlConnection(conStr);
			con.Open();
			string readALL = "SELECT * FROM Login";
			comm = new SqlCommand(readALL, con);
			dRead = comm.ExecuteReader();

			while (dRead.Read() && userName != userInput)    // read and username does not exist
			{
				userName = dRead.GetValue(1).ToString();
				if(userName == userInput)
				{
					userName = generateUser(userFirstName);  // If it exist? generate new one
					lblSuggested.Text = "User with this name already exist. suggested " + userName;
					lblSuggested.Visible = true;
				}
			}

			con.Close();
		}
		private void btnEnter_Click(object sender, EventArgs e)
		{
			if (validateID(txtId.Text))
			{
				validateUsername(txtUsername.Text);
			}
			else
			{
				MessageBox.Show("Please try again");
			}
		}
	}
}
