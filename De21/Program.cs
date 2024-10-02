//----------------------------Câu 1----------------------------//
interface IMovable {
    public void Move();
}

interface IFlyable : IMovable {
    public void Fly();
}

class Helicopter : IFlyable {
    public void Move() {
        Console.WriteLine("Helicopter is moving");
    }

    public void Fly() {
        Console.WriteLine("Helicopter is flying");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Messenger {
    public event Action<string> OnMessageReceived;
    public void ReceivedMessge() {
        OnMessageReceived?.Invoke("You have a new message");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Helicopter helicopter = new Helicopter();
            helicopter.Move();
            helicopter.Fly();
        }
        else if (lc == 2) {
            Messenger messenger = new Messenger();
            messenger.OnMessageReceived += message => Console.WriteLine($"{message}");
            messenger.ReceivedMessge();
        }
    }
}