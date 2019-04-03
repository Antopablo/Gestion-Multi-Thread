using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5thread
{
    class RandomMaison : Random
    {
        private static RandomMaison _Instance;

        public static RandomMaison Instance
        {
            get {
                if (_Instance == null)
                {
                    _Instance = new RandomMaison();
                }
                return _Instance;
            }
           
        }

    }
}
