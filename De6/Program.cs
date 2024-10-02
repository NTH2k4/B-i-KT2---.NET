//----------------------------Câu 1----------------------------//
abstract class Appliance {
    public abstract void TurnOn();
    public abstract void TurnOff();
}

class WashingMachine : Appliance{
    public override void TurnOn()
    {
        Console.WriteLine("Washing machine is turn on!");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Washing machine is turn off!");
    }
}

class Refrigerator : Appliance {
    public override void TurnOn()
    {
        Console.WriteLine("Refrigerator is turn on!");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Refrigerator is turn off!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T MathOperation<T>(T a, T b);
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Appliance wm = new WashingMachine();
            Appliance re = new Refrigerator();
            wm.TurnOn();
            wm.TurnOff();
            re.TurnOn();
            re.TurnOff();
        }
        else if (lc == 2) {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            // Anonymous Method - Cần phải định nghĩa rõ ràng
            MathOperation<double> divide = delegate(double a, double b) {
                return a / b;
            };
            // Lambda Expression - Ngắn gọn hơn hàm vô danh
            MathOperation<int> multiply = (a, b) => a * b;

            Console.WriteLine("a / b = " + divide(a, b));
            Console.WriteLine("a * b = " + multiply(a, b));
        }
    }
}