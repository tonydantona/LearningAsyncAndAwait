using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class DataPuller6
    {
        private Stops _stops;

        // introduce exception handling ???

        public void InitializeRoutes()
        {
            try
            {
                InitializeRoutesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public async void InitializeRoutesAsync()
        {
            var result = await Task.Run(() =>
            {
                throw new AbandonedMutexException();

                Thread.Sleep(5000);
                _stops = new Stops();
                return _stops[0];
            });

            Stop stop = result;
        }

        public IEnumerable<Stop> GetDetailRoute()
        {
            return _stops;
        }

        public string PrintText()
        {
            return "Printing...";
        }
    }

    // we could wrap the entire async method in a try/catch - that would stop if from crashing.
}
