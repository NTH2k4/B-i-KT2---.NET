//----------------------------Câu 1----------------------------//
class Animal{
    internal String Name { get => Name; set => Name = value; }
    internal int Age { get => Age; set => Age = value; }

    internal void DisplayInfo(){
        Console.WriteLine("Name: " + Name + "\nAge: " + Age);
    }
}
class Dog : Animal{
    internal String Breed { get => Breed; set => Breed = value; }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int Operation(int x, int y);
public class Cau2{
    internal int Add(int x, int y){
        return x + y;
    }
}
//-------------------------------------------------------------//
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Dog myDog = new Dog();
            myDog.Name = "Den";
            myDog.Age = 5;
            myDog.Breed = "I don't know";
            myDog.DisplayInfo();
        }
        else if (lc == 2) {
            Cau2 c2 = new Cau2();
            Operation opera = new Operation(c2.Add);
            Console.Write("Nhập x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            int y = int.Parse(Console.ReadLine());
            int result = opera(x, y);
            Console.WriteLine("Đáp án: " + result);
        }
    }
}