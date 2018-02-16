using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class Stops :IEnumerable<Stop>
    {
        public Stops()
        {
            _stops = new Stop[ArraySize];

            for (int i = 0; i < ArraySize; i++)
            {
                _stops[i] = new Stop {StopID = i + 1};
                _stops[i].Address = i + " Main St";
            }
        }
       
        public IEnumerator<Stop> GetEnumerator()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                yield return _stops[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        private readonly Stop[] _stops; 

        private const int ArraySize = 5;

        public Stop this[int i] => _stops[i];
    }
}