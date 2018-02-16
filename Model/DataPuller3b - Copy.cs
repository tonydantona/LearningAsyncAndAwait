using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class DataPuller3b
    {
        private Stops _stops;
        private Form _form;

        public async Task InitializeRoutes(Form form)
        {
            _form = form;

            Task<Stops> stops = IntitializeStopsAsync();

            DoSomeIndependentWork();

            // await ensures that this will not be done until the task is completed
            Stops myStops = await stops;

            Stop stop = myStops[0];
        }

        public async Task<Stops> IntitializeStopsAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                _stops = new Stops();
            });

            return _stops;
        }

        public Stops IntitializeStops()
        {
            Task.Run(() =>
            {
                Thread.Sleep(8000);
                _stops = new Stops();
            });

            return _stops;
        }

        private void DoSomeIndependentWork()
        {
            _form.Text = "Working";
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                _form.Text = _form.Text + ".";
            }

            _form.Text = "Done";

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
