using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit1.StarterProgram.Main_Menu_Handler;
using Unit1.StarterProgram.Posible_Outcomes;
namespace Unit1.StarterProgram.Main_Loop
{
    public class Program_Main_Loop
    {
        public static string[] User_Imput_Awnser = {"A", "a", "B", "b","C","c"};
        public static string[] User_Imput_Awnser2 = { "A", "a", "b", "B" };
        public static void Init_Main_Loop()
        {
#if DEBUG
            //anything writen here won't show up on release builds so carefull
            Console.WriteLine("Debug: Main loop called");
#endif
            Console.WriteLine("You have to get these 3 items across the river:\nA chicken a fox and a cabbage");
            Console.WriteLine("But you are only able to take one at a time\nbut if left alone with the item the chicken eates the cabbage,\nthe fox eates the chicken but it does not eat the cabbage");
            Console.WriteLine("Do you understand the rules?");
            var user_imput = Console.ReadLine();
            var Yes_Array = Main_Menu.User_Imput_Yes;
            var No_Array = Main_Menu.User_Imput_No;
            for (int i =  0; i < Yes_Array.Length; i++) { if (user_imput == Yes_Array[i]) { Console.Clear();  Init_Game(); } }
            for (int i =  0; i < No_Array.Length; i++) { if (user_imput == No_Array[i]) { Console.Clear(); Main_Menu.Generate_Main_Menu() ; } }

        }
        public static void Init_Game()
        {
            
#if DEBUG
            //anything writen here won't show up on release builds so carefull
            Console.WriteLine("Debug: Init game was called");
#endif
            Console.WriteLine("Which one are you going to take first?");
            Console.WriteLine("A: Chicken B: Fox C: Cabbage");
            var First_Part_Imput = Console.ReadLine();
            for(int i = 0; i < User_Imput_Awnser.Length; i++) 
            { 
                if (First_Part_Imput == User_Imput_Awnser[i]) 
                { 
                    Console.WriteLine("You have taken over " +  User_Imput_Awnser[i]); 
                    if(User_Imput_Awnser[i].ToUpper() == "A")
                    {
                        Posible_Outcomes_Arrays.UserChoices[0] = "Chicken";
                        Posible_Outcomes_Bools.Chicken_Was_Taken = true;
                        Loop_Main_Loop();
                    }
                    if (User_Imput_Awnser[i].ToUpper() == "B")
                    {
                        Posible_Outcomes_Arrays.UserChoices[0] = "Fox";
                        Posible_Outcomes_Bools.Fox_Was_Taken = true;
                        Loop_Main_Loop();
                    }
                    if (User_Imput_Awnser[i].ToUpper() == "C")
                    {
                        Posible_Outcomes_Arrays.UserChoices[0] = "Cabbage";
                        Posible_Outcomes_Bools.Cabbage_Was_Taken = true;
                        Loop_Main_Loop();
                    }

                } 
            }
        }
        public static void Loop_Main_Loop()
        {
            if(Posible_Outcomes_Bools.Chicken_Was_Taken == true && Posible_Outcomes_Bools.Fox_Was_Taken == false && Posible_Outcomes_Bools.Cabbage_Was_Taken == false)
            {
                Console.Clear();
                Console.WriteLine("You took the chicken across what are you going to take next?");
                Console.WriteLine("A: Fox B: Cabbage");
                var imput = Console.ReadLine();
                for(int x = 0; x < User_Imput_Awnser2.Length; x++)
                {
                    if(imput == User_Imput_Awnser2[x])
                    {
                        if(User_Imput_Awnser2[x].ToUpper() == "A")
                        {
                            Console.WriteLine("How took the fox accross");
                            Posible_Outcomes_Bools.Fox_Was_Taken = true;
                            Posible_Outcomes_Arrays.UserChoices[1] = "Fox";
                        }
                        if (User_Imput_Awnser2[x].ToUpper() == "B")
                        {
                            Console.WriteLine("How took the cabbage accross");
                            Posible_Outcomes_Bools.Cabbage_Was_Taken = true;
                            Posible_Outcomes_Arrays.UserChoices[1] = "Cabbage";
                        }
                    }
                }
            }
            if(Posible_Outcomes_Bools.Fox_Was_Taken == true && Posible_Outcomes_Bools.Chicken_Was_Taken == false && Posible_Outcomes_Bools.Cabbage_Was_Taken == false)
            {
                Console.Clear();
                Console.WriteLine("You took the Fox across what are you going to take next?");
                //already lost
                Console.WriteLine("A: Chicken B: Cabbage");
                var imput = Console.ReadLine();
                for (int x = 0; x < User_Imput_Awnser2.Length; x++)
                {
                    if (imput == User_Imput_Awnser2[x])
                    {
                        if (User_Imput_Awnser2[x].ToUpper() == "A")
                        {
                            Console.WriteLine("You took the Chicken accross");
                            Posible_Outcomes_Bools.Chicken_Was_Taken = true;
                            Posible_Outcomes_Arrays.UserChoices[1] = "Chicken";
                        }
                        if (User_Imput_Awnser2[x].ToUpper() == "B")
                        {
                            Console.WriteLine("You took the cabbage accross");
                            Posible_Outcomes_Bools.Cabbage_Was_Taken = true;
                            Posible_Outcomes_Arrays.UserChoices[1] = "Cabbage";
                        }
                    }
                }
            }
        }
    }
}
