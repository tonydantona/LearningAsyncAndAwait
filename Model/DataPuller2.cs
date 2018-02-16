using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class DataPuller2
    {
        private Stops _stops;
        
        // So does the async keyword make everything in the method run asynchronously?
        public async void InitializeRoutes()
        {
            Thread.Sleep(5000);
            _stops = new Stops();
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


    // just marking the method as async does not make everything in the body asnyc - it still runs on the UI thread
    // what async does though is give us the ability to schedule a continuation

}
