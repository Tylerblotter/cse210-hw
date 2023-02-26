public class Menu{

    private string _inputStr = "";
    private int _inputInt = 0;

    public Menu(){

    }

    public int getInput(){
        Console.WriteLine("Please select an activity.");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Please enter 1-3 (0 to quit): ");
        _inputStr = Console.ReadLine();
        _inputInt = Int32.Parse(_inputStr);
        return _inputInt;
    }
}