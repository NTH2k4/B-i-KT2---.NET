//----------------------------Câu 1----------------------------//
class Bird {
    public virtual void Fly(){
        Console.WriteLine("Bird is flying");
    }
}

class Eagle : Bird{
    public override void Fly(){
        Console.WriteLine("Eagle is flying");
    }
}

class Penguin : Bird{
    public override void Fly(){
        Console.WriteLine("Penguins can't fly");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate void NotificationHandler();
class Cau2 {
    public void EmailNotification(){
        Console.WriteLine("Sending email notification");
    }
    public void SmsNotification(){
        Console.WriteLine("Sending sms notification");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Lựa chọn: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Bird eagle = new Eagle();
            Bird penguin = new Penguin();
            eagle.Fly();
            penguin.Fly();
        }
        else if (lc == 2) {
            Cau2 c2 = new Cau2();
            NotificationHandler notif = null;
            notif += c2.EmailNotification;
            notif += c2.SmsNotification;
            notif(); // Call all method in delegate
        }
    }
}