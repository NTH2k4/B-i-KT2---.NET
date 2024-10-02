//----------------------------Câu 1----------------------------//
class Car {
    internal string Make {get; set;}
    internal string Model {get; set;}
    public void DisplayInfo(){
        Console.WriteLine($"Make: {Make}\nModel: {Model}");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int MathOperation(int a, int b);
class Math{
    public int Add(int a, int b){
        return a + b;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Car c = new Car();
            c.Make = "Toyota";
            c.Model = "Corolla";
            c.DisplayInfo();
        }
        else if (lc == 2) {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Math m = new Math();
            MathOperation mo = m.Add;
            Console.WriteLine($"a + b = {mo(a, b)}");
        }
    }
}