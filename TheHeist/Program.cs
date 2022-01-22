using System;
using System.Linq;
using TheHeist.Models;

namespace TheHeist
{
    internal class Program
    {
        static void Main(string[] args)
        {
//### Phase Three

//            The program should be updated to...

//1.Stop displaying each team member's information.
//2.Store a value for the* bank's difficulty level*. Set this value to 100.
//3.Sum the skill levels of the team.Save that number.
//4.Compare the number with the bank's difficulty level. If the team's
//skill level is greater than or equal to the bank's difficulty level,
//Display a success message, otherwise display a failure message.

           Console.WriteLine("Plan Your Heist!");

            var teamQuestion = "Enter your Heist Team's name";
            var question1 = "Enter the team member's name:";
            var question2 = "Enter the team member's skill level";
            var question3 = "Enter the team member's courage level";

            int parsedSkill = 0;
            double parsedCourage = 0;
            int teamSkill = 0; 
            bool successful = false;

            Console.WriteLine(teamQuestion);
            var teamName = Console.ReadLine();
            HeistTeam team = new HeistTeam(teamName);
            Bank bank = new Bank();

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
            teamSkill += parsedSkill;

            Console.WriteLine();
            Console.WriteLine(question1);
            name = Console.ReadLine();

            }
            team.ShowTeam();
            bank.RunHeist(teamSkill);
            }
        }
    }
