using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WeatherService.WeatherSvc),
                 new Uri(@"http://localhost:8000/WeatherStation"))) 
            {
                host.AddServiceEndpoint(typeof(WeatherService.IWeatherSvc),
                    new BasicHttpBinding(), "WeatherService");
                host.Open();
                Console.WriteLine("Press enter to close weather service host");
                Console.ReadLine();
            }
        }
    }
}
