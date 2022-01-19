using System;
using TheHeist.Models;

namespace TheHeist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            var question1 = "Enter the team member's name:";
            var question2 = "Enter the team member's skill level";
            var question3 = "Enter the team member's courage level";

            int parsedSkill = 0;
            double parsedCourage = 0;
            bool successful = false;

            Console.WriteLine(question1);
            var name = Console.ReadLine();

            while (!successful) {
            Console.WriteLine(question2);
            var skill = Console.ReadLine();
            successful = int.TryParse(skill, out parsedSkill);
            }

            successful = false;

            while (!successful) { 
            Console.WriteLine(question3);
            var courage = Console.ReadLine();
            successful = double.TryParse(courage, out parsedCourage);
            }

            var teammate = new TeamMember(name, parsedSkill, parsedCourage);

            teammate.Print();
        }
    }
}
