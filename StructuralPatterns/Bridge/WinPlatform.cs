using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class WinPlatform:IPlatformImplementation
    {
        private string _name;
        #region IPlatformImplementation Members

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void AssignJob()
        {
            Console.WriteLine("Platform: " + _name + " - Job assigned");
        }

        #endregion
    }
}
