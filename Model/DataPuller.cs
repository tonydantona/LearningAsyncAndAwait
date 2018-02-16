using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class DataPuller
    {
        private Stops _stops;

        public void InitializeRoutes()
        {
            Thread.Sleep(5000);
            _stops = new Stops();                       
        }

        public IEnumerable<Stop> GetDetailRoute()
        {
            Thread.Sleep(5000);
            return _stops;
        }

        public string PrintText()
        {
            return "Printing...";
        }

        // we're working on the UI thread
    }
}
