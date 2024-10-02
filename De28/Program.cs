//----------------------------Câu 1----------------------------//
class Person {
    public object Name { get; set; }
    public object Age { get; set; }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Sensor {
    public event Action<string> OnSensorTriggered;
    public void TriggerSensor(){
        OnSensorTriggered?.Invoke("Sensor is triggered!");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Person person = new Person(){
                Name = "Linh",
                Age = 20
            };
            Console.WriteLine("Name: " + person.Name + "\nAge: " + person.Age);
        }
        else if (lc == 2) {
            Sensor sensor = new Sensor();
            sensor.OnSensorTriggered += message => Console.WriteLine(message);
            sensor.TriggerSensor();
        }
    }
}