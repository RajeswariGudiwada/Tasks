using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSchedule
{
    class TrainStationSchedule
    {
        public int Tid { get; set; }
        public int Sid { get; set; }
        public string arrival_time { get; set; }
        public string departure_time { get; set; }
        public string day { get; set; }

        public String DateTime { get; set; }
    }
}
