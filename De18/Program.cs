//----------------------------Câu 1----------------------------//
interface IDrive {
    void Drive();
}

class Car : IDrive {
    public void Drive() {
        Console.WriteLine("Car is driving");
    }
}

class Truck : IDrive {
    public void Drive() {
        Console.WriteLine("Truck is driving");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Button {
    public event Action<string> OnButtonClick;
    public void Click() {
        OnButtonClick?.Invoke("Enter");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            IDrive c = new Car();
            IDrive t = new Truck();
            c.Drive();
            t.Drive();
        }
        else if (lc == 2) {
            Button btn = new Button();
            btn.OnButtonClick += name => Console.WriteLine($"Button {name} is clicked");
            btn.Click();
        }
    }
}