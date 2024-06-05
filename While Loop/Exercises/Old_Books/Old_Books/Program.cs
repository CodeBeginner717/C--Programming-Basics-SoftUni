class Old_Books
{
    static void Main(string[] args)
    {
        string favBook = Console.ReadLine();
        int counter = 0;
        bool isBookFound = false;
        string nextBookName = "";

        while (nextBookName != "No More Books")
        {
            nextBookName = Console.ReadLine();

            if (nextBookName == favBook)
            {
                isBookFound = true;
                break;
            }

            if (nextBookName != "No More Books")
            {
                counter++;
            }
        }

        if (isBookFound == true)
        {
            Console.WriteLine($"You checked {counter} books and found it.");
        }
        else
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
        }
    }
}