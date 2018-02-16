using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class DataPuller5
    {
        private Stops _stops;

        // rename our async method to ...Async by convention so our caller knows
        // introduce an exception

        public void InitializeRoutes()
        {
            InitializeRoutesAsync();
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
}
