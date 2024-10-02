//----------------------------Câu 1----------------------------//
class Shape {
    public virtual void Draw(){
        Console.WriteLine("Drawing...");
    }
}

class Circle : Shape {
    public override void Draw(){
        Console.WriteLine("Drawing circle...");
    }
}

class Square : Shape {
    public override void Draw(){
        Console.WriteLine("Drawing square...");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Process {
    public event Action<string> OnProcessCompleted;
    public void FinishProcess(){
        OnProcessCompleted?.Invoke("Process is completed!");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Circle circle = new Circle();
            Square square = new Square();
            circle.Draw();
            square.Draw();
        }
        else if (lc == 2) {
            Process process = new Process();
            process.OnProcessCompleted += message => Console.WriteLine(message);
            process.FinishProcess();
        }
    }
}