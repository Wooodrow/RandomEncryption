using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Die

    {  /// Instantiate the random Number object using System.Math
        static Random randomInt = new Random();


        // create a six sided die's attributes
       // string sides;
       public string diename; // This is to differentiate between multiple dice

        //Construct a die with a name 
        public Die(string name)
        {
            this.diename = name;// gives the die an attribute called "name"
        }    

  
    // Create a method for the DieClass to roll a single die
            public int rollDie()
        {
        int genNumber = randomInt.Next(1, 7); // Creates a number between 1 and 6 strangley enough the 7 is excluded

        return genNumber;// returns the value of the generated number so that it can be used elsewhere.
        } 


    }
}
