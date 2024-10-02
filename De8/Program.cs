//----------------------------Câu 1----------------------------//
using System.ComponentModel.DataAnnotations;

abstract class Vehicle {
    public abstract void Start();
    public abstract void Stop();
}

class Car : Vehicle {
    public override void Start()
    {
        Console.WriteLine("Car is start!");
    }
    public override void Stop()
    {
        Console.WriteLine("Car is stop!");
    }
}

class Motorbike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorbike is start!");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorbike is stop!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T CompareHandler<T>(T a, T b);
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Vehicle car = new Car();
            Vehicle motorbike = new Motorbike();
            car.Start();
            car.Stop();
            motorbike.Start();
            motorbike.Stop();
        }   
        else if (lc == 2) {
            Console.Write("String a: ");
            string a = Console.ReadLine();
            Console.Write("String b: ");
            string b = Console.ReadLine();
            CompareHandler<string> compare = (a, b) => {
                if (String.Compare(a, b) > 0) {
                    return "a greater than b!";
                } else if (String.Compare(a, b) < 0) {
                    return "a less than b!";
                } else {
                    return "a equal to b!";
                }
            };
            /* 
            lambda Expression là phương thức vô danh với cú pháp ngắn gọn
            và chỉ dùng 1 lần, dữ liệu đầu vào sẽ tự định nghĩa theo ngữ cảnh.
            */
            Console.WriteLine("Result: " + compare(a, b));
        }
    }
}