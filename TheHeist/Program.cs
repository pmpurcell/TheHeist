using System;
using System.Linq;
using TheHeist.Models;

namespace TheHeist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            var teamQuestion = "Enter your Heist Team's name";
            var question1 = "Enter the team member's name:";
            var question2 = "Enter the team member's skill level";
            var question3 = "Enter the team member's courage level";

            int parsedSkill = 0;
            double parsedCourage = 0;
            bool successful = false;

            Console.WriteLine(teamQuestion);
            var teamName = Console.ReadLine();
            HeistTeam team = new HeistTeam(teamName);

            Console.WriteLine(question1);
            var name = Console.ReadLine();

            while (name != "") {

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

            successful = false;

            var teammate = new TeamMember(name, parsedSkill, parsedCourage);

            team.AddTeamMember(teammate);

            Console.WriteLine();
            Console.WriteLine(question1);
            name = Console.ReadLine();

            }
            team.ShowTeam();
            }
        }
    }
