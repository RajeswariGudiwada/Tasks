using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrainSchedule
{

    class Program
    {

        public static IEnumerable<object> Train_details { get; private set; }

        public static void Main(string[] args)
        {
            List<Train> Trains_details = new List<Train>();
            Trains_details.Add(new Train() { Tid = 111, Tname = "Rajdhani" });
            Trains_details.Add(new Train() { Tid = 112, Tname = "Shatabdi" });
            Trains_details.Add(new Train() { Tid = 113, Tname = "Garib Rath" });

            List<Station> station_details = new List<Station>();
            station_details.Add(new Station() { Sid = 211, Sname = "visakhapatnam" });
            station_details.Add(new Station() { Sid = 212, Sname = "vijayawada" });
            station_details.Add(new Station() { Sid = 213, Sname = "guntur" });
            station_details.Add(new Station() { Sid = 213, Sname = "nellore" });
            station_details.Add(new Station() { Sid = 213, Sname = "kurnool" });


            List<TrainStationSchedule> Trainschedule_details = new List<TrainStationSchedule>();
            Trainschedule_details.Add(new TrainStationSchedule() { Tid = 111, Sid = 211, arrival_time = "1:30", departure_time = "2:30", day = "monday" });
            Trainschedule_details.Add(new TrainStationSchedule() { Tid = 112, Sid = 212, arrival_time = "2:30", departure_time = "3:30", day = "tuesday" });
            Trainschedule_details.Add(new TrainStationSchedule() { Tid = 113, Sid = 213, arrival_time = "3:30", departure_time = "4:00", day = "wednesday" });
            Trainschedule_details.Add(new TrainStationSchedule() { Tid = 114, Sid = 214, arrival_time = "4:30", departure_time = "5:00", day = "sunday" });
            Trainschedule_details.Add(new TrainStationSchedule() { Tid = 115, Sid = 215, arrival_time = "5:30", departure_time = "6:30", day = "everyday" });


            Console.WriteLine("Enter station name");
            string stationName = Console.ReadLine();
            if (station_details.Exists(x => x.Sname == stationName))
            {
                Console.WriteLine("station name exists");
            }
            else
            {
                Console.WriteLine("station name not exists");
                Console.WriteLine("Try again");

            }
            Console.WriteLine("Enter Date mm/dd/yyyy");
         
            DateTime userDateTime;
            if (DateTime.TryParse
                (Console.ReadLine(), out userDateTime))
            {

                Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);
            }
            else
            {
                Console.WriteLine("incorrect");

            }
            Console.WriteLine("Enter Time HH:mm - 24hr format");
            String time = Console.ReadLine();
            List<int> final = new List<int>();
            foreach (TrainStationSchedule Time in Trainschedule_details)
            {
                if (Time.day == userDateTime.DayOfWeek.ToString() || Time.day == "Everyday")
                {
                    if ((DateTime.Parse(time) >= DateTime.Parse(Time.arrival_time) && DateTime.Parse(time) <= (DateTime.Parse(Time.departure_time))))
                    {
                        final.Add(Time.Tid);
                    }
                }
            }
            if (final.Count > 0)
            {
                Console.WriteLine("Aavailable are: \n");
                foreach (int result in final)
                {
                    Console.WriteLine(result);
                    foreach (KeyValuePair<int, string> enter in Train_details)
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

   



