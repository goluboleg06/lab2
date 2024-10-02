using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class SearchEngine
    {
        public List<string> Search(string query)
        { 
            List<string> dummyList = new List<string>{ "https://google.com", "https://google.org" };
            Console.WriteLine(dummyList);
            dummyList.ForEach(Console.WriteLine);
            return dummyList;
        }
    }
}
