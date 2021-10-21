using System;
using System.Collections.Generic;

namespace Online
{
    class Train
    {

        public int Tid { get; set; }
        public string Tname { get; set; }

    }
    class Station
    {

        public string Sname { get; set; }
        public int Sid { get; set; }

    }
    class TrainStationSchedule
    {
        public int Tid { get; set; }
        public int Sid { get; set; }
        public string arrival { get; set; }
        public string departure { get; set; }
        public string day { get; set; }

    }
}
