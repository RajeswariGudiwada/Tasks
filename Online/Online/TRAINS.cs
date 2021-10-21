using System;
using System.Collections.Generic;

namespace Online
{
    class TRAINS

    {
        static void Main(string[] args)
        {
            Train T1 = new Train()
            {
                Tid = 1,
                Tname = "Rajdhani"
            };
            Train T2 = new Train()
            {
                Tid = 2,
                Tname = "Shatabdi"
            };
            Train T3 = new Train()
            {
                Tid = 3,
                Tname = "Garib Rath"
            };

            Station S1 = new Station()
            {
                Sid = 11,
                Sname = "guntur"
            };
            Station S2 = new Station()
            {
                Sid = 12,
                Sname = "nellore"
            };
            Station S3 = new Station()
            {
                Sid = 13,
                Sname = "Rajahmundry"
            };
            Station S4 = new Station()
            {
                Sid = 14,
                Sname = "visakhapatnam"
            };
            Station S5 = new Station()
            {
                Sid = 15,
                Sname = "prakasam"
            };

            TrainStationSchedule Ts1 = new TrainStationSchedule()
            {
                Tid = 1,
                Sid = 11,
                arrival = "1:30",
                departure = "2:30",
                day = "Thursday",
            };
            TrainStationSchedule Ts2 = new TrainStationSchedule()
            {
                Tid = 2,
                Sid = 12,
                arrival = "1:30",
                departure = "2:30",
                day = "Monday"
            };
            TrainStationSchedule Ts3 = new TrainStationSchedule()
            {
                Tid = 3,
                Sid = 13,
                arrival = "1:30",
                departure = "2:30",
                day = "Tuesday"
            };
            TrainStationSchedule Ts4 = new TrainStationSchedule()
            {
                Tid = 1,
                Sid = 14,
                arrival = "1:30",
                departure = "2:30",
                day = "Wednesday"
            };
            TrainStationSchedule Ts5 = new TrainStationSchedule()
            {
                Tid = 2,
                Sid = 15,
                arrival = "1:30",
                departure = "2:30",
                day = "Everyday"
            };

            List<KeyValuePair<int, string>> TrainList = new List<KeyValuePair<int, string>>();
            TrainList.Add(new KeyValuePair<int, string>(T1.Tid, T1.Tname));
            TrainList.Add(new KeyValuePair<int, string>(T2.Tid, T2.Tname));
            TrainList.Add(new KeyValuePair<int, string>(T3.Tid, T3.Tname));


            List<KeyValuePair<int, string>> StationList = new List<KeyValuePair<int, string>>();
            StationList.Add(new KeyValuePair<int, string>(S1.Sid, S1.Sname));
            StationList.Add(new KeyValuePair<int, string>(S2.Sid, S2.Sname));
            StationList.Add(new KeyValuePair<int, string>(S3.Sid, S3.Sname));
            StationList.Add(new KeyValuePair<int, string>(S4.Sid, S4.Sname));
            StationList.Add(new KeyValuePair<int, string>(S5.Sid, S5.Sname));

            List<TrainStationSchedule> scheduleList = new List<TrainStationSchedule>();
            scheduleList.Add(Ts1);
            scheduleList.Add(Ts2);
            scheduleList.Add(Ts3);
            scheduleList.Add(Ts4);
            scheduleList.Add(Ts5);

            Console.WriteLine("Enter station name");
            string stationName = Console.ReadLine();
            int stationId = 0;
            foreach (KeyValuePair<int, string> place in StationList)
            {
                if (place.Value.Equals(stationName))
                {
                    stationId = place.Key;

                }
            }
            if (stationId == 0)
            {
                Console.WriteLine("not exsit");
                return;
            }

            Console.WriteLine("Enter Date mm/dd/yyyy");
            DateTime userDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            {
                Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);
            }
            else
            {
                Console.WriteLine("incorrect");
                return;
            }
            Console.WriteLine("Enter Time HH:mm - 24hr format");
            string time = Console.ReadLine();

            List<int> Times = new List<int>();
            foreach (TrainStationSchedule Time in scheduleList)
            {
                if (Time.day == userDateTime.DayOfWeek.ToString() || Time.day == "Everyday")
                {
                    if ((DateTime.Parse(time) >= DateTime.Parse(Time.arrival) && DateTime.Parse(time) <= (DateTime.Parse(Time.departure).AddHours(1))) &&
                        stationId == Time.Sid)
                    {
                        Times.Add(Time.Tid);
                    }
                }
            }
            if (Times.Count > 0)
            {
                Console.WriteLine("Aavailable are: \n");
                foreach (int result in Times)
                {
                    foreach (KeyValuePair<int, string> enter in TrainList)
                    {
                        if (enter.Key == result)
                        {
                            Console.WriteLine(enter.Value + "\n");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Not Available");
            }
        }
    }
}

