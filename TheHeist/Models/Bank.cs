using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist.Models
{
    internal class Bank
    {
        public int difficultyLevel { get; set; } = 100;


        public void RunHeist(int skillSum){
                
          if (difficultyLevel >= skillSum)
            {
                Console.WriteLine("The heist failed!");
            }
        else
            {
                Console.WriteLine("The heist was successful!");
            }
        }
    }
}
