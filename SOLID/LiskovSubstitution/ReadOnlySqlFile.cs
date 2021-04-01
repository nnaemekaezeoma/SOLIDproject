using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution
{
    class ReadOnlySqlFile: IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from sql file */
            return "";
        }
    }
}
