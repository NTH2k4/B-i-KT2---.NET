//----------------------------Câu 1----------------------------//
class Person {
    internal string Name { get; set; }
    internal int Age { get; set; }
    public Person(){}

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int MathOperation (int a, int b);
class Cau2{
    public static int Divide(int a, int b){
        return a / b;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Person p1 = new Person();
            Person p2 = new Person("Nguyễn Trung Hiếu", 20);
            Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");
            Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}");
        }
        else if (lc == 2) {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            MathOperation opera = new MathOperation(Cau2.Divide);
            Console.WriteLine("a / b = " + opera(a, b));
        }
    }
}