using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement
{
    class AI
    {


        

        public static int[] generateCode()
        {
            Random rnd = new Random();

            int[] codeValue = new int[4];
            for (int i = 0; i < codeValue.Length; i++)
            {

                codeValue[i] = rnd.Next(1, 7);

            }
            return codeValue;
            

        }
        public static string[] checkCode(int[] aiCode, int[] playerCode)

        {
            

            int[] colors = new int[7];
            for (int i = 0; i < colors.Length; i++)
            {
               colors[i]=0;


            }
            for (int i = 0; i < aiCode.Length; i++)
            {
                colors[(aiCode[i])]++;

                
            }

            string[] guessAnswer = new string[4];
            for (int i = 0; i < aiCode.Length; i++)
            { 
                if (aiCode[i] == playerCode[i])
                {
                guessAnswer[i] = "black";
                    
                    
                    colors[aiCode[i] ]--;
                }
                
                

            }
            for (int i = 0; i < aiCode.Length; i++)
            {
                if (aiCode.Contains(playerCode[i]) == true && colors[playerCode[i]] > 0 && guessAnswer[i] !="black" )
                
                {
                    guessAnswer[i] = "white";
                    colors[playerCode[i]]--;
                }
                else if(guessAnswer[i] != "black")
                {
                    guessAnswer[i] = "empty";
                }

            }



            return guessAnswer;
        }
    }
    class Program
    {
        
        
        static void Main(string[] args)


        {
            

            int[] playerCodeValue = new int[4];
            string[] playerCodeValueString = new string[4];
            
          
            

            int[] AICode = AI.generateCode();
            Console.WriteLine(AICode[0].ToString()+ AICode[1].ToString() + AICode[2].ToString() + AICode[3].ToString());
            for (int i = 0; i < playerCodeValueString.Length; i++)
            {
                Console.WriteLine("enter number " + (i+1));
                playerCodeValueString[i] = Console.ReadLine();
                
                
            }
            

            
            Console.WriteLine(playerCodeValueString[0] + playerCodeValueString[1] + playerCodeValueString[2] + playerCodeValueString[3]);
            for (int i = 0; i < playerCodeValue.Length; i++)
            {
                int x = Int32.Parse(playerCodeValueString[i]);
                playerCodeValue[i] = x;

            }
            string[] test = AI.checkCode(AICode, playerCodeValue);
            Console.WriteLine(test[0] + " " + test[1] + " " + test[2] + " " + test[3]);


            Console.ReadKey();
            
        }
    }
}
