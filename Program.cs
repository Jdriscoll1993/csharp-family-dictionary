using System;
using System.Collections.Generic;

namespace family_dictionary
{
  class Program
  {
    static void Main(string[] args)
    {


      Dictionary<string, Dictionary<string, string>> family = new Dictionary<string, Dictionary<string, string>>();
      family.Add("father", new Dictionary<string, string>(){
          {"name", "Dan"},
          {"age", "63"}
      });
      family.Add("mother", new Dictionary<string, string>(){
          {"name", "Sue"},
          {"age", "59"}
      });
      family.Add("brother", new Dictionary<string, string>(){
          {"name", "Sam"},
          {"age", "21"}
      });


      foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in family)
      {
        Console.WriteLine($" {familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
      }


      // Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property.

      Console.WriteLine("Hello World!");
    }
  }
}


