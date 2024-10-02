//----------------------------Câu 1----------------------------//
class Animal {
    public virtual void MakeSound(){
        Console.WriteLine("Animal sound...");
    }
}

class Dog : Animal {
    public override void MakeSound(){
        Console.WriteLine("Woof woof...");
    }
}

class Cat : Animal {
    public override void MakeSound()
    {
        Console.WriteLine("Meow meow...");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Cau2 {
    public event EventHandler<string> OnDataReceived;
    public void GetData(){
        Console.Write("Nhập dữ liệu: ");
        string data = Console.ReadLine();
        OnDataReceived?.Invoke(this, data);
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.MakeSound();
            cat.MakeSound();
        }
        else if (lc == 2) {
            Cau2 c2 = new Cau2();
            c2.OnDataReceived += (sender, e) => {
                Console.WriteLine("Đã nhận dữ liệu: " + e);
            };
            c2.GetData();
        }
    }
}