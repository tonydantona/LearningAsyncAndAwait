using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class DataPuller3
    {
        private Stops _stops;

        public async void InitializeRoutes()
        {
            // await gives us two things:
            // 1. task is run on a separate thread, so GUI is responsive
            // 2. guarantees that statements in the conitunuation (Stop stop = _stops[0],
            //    will not be run until await Task is complete (await this task)
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                _stops = new Stops();
            });

            // await ensures that this will not be done until the task is completed
            Stop stop = _stops[0];
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

 
    // we need to make sure the code executed after the Task is in a continuation - we must schedule a continuation
    // add await: 1. Notice - GUI is responsive - wait for the breakpoint.  2. click GetRouteDetails button right after initialize

    // when you use the await keyword, the continuation (in this case: Stop stop = _stops[0]) is executed on the calling context (UI thread here).
    // If I had access to the Form here, I could change something on it after the await (no invoke needed)
}
