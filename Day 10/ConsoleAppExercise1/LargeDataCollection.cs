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
        }

        public void Remove(string item)
        {
            list.Remove(item);
        }

        public virtual void Dispose(bool disposing)
        {
            list = null;
        }

        public void Dispose()
        {
           Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
