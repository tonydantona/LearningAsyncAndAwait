using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class DataPuller7
    {
        private Stops _stops;

        // what happens if we throw the exception before the the await Task

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
            throw new AbandonedMutexException();

            var result = await Task.Run(() =>
            {
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

    // why can't we catch the exception?
}
