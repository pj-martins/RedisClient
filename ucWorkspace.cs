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
using Newtonsoft.Json;

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
				string output = string.Empty;
				switch (cboCommand.Text)
				{
					case "GET":
						output = db.StringGet(txtHash.Text);
						break;
					case "HGET":
						output = db.HashGet(txtHash.Text, txtField.Text);
						break;
					case "FLUSHALL":
						var endpoint = conn.GetEndPoints()[0];
						var server = conn.GetServer(endpoint);
						server.FlushDatabase();
						output = "OK";
						break;
				}
				try
				{
					var obj = JsonConvert.DeserializeObject(output);
					txtOutput.Text = JsonConvert.SerializeObject(obj, Formatting.Indented);
				}
				catch
				{
					txtOutput.Text = output;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
