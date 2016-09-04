using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWeatherSvc
    {

        [OperationContract]
        float GetCurrentTemp();

        [OperationContract]
        float GetWindSpeed();

        [OperationContract]
        void SendWindSpeed(float windSpeed);

        [OperationContract]
        int GetNumberOfArtists();
    }
  
}
