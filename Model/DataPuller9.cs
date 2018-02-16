using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class DataPuller9
    {
        private Stops _stops;

        // add await and async to the caller

        public async void InitializeRoutes()
        {
            try
            {
                await InitializeRoutesAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public async Task InitializeRoutesAsync()
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

    // caveat - we still have an async void on the caller.
}
