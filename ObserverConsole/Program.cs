namespace ObserverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, world!");
            Observer.PublicationBusiness.Author kushalAuthor = new Observer.PublicationBusiness.Author("Kushal Hada", "kus", "9034725985", "kushaldeveloper@gmail.com");
        }
    }
}
