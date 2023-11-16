using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Day9
{
    public class LargeDataCollection:IDisposable
    {
        private List<Object> dataCollection;

        public LargeDataCollection(List<object>initialdata)
        {
            dataCollection = new List<object>(initialdata);
        }

        public void Add(object item)
        {
            dataCollection.Add(item);
        }
        public void Remove(object item)
        {
            dataCollection.Remove(item);
        }
        public object getElement(int index)
        {
            try
            {
                if (index > 0 && index < dataCollection.Count)
                {
                    return dataCollection[index];
                }
                else
                {
                    return "index out of bound";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

           

        }
        public void print()
        {
            foreach(var item in dataCollection)
            {
                Console.WriteLine(item);
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
              
                dataCollection.Clear();
                dataCollection = null;
            }


        }

        ~LargeDataCollection()
        {
            Dispose(false);
        }

    }
}
