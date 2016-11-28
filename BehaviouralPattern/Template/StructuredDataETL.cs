using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    class StructuredDataETL:ETL
    {
        public override void Extract()
        {
            Console.WriteLine("Structured ETL - Extract");
        }

        public override void Transfer()
        {
            Console.WriteLine("Structured ETL - Transfer");
        }

        public override void Load()
        {
            Console.WriteLine("Structured ETL - Load");
        }
    }
}
