//----------------------------Câu 1----------------------------//
class Person {
    private string Name;
    private int Age;
    public Person(string name){
        Name = name;
    }
    public Person (string name, int age) : this(name){
        Age = age;
    }
    public void Display(){
        Console.WriteLine($"Name: {Name}\nAge: {Age}");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Game {
    public event Action<string> OnGameOver;
    public void EndGame(){
        OnGameOver?.Invoke("Game Over!");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Person person1 = new Person("Linh");
            Person person2 = new Person("Hiếu", 20);
            person1.Display();
            person2.Display();
        }
        else if (lc == 2) {
            Game g = new Game();
            g.OnGameOver += message => Console.WriteLine($"{message}");
            g.EndGame();
        }
    }
}