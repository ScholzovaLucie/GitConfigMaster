using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitConfigMaster
{
    public partial class ConfigForm : Form
    {
        private DatabaseManager dbManager;
        private Action reloadConfigs;
        public ConfigForm(DatabaseManager dbManager, Action reloadConfigs)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.reloadConfigs = reloadConfigs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var config = new GitConfig(
               txtName.Text,
               txtEmail.Text,
               txtUrl.Text,
               txtInsteadOf.Text
           );

            dbManager.AddConfiguration(config);
            reloadConfigs();
            this.Close();
        }
    }
}
