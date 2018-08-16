using PaJaMa.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaJaMa.RedisClient
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			FormSettings.LoadSettings(this);

			if (tabMain.TabPages.Count < 1)
				addWorkspace(null);
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized) return;
			FormSettings.SaveSettings(this);
		}

		private void addWorkspace(WinControls.TabControl.TabPage tabPage)
		{
			var uc = new ucWorkspace();
			bool add = false;
			if (tabPage == null)
			{
				tabPage = new WinControls.TabControl.TabPage();
				add = true;
			}
			tabPage.Text = "Workspace " + (tabMain.TabPages.Count + 1).ToString();
			uc.Dock = DockStyle.Fill;
			tabPage.Controls.Add(uc);
			if (add)
			{
				tabMain.TabPages.Add(tabPage);
				tabMain.SelectedTab = tabPage;
			}
		}
	}
}
