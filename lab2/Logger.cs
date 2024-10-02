using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Logger
    {
        private List<string> logs = new List<string>();

        public void LogQuery(string query)
        {
            logs.Add(query);
        }

        public List<string> GetTopQueries(int n)
        {
            return logs.GroupBy(q => q)
                       .OrderByDescending(g => g.Count())
                       .Take(n)
                       .Select(g => g.Key)
                       .ToList();
        }
    }
}
