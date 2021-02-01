using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Crime
    {
        private DateTime Date;
        private string Location;
        private string Act;

        public Crime(DateTime date, string location, string act)
        {
            Date = date;
            Location = location;
            Act = act;
        }

        public string GetLocation()
        {
            return Location;
        }

        public string GetAct()
        {
            return Act;
        }

        public DateTime GetDate()
        {
            return Date;
        }
    }
}
