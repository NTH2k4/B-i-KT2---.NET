//----------------------------Câu 1----------------------------//
class Engine {
    public void Start() {
        Console.WriteLine("Engine is starting");
    }
}

class Vehicle {
    public Engine engine = new Engine();
}

class Car : Vehicle {
    public void Start() {
        engine.Start();
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class LoginManager {
    public event Action<string> OnLoginSuccess;
    public void Login(){
        OnLoginSuccess?.Invoke("Login success");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Car c = new Car();
            c.Start();
        }
        else if (lc == 2) {
            LoginManager loginManager = new LoginManager();
            loginManager.OnLoginSuccess += value => Console.WriteLine($"{value}");
            loginManager.Login();
        }
    }
}