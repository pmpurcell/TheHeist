using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist.Models
{
    internal class HeistTeam
    {

        public HeistTeam(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
        public double TeamCourage { get; set; }

        // Method for Adding New Team Member
        public void AddTeamMember(TeamMember member)
        {
            TeamMembers.Add(member);
        }

        //Method for Displaying Team Info
        public void ShowTeam()
        {
            Console.WriteLine($@"{Name}
{TeamMembers.Count()} members");

            TeamMembers.ForEach(member =>
            {
                member.MemberDetails();
            });
        }
    }
}
