using System;

namespace planetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            long earth_time=31557600L;
            long earth_traveler_time=631154000;

            float earth_in_space_age = earth_traveler_time/earth_time;

            String [] planets = new string[4];
            planets[0]="Venus";
            planets[1]="Mars";
            planets[2]="Jupiter";
            planets[3]="Neptune";

            float [] ages= new float[4];
            ages[0]=19414149F;
            ages[1]=59354032F;
            ages[2]=374355659F;
            ages[3]=5200418560F;


    for (int i = 0 , j=0; i < planets.Length && j< ages.Length; i++,j++)
    {
    float traveler_years = earth_in_space_age/ages[j];
    Console.WriteLine(planets[i] + " age is : " + traveler_years + " Earth-years old ");
     }

    }
 }
           
}
