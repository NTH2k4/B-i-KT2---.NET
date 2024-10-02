//----------------------------Câu 1----------------------------//
public interface IMoveble {
    public void Move();
}

class Car : IMoveble
{
    public void Move()
    {
        Console.WriteLine("Car is moving...");
    }
}

class Bike : IMoveble
{
    public void Move()
    {
        Console.WriteLine("Bike is moving...");
    }
}

//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int OperationHandler(int x, int y);
class Operation {
    public static int Multiply(int x, int y){
        return x * y;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            IMoveble car = new Car();
            IMoveble bike = new Bike();
            car.Move();
            bike.Move();
        }
        else if (lc == 2) {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            OperationHandler opera = new OperationHandler(Operation.Multiply);
            Console.WriteLine("x * y = " + opera(x, y));
        }
    }
}