using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Heater heater = new Heater();
            heater.warmer();
            Console.WriteLine(heater.GetTemperature());
            heater.cooler();
            Console.WriteLine(heater.GetTemperature());

        }
    }
    class Heater
    {
        private int temperature;
        private int min;
        private int max;
        private int increment;

        public void warmer ()
        {
                if (temperature <= max)
                {
                    temperature += increment;
                }

        }
        public void cooler ()
        {
                if (temperature >= min)
                {
                    temperature -= increment;
                }
            }


        public int GetTemperature() { return temperature; }

        public  Heater ()
        {
                temperature = 15;
                increment = 5;
                max = 250;
                min = -250;
        }
    }
}