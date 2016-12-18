//Before using this program please make a folder at C:\Users\Public\TestFolder\
// Then make two text files, the first is called WriteLines.txt and the second is WriteLines2.txt
// So the full addresses will be C:\Users\Public\TestFolder\WriteLines.txt &
//C:\Users\Public\TestFolder\WriteLines2.txt
// Those are the files needed for this program to run as intended.The program itself rolls 2 dice 100 times. . . twice!
//and takes the first instance of the rollDice method and places any pairs found in the two dice rolled, into a file 
//where it can be retieved later by using Linq queries.

//The second instantiation of the rollDice method places the product of the dice rolls
//      (only when they pair as with the first instance of this method)
//and the counter value for the current roll number, placing that into a second file where it too can be 
//queried using Linq and Ienumerable.Except to compare the difference between the two files. 
//It is a fun little program that demontrates the except method from the Ienumerable class that compares two "similar" outputs for 
//the purpose of developing encryption methods based on how the output files are exported and then compared through 
//the use of the Except method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DiceRoller
{
    class DiceRollerMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Paired rolls are as follows:"); // This writes a line to the console informing the user the program is running
            DiceRollerMain diceRoller = new DiceRollerMain();// Instantiates a rollDice object
            diceRoller.rollDice();
            DiceRollerMain diceRoller2 = new DiceRollerMain();// A second instance of rollDice
            diceRoller.rollDice();
            
          IEnumerable<string> words1 = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt"); //Reads all lines from the output file whose method is in the rollDice method

            foreach (string word1 in words1)//the primary loop intended to read all the lines of the 
                                            //file to enable the comparison and display of the lines in the file
            {
            

            


                IEnumerable<string> words2 = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");//Reads all lines from the output file whose method is in the rollDice method

                foreach (string word2 in words2)//the primary loop intended to read all the lines of the 
                                                //file to enable the comparison and display of the lines in the file
                                                //This is to provide double the fun and to show how an encryption method could be obtained by writing two files simultaneously
                                                //and garnering the information through what is left after an exept clause parses the file
                {
                    Console.Write("Product = " + word2 + "Sum = " + word1);

                    //If you comment out the next 6 lines of code you can see the original output of the file before the extraction through 
                    //the except method chnages the output dramatically and sifts through the data making a descrambler.
                                                            
                    var result = words2.Except(words1);         //<<----HERE
                    var result2 = word1.Except(word2);



                    // Show.                                  
                    foreach (var element in result)
                    {
                        Console.WriteLine(element);
                    }
                    foreach (var element in result2)
                    {
                        Console.WriteLine(element);
                    }                                       //    <<----TO HERE          
                }
            }

            

            Console.WriteLine("now exiting");
        }
           

        

        public DiceRollerMain() {}// Public Dice roller class expanded from week 1 but basically the same

        public void rollDice()// begin method
        {            
            Die luckyDie = new Die("Lucky"); // Declare die names 
            Die unluckyDie = new Die("unlucky");
           
            for (int counter = 0; counter < 100; counter++) // Begin dice rolling loop (iterates 100 times for the two declared dice)
            {
                int luckyDieRoll = luckyDie.rollDie(); // Creates variables to put values into
                int unluckyDieRoll = unluckyDie.rollDie();
                
                if (unluckyDieRoll == luckyDieRoll)
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter
                        (@"C:\Users\Public\TestFolder\WriteLines.txt", true))// determines which file to use and initializes
                                                                             //the file writer
                    {
                        file.WriteLine(counter + luckyDieRoll);// writes to file of choice
                    }
                if  (luckyDieRoll == unluckyDieRoll)
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter
                        (@"C:\Users\Public\TestFolder\WriteLines2.txt", true)) // determines which file to use and initializes
                                                                               //the file writer...again for the second pair of dice
                    {
                        file.WriteLine( counter * luckyDieRoll); // Writes to the second file of choice
                  }
                if (counter == 99)// this is just to show the break of each set for the first pair of dice
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines.txt", true))
                    {
                        file.WriteLine("This is the end of a set and the beginning of a new one");//Displays a string between the end 
                                                                                        //of one set and the beginning of another
                    }



            }
                    

            }
      
            

            
         }
    
}//end of file
