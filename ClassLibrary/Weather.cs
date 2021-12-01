using System;

namespace ClassLibrary
{
    public class Weather
    {
        private double degreesCelsious;
        private double humidity;
        private double windSpeed;

        public Weather()
        {
            this.degreesCelsious = 0;
            this.windSpeed = 0;
            this.humidity = 0;
        }
        public Weather(double DegreesCelsious, double Humility, double WindSpeed)
        {
            this.degreesCelsious = DegreesCelsious;
            this.windSpeed = WindSpeed;
            this.humidity = Humility;
        }

        public double GetTemperature()
        {
            return degreesCelsious;
        }

        public void SetTemperature(double degreesCelsious)
        {
            this.degreesCelsious = degreesCelsious;
        }

        public double GetHumidity()
        {
            return humidity;
        }

        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }

        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }

        public double CalculateFeelsLikeTemperature()
        {
            double c1 = -8.78469475556;
            double c2 = 1.61139411;
            double c3 = 2.33854883889;
            double c4 = -0.14611605;
            double c5 = -0.012308094;
            double c6 = -0.0164248277778;
            double c7 = 0.002211732;
            double c8 = 0.00072546;
            double c9 = -0.000003582;
            double HI;

            HI = c1 + c2 * degreesCelsious + c3 * humidity + c4 * degreesCelsious * humidity
                + c5 * Math.Pow(degreesCelsious, 2) + c6 * Math.Pow(humidity, 2) + c7 * Math.Pow(degreesCelsious, 2) * humidity
                + c8 * degreesCelsious * Math.Pow(humidity, 2) + c9 * Math.Pow(degreesCelsious, 2) * Math.Pow(humidity, 2);

            return HI;
        }


        public double CalculateWindChill()
        {
            if (windSpeed > 4.8 && degreesCelsious <= 10)
            {

                return (13.12 + 0.6215 * degreesCelsious - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * (degreesCelsious) * (Math.Pow(windSpeed, 0.16)));

            }
            else
            {
                return 0;
            }


        }

    }
}
