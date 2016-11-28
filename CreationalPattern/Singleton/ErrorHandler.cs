using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class ErrorHandler
    {
        private string _name;

        public string Name { get { return _name; } }
        private static ErrorHandler _Instance;

        public static ErrorHandler Instance
        {
            get
            {
                if (_Instance == null) { _Instance = new ErrorHandler(); _Instance._name = " Am the only guy dude"; Console.WriteLine("Creating object..."); }
                return _Instance;
            }
        }
        private ErrorHandler() { }

        public void LogError(string msg)
        {
            Console.WriteLine("Error Logged using the object with name:{0} from {1}", _name, msg);
        }
    }
}
