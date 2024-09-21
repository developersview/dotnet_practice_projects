using System;

namespace DatingProfile
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name, int age, string city, string country, string[] hobbies, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = hobbies;
        }

        public string ViewProfile()
        {
            string bio = $"Name: {this.name},\nAge: {this.age},\nCity: {this.city}, \nCountry: {this.country}, \nPronouns: {this.pronouns}, \nHobbies: ";
            foreach (string hobby in hobbies)
            {
                bio += (hobby + ", ");
            }
            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
