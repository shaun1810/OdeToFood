using System;
using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeter
    {  
         string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        Greeter(IConfiguration configFile) 
        {
            _configuration = configFile;
        }

        string IGreeter.GetMessageOfTheDay()
        {
            string messageOfTheDay  = _configuration["Greeting"];
            return messageOfTheDay;
        }
    }

}