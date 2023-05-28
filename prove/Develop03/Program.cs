using System;

class Program
{
    static void Main(string[] args)
    {   
       List<string> listScripture = new List<string> { "For ", "I ", "am ", "persuaded, ", "that ", "neither ", "death, ", "nor ", "life, ", "nor ", "angels, ", "nor ", "principalities, ", "nor ", "powers, ", "nor ", "things ", "present, ", "nor ", "things ", "to ", "come; ", "Nor ", "height, ", "nor ", "depth, ", "nor ", "any ", "other ", "creature, ", "shall ", "be ", "able ", "to ", "separate ", "us ", "from ", "the ", "love ", "of ", "God, ", "which ", "is ", "in ", "Christ ", "Jesus ", "our ", "Lord. "};
        Random randomGenerator = new Random();
        
        string action = "";
        while (!(action =="quit")){
            
            int randomNumber = randomGenerator.Next(0, listScripture.Count());
            int randomNumber1 = randomGenerator.Next(0, listScripture.Count());
            int randomNumber2 = randomGenerator.Next(0, listScripture.Count());
            
            Scripture scripture = new Scripture();
            Console.Write(scripture.GetScripture());
            
            foreach(string item in listScripture)
            {
                Console.Write(item);               
            }
            
            listScripture[randomNumber] =  "___ ";
            listScripture[randomNumber1] =  "___ ";
            listScripture[randomNumber2] =  "___ ";
            
            
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            action = Console.ReadLine();
            Console.Clear();

        }
        
        
    }
}