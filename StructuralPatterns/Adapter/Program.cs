using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adapter / wrapper - structural pattern
    /// 
    /// 2 types
    /// - object adapter pattern
    /// - class adapter pattern
    /// 
    /// Purpose:
    /// (1) Making 2 incompatible entities to interact each other by (a) re-routing calls (b) transforming data
    /// 
    /// Example here: Object adapter pattern
    /// </summary>
    class Program:ICollection<string>
    {
        //object adaptor pattern
        AdapteeStack _stack = new AdapteeStack();
        static void Main(string[] args)
        {
            Program pgm = new Program();
            pgm.Add("One");
            pgm.Add("Two");
            pgm.Add("Three");

            Console.WriteLine("Count: {0}", pgm.Count);
            Console.ReadKey();
        }

        public void Add(string item)
        {
            _stack.Push(item);            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(string item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                return _stack.Count();
            }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(string item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
