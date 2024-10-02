using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   internal class SearchEngineFacade
    {
        private SearchEngine searchEngine;
        private Logger logger;

        public SearchEngineFacade()
        {
            searchEngine = new SearchEngine();
            logger = new Logger();
        }

        public List<string> Search(string query)
        {
            logger.LogQuery(query);
            return searchEngine.Search(query);
        }

        public List<string> GetTopQueries(int n)
        {
            return logger.GetTopQueries(n);
        }
    }
}
