using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile profile = new Profile(
              "Sam Drakkila",
               30,
               "New York",
               "USA",
               new string[]{
                 "listening to audiobooks and podcasts",
                 "playing rec sports like bowling and kickball"
               },
               "he/him"
              );
            Console.WriteLine(profile.ViewProfile());
        }
    }
}
