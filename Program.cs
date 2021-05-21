using System;

namespace planetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double earth_time=31557600;
            double earth_traveler_time=631154000;

            float earth_in_space_age = earth_traveler_time/earth_time;

            String [] planets = new string[4];
            planets[0]="Venus";
            planets[1]="Mars";
            planets[2]="Jupiter";
            planets[3]="Neptune";

            double [] ages= new double[4];
            ages[0]=19414149;
            ages[1]=59354032;
            ages[2]=374355659;
            ages[3]=5200418560;


    for (int i = 0 , j=0; i < planets.Length && j< ages.Length; i++,j++)
    {
    float traveler_years = earth_in_space_age/ages[j];
    Console.WriteLine(planets[i] + " age is : " + traveler_years + " Earth-years old ");
     }

    }
 }
           
}
