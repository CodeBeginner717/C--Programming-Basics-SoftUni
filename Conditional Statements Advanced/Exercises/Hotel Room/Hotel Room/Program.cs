class Hotel_Room
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int numberOfNights = int.Parse(Console.ReadLine());

        double Studio = 0.0;
        double Apartment = 0.0;

        switch (month)
        {
            case "May":
            case "October":
                Studio = numberOfNights * 50;
                Apartment = numberOfNights * 65;

                if (numberOfNights > 14)
                {
                    Apartment = Apartment - (Apartment * 0.10);
                }

                if (numberOfNights > 7 && numberOfNights <= 14)
                {
                    Studio = Studio - (Studio * 0.05);
                }
                else if (numberOfNights > 14)
                {
                    Studio = Studio - (Studio * 0.30);
                }
                break;

            case "June":
            case "September":
                Studio = numberOfNights * 75.20;
                Apartment = numberOfNights * 68.70;

                if (numberOfNights > 14)
                {
                    Apartment = Apartment - (Apartment * 0.10);
                }

                if (numberOfNights > 14)
                {
                    Studio = Studio - (Studio * 0.20);
                }
                break;

            case "July":
            case "August":
                Studio = numberOfNights * 76;
                Apartment = numberOfNights * 77;

                if (numberOfNights > 14)
                {
                    Apartment = Apartment - (Apartment * 0.10);
                }

                break;
        }
        Console.WriteLine($"Apartment: {Apartment:F2} lv.");
        Console.WriteLine($"Studio: {Studio:F2} lv.");
    }
}