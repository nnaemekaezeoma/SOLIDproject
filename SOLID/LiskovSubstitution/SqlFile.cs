using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution
{
    public class SqlFile : IWritableSqlFile//, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        //public string LoadText()
        //{
        //    /* Code to read text from sql file */
        //    return "";
        //}
        public void SaveText()
        {
            /* Code to save text into sql file */
        }
    }
}
