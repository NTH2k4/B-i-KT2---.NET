//----------------------------Câu 1----------------------------//
abstract class BaseClass {
    public abstract void Display();
}

class DerivedClass : BaseClass {
    public override void Display(){
        Console.WriteLine("DerivedClass");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Process {
    public event Action<string> ProcessCompleted;
    public void CompleteProcess(string val){
        Console.WriteLine("Process Started!");
        ProcessCompleted?.Invoke(val);
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            BaseClass devired = new DerivedClass();
            devired.Display();
        }
        else if (lc == 2) {
            Process process = new Process();
            process.ProcessCompleted += message => Console.WriteLine("Process Completed: " + message);
            process.CompleteProcess("Hello World!");
        }
    }
}