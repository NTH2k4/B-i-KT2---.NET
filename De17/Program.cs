//----------------------------Câu 1----------------------------//
class Engine{
    public void StartEngine(){
        Console.WriteLine("Engine is starting");
    }
}

class Car : Engine{
    private Engine engine = new Engine();
    public void StartEngine(){
        engine.StartEngine();
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class OrderProcessor{
    public event Action<string> OrderProcessed;
    public void ProcessOrder(string name){
        OrderProcessed?.Invoke(name);
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Car c = new Car();
            c.StartEngine();
        }
        else if (lc == 2) {
            OrderProcessor op = new OrderProcessor();
            op.OrderProcessed += name => Console.WriteLine($"Order {name} is processed");
            op.ProcessOrder("Pizza");
        }
    }
}