# RandomEncryption
Before using this program please make a folder at C:\Users\Public\TestFolder\  Then make two text files, the first is called WriteLines.txt and the second is WriteLines2.txt  So the full addresses will be C:\Users\Public\TestFolder\WriteLines.txt &amp; //C:\Users\Public\TestFolder\WriteLines2.txt  Those are the files needed for this program to run as intended.The program itself rolls 2 dice 100 times. . . twice! and takes the first instance of the rollDice method and places any pairs found in the two dice rolled, into a file where it can be retieved later by using Linq queries. The second instantiation of the rollDice method places the product of the dice rolls (only when they pair as with the first instance of this method) and the counter value for the current roll number, placing that into a second file where it too can be queried using Linq and Ienumerable.Except to compare the difference between the two files.  It is a fun little program that demontrates the except method from the Ienumerable class that compares two "similar" outputs for the purpose of developing encryption methods based on how the output files are exported and then compared through the use of the Except method.