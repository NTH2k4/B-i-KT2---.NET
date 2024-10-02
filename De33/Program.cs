//----------------------------Câu 1----------------------------//
class Product {
    public string Name { get; set; }
    public double Price { get; set; }
    public void Display(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Alarm {
    public event Action<string> OnAlarmRang;
    public void RingAlarm(){
        OnAlarmRang?.Invoke("Alarm is ringing...");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Product product = new Product(){
                Name = "Laptop",
                Price = 1000
            };
            product.Display();
        }
        else if (lc == 2) {
            Alarm alarm = new Alarm();
            alarm.OnAlarmRang += message => Console.WriteLine(message);
            alarm.RingAlarm();
        }
    }
}