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
	public partial class RecoverQuiz : Form
	{
		public RecoverQuiz()
		{
			InitializeComponent();
		}

		private void RecoverQuiz_Load(object sender, EventArgs e)
		{

		}
		public bool QuizCreated { get; set; }
		public string getQuiz { get; set; }
		public string getAnswer { get; set; }
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if(QuizcomboBox.SelectedIndex != -1 || QuizcomboBox.Text != string.Empty)
			{
				if (txtAnswer.Text != string.Empty)
				{
					QuizCreated = true;
					getQuiz = QuizcomboBox.Text;
					getAnswer = txtAnswer.Text;
					this.Close();
				}
			}
		}
	}
}
