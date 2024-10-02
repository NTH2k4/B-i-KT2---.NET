//----------------------------Câu 1----------------------------//
class Book {
    public string Title;
    public string Author;
    public Book(string title, string author){
        Title = title;
        Author = author;
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class DataProccessor {
    public event Action<string> OnDataProcessed;
    public void ProcessData(){
        OnDataProcessed?.Invoke("Data is processed...");
    }
}
//-------------------------------------------------------------//
class Program{
    static void Main(string[] args){
        Console.Write("Choose: ");
        int lc = int.Parse(Console.ReadLine());
        if (lc == 1){
            Book book = new Book("Sword Art Online", "Reki Kawahara");
            Console.WriteLine("Title: " + book.Title + "\nAuthor: " + book.Author);
        }
        else if (lc == 2) {
            DataProccessor dataProccessor = new DataProccessor();
            dataProccessor.OnDataProcessed += message => Console.WriteLine(message);
            dataProccessor.ProcessData();
        }
    }
}