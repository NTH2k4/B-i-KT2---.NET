//----------------------------Câu 1----------------------------//
class Laptop {
    public string Brand;
    public float Price;
    public void ShowInfo(){
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Price: " + Price + "$");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T MathOperation<T>(T a, T b);
class Calculator {
    public int Multiply(int a, int b){
        return a * b;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Laptop acer = new Laptop(){
                Brand = "Acer",
                Price = 2500
            };
            acer.ShowInfo();
        }
        else if (lc == 2) {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Calculator calculator = new Calculator();
            MathOperation<int> cal = calculator.Multiply;
            Console.WriteLine("a * b = " + cal(a, b));
        }
    }
}