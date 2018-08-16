using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;

namespace PaJaMa.RedisClient
{
	public partial class ucWorkspace : UserControl
	{
		public ucWorkspace()
		{
			InitializeComponent();
		}

		private void ucWorkspace_Load(object sender, EventArgs e)
		{
			var connStrings = PaJaMa.Common.SettingsHelper.GetUserSettings<List<string>>();
			txtConnectionString.Items.Clear();
			txtConnectionString.Items.AddRange(connStrings.OrderBy(c => c).ToArray());
		}

		private void btnGO_Click(object sender, EventArgs e)
		{
			try
			{
				var conn = ConnectionMultiplexer.Connect(txtConnectionString.Text);
				var connStrings = PaJaMa.Common.SettingsHelper.GetUserSettings<List<string>>();
				if (!connStrings.Any(s => s == txtConnectionString.Text))
				{
					connStrings.Add(txtConnectionString.Text);
					PaJaMa.Common.SettingsHelper.SaveUserSettings<List<string>>(connStrings);
				}
				var db = conn.GetDatabase();
				switch (cboCommand.Text)
				{
					case "GET":
						txtOutput.Text = db.StringGet(txtHash.Text);
						break;
					case "HGET":
						txtOutput.Text = db.HashGet(txtHash.Text, txtField.Text);
						break;
					case "FLUSHALL":
						var endpoint = conn.GetEndPoints()[0];
						var server = conn.GetServer(endpoint);
						server.FlushDatabase();
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void Disconnect()
		{
			_connection.Close();
		}
	}
}
