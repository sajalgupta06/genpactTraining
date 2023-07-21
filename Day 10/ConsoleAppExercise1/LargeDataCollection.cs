using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise1
{
    internal class LargeDataCollection : IDisposable 
    {
        List<string> list;

        public LargeDataCollection(List<string> list)
        {
            this.list = new List<string>(list);

              
        }

        public void Add(string item)
        {
            list.Add(item);
            Console.WriteLine(item + " is added to the list");
        }

        public void Remove(string item)
        {
            int index = list.IndexOf(item);
            if (index != -1)
            {
                list.Remove(item);
                Console.WriteLine(item + " is Removed from the list");


            }
            else
            {

            Console.WriteLine(item + " does not exist");
            }

        }

        public void Print()
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void Search(string item)
        {
           int index = list.IndexOf(item);
            if(index != -1)
            {
                Console.WriteLine("Item is present at index " + index);
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        public virtual void Dispose(bool disposing)
        {
            list = null;
            Console.WriteLine("The list ha been disposed");
        }

        public void Dispose()
        {
           Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
