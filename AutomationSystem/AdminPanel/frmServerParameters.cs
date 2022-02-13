using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationSystem.AdminPanel
{
    public partial class frmServerParameters : Form
    {
        public frmServerParameters()
        {
            InitializeComponent();
        }

        private void frmServerParameters_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static string buildEntityConnection(string dynamicEntityConnection)
        {
            //Dynamic Entity Connection
            var entityConnection = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = dynamicEntityConnection,
                Metadata = "res://*"
            };
            return entityConnection.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Set parameters for client to connect server
            if (txt_DatabaseName.Text == "" || txt_ServerIP.Text == "" || txt_DatabasePassword.Text == "")
            {
                MessageBox.Show("فيلدهاي خالي را پر كنيد","تنظيم سرور");
                return;
            }
            var entityConnectionString = buildEntityConnection($"Data Source={txt_ServerIP.Text.Trim()}; Initial Catalog={txt_DatabaseName.Text.Trim()}; Password={txt_DatabasePassword.Text.Trim()}; Integrated Security=true");
            try
            {
                RegistryKey connectionKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\AutomationConnection");
                try
                {
                    connectionKey.SetValue("ConnectionForAutomation", entityConnectionString);
                }
                catch (Exception)
                {
                    MessageBox.Show("خطايي در خواندن اطلاعات رخ داد", "سرور");
                    return;
                }
                finally
                {
                    connectionKey.Close();
                }
                MessageBox.Show("ارتباط با سرور برقرار شد، لطفا سيستم را ريستارت كنيد","سرور");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد", "سرور");
                return;
            }
        }
    }
}
