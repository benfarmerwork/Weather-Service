using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In orsingder to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WeatherSvc : IWeatherSvc
    {
        static float _windSpeed = 0;
        public float GetCurrentTemp()
        {
            return 21.5F;
        }

        public int GetNumberOfArtists()
        {
            using (var sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kathy\Documents\LearningDatabases.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                
            }

            return 10;

        }

        public float GetWindSpeed()
        {
            return _windSpeed;
        }

        public void SendWindSpeed(float windSpeed)
        {
            _windSpeed = windSpeed;
        }

    }
}
