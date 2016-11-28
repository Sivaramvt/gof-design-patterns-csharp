using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
   abstract class ETL
    {
       public abstract void Extract();
       public abstract void Transfer();
       public abstract void Load();

       public void Execute()
       {
           Extract();
           Transfer();
           Load();
       }
    }
}
