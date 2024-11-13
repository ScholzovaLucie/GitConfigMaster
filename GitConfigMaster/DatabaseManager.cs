using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LiteDB;

namespace GitConfigMaster
{
    public class DatabaseManager
    {
        private string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configs.db");
        private LiteDatabase database;

        public DatabaseManager()
        {
            // Otevře nebo vytvoří databázi
            database = new LiteDatabase(dbPath);
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            // V LiteDB není potřeba explicitně vytvářet tabulky, jsou vytvořeny automaticky
        }

        public List<GitConfig> GetAllConfigurations()
        {
            var configs = new List<GitConfig>();
            var collection = database.GetCollection<GitConfig>("Configurations");

            // Získání všech konfigurací
            configs = collection.FindAll().ToList();
            return configs;
        }

        public void AddConfiguration(GitConfig config)
        {
            var collection = database.GetCollection<GitConfig>("Configurations");
            collection.Insert(config); // Vloží nový dokument
        }

        public void UpdateGitConfigFile(GitConfig config)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".gitconfig");
            string content = $@"
[user]
    name = {config.Name}
    email = {config.Email}
[url ""{config.Url}""]
    insteadOf = {config.InsteadOf}";

            File.WriteAllText(filePath, content);
        }
    }
}
