//----------------------------Câu 1----------------------------//
class Animal {
    public string Name { get; set; }
}

class Dog : Animal {
    public string Breed { get; set; }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Task {
    public event Action<string> OnFinished;
    public void CompleteTask(){
        OnFinished?.Invoke("Task is finished!");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Dog dog = new Dog();
            dog.Name = "Baka";
            dog.Breed = "Husky";
            Console.WriteLine("Name: " + dog.Name + "\nBreed: " + dog.Breed);
        }
        else if (lc == 2) {
            Task task = new Task();
            task.OnFinished += message => Console.WriteLine(message);
            task.CompleteTask();
        }
    }
}