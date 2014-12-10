using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerInSideObjectInitialization
{
    class Program
    {
        /// <summary>
        /// Exploring Old way and New way(C# 6.0) of Initializing Indexers in Side Object Initialization
        /// with exclusive Fun with "Anonymous Objects"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Old way of getting Indexer in Side Object Initializer Done //
            Dictionary<string, string> pick = new Dictionary<string, string> { { "controller", "Home" }, { "action", "index" } };
            Console.WriteLine("Executing PICK:");
            Console.WriteLine(pick["controller"]); Console.WriteLine(pick["action"]);
            // New way of getting Indexer in Side Object Initializer Done //
            Dictionary<string, string> dussy = new Dictionary<string, string> {["controller"] = "Home",["action"] = "Index" };
            Console.WriteLine("Executing DUSSY:");
            Console.WriteLine(dussy["controller"]); Console.WriteLine(dussy["action"]);
            // Fun with Anonymous Object //
            Console.WriteLine("Fun with anonymouse Objects:");
            Console.WriteLine((new { controller = "Home", action = "Index" }).action);
            Console.WriteLine((new { controller = "Home", action = "Index" }).controller);
        }
    }
}
