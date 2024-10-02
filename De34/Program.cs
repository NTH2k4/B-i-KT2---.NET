//----------------------------Câu 1----------------------------//
class Calculator {
    public int Add(int a, int b){
        return a + b;
    }
    public double Add(double a, double b){
        return a + b;
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class GameLevel {
    public event Action<string> OnLevelCompleted;
    public void CompleteLevel(){
        OnLevelCompleted?.Invoke("Level is completed...");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Calculator calculator = new Calculator();
            Console.WriteLine("5 + 6 = " + calculator.Add(5, 6));
            Console.WriteLine("5.5 + 6.6 = " + calculator.Add(5.5, 6.6));
        }
        else if (lc == 2) {
            GameLevel gameLevel = new GameLevel();
            gameLevel.OnLevelCompleted += message => Console.WriteLine(message);
            gameLevel.CompleteLevel();
        }
    }
}