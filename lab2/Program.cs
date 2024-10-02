using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new SearchEngineFacade();
            var searchEngine = new SearchEngine();
            facade.Search("Запит 1");
            facade.Search("Запит 2");
            facade.Search("Запит 1");

            searchEngine.Search("Запит 1"); 

            var topQueries = facade.GetTopQueries(2);
            topQueries.ForEach(Console.WriteLine);
        }
    }
}