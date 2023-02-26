using System;

class Program
{
    static void Main(string[] args)
    {

        bool run = true;
        while (run == true){

            Menu myMenu = new Menu();
            int userInput = myMenu.getInput();

            if (userInput == 0)
            {
                run = false;
            }
            else if (userInput == 1)
            {
                // Activity act = new Activity();
                // act.InputSeconds();
                // act.DisplaySpinner(4);
                // act.DisplayCountdown(4);
                
                Breathing bre = new Breathing();
                bre.InputSeconds();
                bre.setStartMessage("Welcome to the Breathing Activity. Get ready to breath in and out.");
                bre.DisplayStartMessage();
                bre.BreathingActivity();
                bre.DisplayEndMessage();
            }
            else if (userInput == 2)
            {
                Reflection refl = new Reflection();
                refl.InputSeconds();
                refl.setStartMessage("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                refl.DisplayStartMessage();
                refl.ReflectionActivity();
                refl.DisplayEndMessage();
            }
            else if (userInput == 3)
            {
                Listing lis = new Listing();
                lis.InputSeconds();
                lis.setStartMessage("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                lis.DisplayStartMessage();
                lis.ListingActivity();
                lis.DisplayEndMessage();
            }

        }
    }
}