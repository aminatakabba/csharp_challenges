using System;

namespace DatingProfile
{ 
  class Profile 
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronounce;
    private string[] hobbies;

    public Profile(
    string name, 
    int age, 
    string city, 
    string country, 
    string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronounce = pronounce;
      this.hobbies = new string[0]; 
    }
    public string ViewProfile()
    {
      string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronounce: {pronounce}";
      bio += "\nHobbies:";
      foreach (string hobby in this.hobbies)
      {
        bio += $" - {hobby}";
      }
      return bio;
    }
    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}
