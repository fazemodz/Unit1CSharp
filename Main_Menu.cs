using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit1.StarterProgram.Main_Loop;
namespace Unit1.StarterProgram.Main_Menu_Handler
{
    public class Main_Menu
    {
        //array's of multiple ways that a user can imput yes or no
        public static string[] User_Imput_Yes = {"YES", "Yes", "YEs", "YeS", "yES", "yeS", "Y", "y" };
        public static string[] User_Imput_No = {"NO", "No","nO", "no", "N", "n", "N0","n0"};
        //This is a callback used to know if the main menu was made
        public static bool Main_Menu_Was_Created = false;
        public static void Generate_Main_Menu()
        {
            Console.WriteLine("Can you get these items to the other side?");
            Console.Title = "Can you get these items to the other side?";
            Console.WriteLine("YES    NO");
            string User_Imput = Console.ReadLine();
            for(int i =  0; i < User_Imput_Yes.Length; i++)
            {
                if (User_Imput == User_Imput_Yes[i])
                {
                    Console.Clear();
                    Program_Main_Loop.Init_Main_Loop();
                }else;
            }
            for(int x = 0 ; x < User_Imput_No.Length; x++)
            {
                if(User_Imput == User_Imput_No[x])
                {
                    Environment.Exit(0);
                }else;
            }
            Main_Menu_Was_Created = true;
        }
    }
}
