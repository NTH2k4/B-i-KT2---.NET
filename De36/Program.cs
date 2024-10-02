//----------------------------Câu 1----------------------------//
interface IPlayable {
    void Play();
}

class Game : IPlayable {
    public void Play(){
        Console.WriteLine("Playing game...");
    }
}

class Music : IPlayable {
    public void Play(){
        Console.WriteLine("Playing music...");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Phone {
    public event Action<string> OnCallReceived;
    public void ReceiveCall(){
        OnCallReceived?.Invoke("Call is received...");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            IPlayable game = new Game();
            game.Play();
            IPlayable music = new Music();
            music.Play();
        }
        else if (lc == 2) {
            Phone phone = new Phone();
            phone.OnCallReceived += message => Console.WriteLine(message);
            phone.ReceiveCall();
        }
    }
}