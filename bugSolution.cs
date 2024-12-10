public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    //Method to create a deep copy
    public MyClass Clone(){
        return new MyClass(this.MyProperty);
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        //MyClass obj2 = obj1; // This line is changed
        MyClass obj2 = obj1.Clone(); // Create a deep copy

        obj2.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); // Output: 10
    }
}