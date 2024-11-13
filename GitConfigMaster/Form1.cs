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
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager;
        private List<GitConfig> configs;

        public Form1()
        {
            InitializeComponent();
            try
            {
                dbManager = new DatabaseManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při inicializaci databáze: {ex.Message}");
            }
            LoadConfigs();
        }

        private void LoadConfigs()
        {
            configs = dbManager.GetAllConfigurations();
            comboBoxConfigs.Items.Clear();

            foreach (var config in configs)
            {
                comboBoxConfigs.Items.Add($"{config.Name} ({config.Email})");
            }

            if (configs.Count > 0)
                comboBoxConfigs.SelectedIndex = 0;
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            var configForm = new ConfigForm(dbManager, LoadConfigs);
            configForm.Show();
        }

        private void btnApplyConfig_Click(object sender, EventArgs e)
        {
            if (comboBoxConfigs.SelectedIndex >= 0)
            {
                var selectedConfig = configs[comboBoxConfigs.SelectedIndex];
                dbManager.UpdateGitConfigFile(selectedConfig);
                MessageBox.Show(".gitconfig byl aktualizován!", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vyberte konfiguraci před aplikováním!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
