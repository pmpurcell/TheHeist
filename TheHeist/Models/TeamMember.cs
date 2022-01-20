using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist.Models
{
    internal class TeamMember
    {
        public TeamMember(string name, int skill, double courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public void MemberDetails()
        {
            var output = ($@"
_________________________
Name: {Name}
Skill Level: {SkillLevel}
Courage: {CourageFactor}
_________________________");
            Console.WriteLine(output);
        }
    }
}
