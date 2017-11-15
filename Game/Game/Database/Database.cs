using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Database
{
    class Database
    {
        public void Register(string name, string password)
        {
            string path = @"C:\Users\Nikolaj\Desktop\WindowsFormsGame\Game\Game\Database\data\";
            string path_Accounts = @"C:\Users\Nikolaj\Desktop\WindowsFormsGame\Game\Game\Database\data\Accounts\";
            string path_Stats = @"C:\Users\Nikolaj\Desktop\WindowsFormsGame\Game\Game\Database\data\Stats\";

            System.IO.File.WriteAllText(path_Accounts + name + ".txt", "");
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path_Accounts + name + ".txt"))
            {
                writer.WriteLine(name);
                writer.WriteLine(password);
                writer.WriteLine(DateTime.Now);
            }
        }

        public void Login()
        {

        }

    }
}
