var myObj = new MyClass();
myObj.Info();

class MyClass
{
    int F1;
    string F2;
    int F3 = 100;
    string F4 = "ASDF";

    public void Info()
    {
        System.Console.WriteLine($"Default integer      F1 = {F1}");  //Implicit fields initialization
        System.Console.WriteLine($"Default string       F2 = {F2}");

        System.Console.WriteLine($"Initialized integer  F3 = {F3}");  //Explicit field initialization
        System.Console.WriteLine($"Initialized string   F4 = {F4}");
    } 
}