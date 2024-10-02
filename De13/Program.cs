//----------------------------Câu 1----------------------------//
class Person {
    string name;
    public Person(string name){
        this.name = name;
    }
}

class Student : Person{
    public Student(string name) : base(name){}
}

class Teacher : Person{
    public Teacher(string name) : base(name){}
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate T MathOperation<T>(T a, T b);
class Cau2 {
    public int Substract(int a, int b){
        return a - b;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Person student = new Student("Nguyễn Trung Hiếu");
            Person teacher = new Teacher("Linh");
        }
        else if (lc == 2) {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            MathOperation<int> substract = new MathOperation<int>(new Cau2().Substract);
            Console.WriteLine("a - b = " + substract(a, b));
        }
    }
}