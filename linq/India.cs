using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction
{
    class India
    {

        public string Name { get; set; }
        int _Id;
        public int Id
        {
            get
            {
                Console.WriteLine($"Returning {_Id} for {Name}");
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
    }
}


