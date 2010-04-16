using System;
using System.Collections.Generic;

namespace DriverLogger.Biz
{
    public class SaveCurrentLog 
    {
        public int UserId { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        private IGeoData _geoDataInterface = null;
        public IGeoData GeoDataInterface
        {
            get
            {
               return _geoDataInterface;
            }
            set
            {
                _geoDataInterface = value;
            }
        }

        public List<string> Save(Log currentLog)
        {
            List<string> errors = new List<string>();
            if (UserId>0)
            {
                errors.AddRange(Validate(currentLog));                
            }
            else
            {
                errors.Add("Invalid User Id");
            }

            return errors;
        }

        public IList<string> Validate(Log currentLog)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(currentLog.Activity))
            {
                errors.Add("Activity Required");
            }

            return errors;
        }


        public Log GetLatLonForCity()
        {
            Log result = GeoDataInterface.ReturnCityState(City, State);
            return result;
        }
    }

    public interface IGeoData
    {
        Log ReturnCityState(string city, string state);
    }

    public class Log
    {
        public DateTime Date { get; set; }
        public string Activity { get; set; }
        public int Lat { get; set; }
        public int Lon { get; set; }
    }
}
