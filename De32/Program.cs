//----------------------------Câu 1----------------------------//
interface IDrivealbe {
    void Drive();
}

class Car : IDrivealbe {
    public void Drive() {
        Console.WriteLine("Car is driving...");
    }
}

class Bike : IDrivealbe {
    public void Drive() {
        Console.WriteLine("Bike is driving...");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T MathOperation<T>(T a, T b);
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            IDrivealbe car = new Car();
            IDrivealbe bike = new Bike();
            car.Drive();
            bike.Drive();
        }
        else if (lc == 2) {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            MathOperation<int> add = (a, b) => a + b;
            Console.WriteLine("a + b = " + add(a, b));
        }
    }
}