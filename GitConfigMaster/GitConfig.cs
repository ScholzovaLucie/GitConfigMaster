using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConfigMaster
{
    public class GitConfig
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string InsteadOf { get; set; }

        public GitConfig(string name, string email, string url, string insteadOf)
        {
            Name = name;
            Email = email;
            Url = url;
            InsteadOf = insteadOf;
        }
    }
}
