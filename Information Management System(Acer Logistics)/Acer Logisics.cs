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
	public partial class AcerLogisics : Form
	{
		public AcerLogisics()
		{
			InitializeComponent();
		}

		private void hRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Human_Resources HR = new Human_Resources();
			HR.ShowDialog();
		}
		public string getNm { get; set; }
		private void AcerLogisics_Load(object sender, EventArgs e)
		{
			getNm = (new Login()).getuserName;
			//lblUser.Text = getNm;
		}
	}
}
