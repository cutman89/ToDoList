using System;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static async  Task Main(string[] args)
        {
            ViewModelTest model = new ViewModelTest();
             await model.Search();
        }
    }
}
