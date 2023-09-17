using Proect_1.DAL;
using Proect_1.Helpers;
using Proect_1.Models;
using Proect_1.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proect_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ConnectCategoryModuleAsync().Wait();

            Main(args);

        }

        static async Task ConnectCategoryModuleAsync()
        {
            CategoryModule categoryModule = new CategoryModule();

            Console.WriteLine("1. Manage Incomes     2. Manage Expenses     3. Manage Categories");

            int input = categoryModule.GetOptionInput();

            Console.Clear();

            switch (input) 
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    categoryModule.ShowOptionsAsync().Wait();
                    break;
                default:
                    return;
            }
        }                
    }
}
