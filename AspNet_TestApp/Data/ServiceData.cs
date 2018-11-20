using AspNet_TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_TestApp.Data
{
    public class ServiceData
    {
        public static void Init(ServicesContext servicesContext)
        {
            if (!servicesContext.Services.Any())
            {
                servicesContext.Services.AddRange(
                new Services
                {
                    Service_Name = "установка унитаза",
                    Service_Discription = "Установка любых видов унитазов",
                    Service_Coast = 19

                },
                new Services
                {
                    Service_Name = "Очистка труб",
                    Service_Discription = "Пробитие засоров любой сложности",
                    Service_Coast = 25

                },
                new Services
                {
                    Service_Name = "Ремонт бытовой техники",
                    Service_Discription = "Ремонт всех видов бытовой техники",
                    Service_Coast = 35

                },
                new Services
                {
                    Service_Name = "Установка счетчиков",
                    Service_Discription = "Установка счетчиков для воды и газа",
                    Service_Coast = 30

                }

                );

                servicesContext.SaveChanges();


            }
        }
    }
}
