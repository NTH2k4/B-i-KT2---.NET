//----------------------------Câu 1----------------------------//
interface Instrument{
    void Play();
}

class Guitar : Instrument{
    public void Play(){
        Console.WriteLine("Guitar is playing");
    }
}

class Piano : Instrument{
    public void Play(){
        Console.WriteLine("Piano is playing");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate void NotificationHandler(string value);
class Notification{
    public void EmailNotification(string value){
        Console.WriteLine($"Email: {value}");
    }
    public void SMSNotification(string value){
        Console.WriteLine($"SMS: {value}");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Instrument guitar = new Guitar();
            Instrument piano = new Piano();
            guitar.Play();
            piano.Play();
        }
        else if (lc == 2) {
            Notification n = new Notification();
            NotificationHandler notif = null;
            notif += n.EmailNotification;
            notif += n.SMSNotification;
            notif("Hello");
        }
    }
}