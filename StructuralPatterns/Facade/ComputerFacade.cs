using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class ComputerFacade
    {
        private HDD _hdd;
        private Memory _mem;
        private Processor _proc;

       public ComputerFacade(Processor proc, HDD hdd, Memory mem)
        {
            this._hdd = hdd;
            this._proc = proc;
            this._mem = mem;
        }

        public void Start()
        {
            _hdd.SupplyPower();
            _mem.SupplyPower();
            _proc.SupplyPower();
        }

        public void ExecuteProgram()
        {
            _proc.LoadCode();
            _mem.AllocateMemory();
            _hdd.FetchData();
            _proc.Execute();           
            
        }


    }
}
