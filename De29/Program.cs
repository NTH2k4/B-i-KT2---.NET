//----------------------------Câu 1----------------------------//
class Student {
    private string Name;
    public Student(string name){
        Name = name;
    }
    public string GetName(){
        return Name;
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int Operation(int a, int b);
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
            Student student = new Student("Linh");
            Console.WriteLine("Name: " + student.GetName());
        }
        else if (lc == 2) {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Calculator calculator = new Calculator();
            Operation operation = calculator.Multiply;
            Console.WriteLine("a * b = " + operation(a, b));
        }
    }
}