//----------------------------Câu 1----------------------------//
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Employee {
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public string Name { get; set; }
    public string Position { get; set; }
    
}

class Manager : Employee {
    public Manager(string name, string position, string department) : base(name, position)
    {
        Department = department;
    }

    public string Department { get; set; }
}

class Developer : Employee {
    public Developer(string name, string position, string programmingLanguage) : base(name, position)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public string ProgrammingLanguage { get; set; }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int CalculationHandler(int x, int y);

class Calculation {
    public static event CalculationHandler OnCalculationComplete;
    public int Multiply(int x, int y){
        OnCalculationComplete?.Invoke(x, y);
        return x * y;
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Employee manager = new Manager("Linh", "Quản lý", "A10");
            Employee developer = new Developer("Hiếu", "Lập trình viên", "A11");
            Console.WriteLine("Manager:");
            Console.WriteLine("Name: " + manager.Name);
            Console.WriteLine("Position: " + manager.Position);
            Console.WriteLine("Department: " + ((Manager)manager).Department);

            Console.WriteLine("Developer:");
            Console.WriteLine("Name: " + developer.Name);
            Console.WriteLine("Position: " + developer.Position);
            Console.WriteLine("Programming Language: " + ((Developer)developer).ProgrammingLanguage);
        }
        else if (lc == 2) {
            Calculation cal = new Calculation();
            CalculationHandler calhand = new CalculationHandler(cal.Multiply);
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Calculation.OnCalculationComplete += (a, b) => {
                Console.WriteLine("Đã tính xong!");
                return a * b;
            };
            int result = calhand.Invoke(a, b);
            Console.WriteLine("Kết quả phép nhân: " + result);
        }
    }
}