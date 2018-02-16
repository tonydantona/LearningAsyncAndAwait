using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class DataPuller4
    {
        private Stops _stops;

        // example of returning a result within the method
        public async void InitializeRoutes()
        {
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
}
