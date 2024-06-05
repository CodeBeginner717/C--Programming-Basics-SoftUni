class Building
{
    static void Main(string[] args)
    {
        int floors = int.Parse(Console.ReadLine());
        int roomsPerFloor = int.Parse(Console.ReadLine());

        for (int floor = floors; floor >= 1; floor--)
        {
            for (int room = 0; room < roomsPerFloor; room++)
            {
                if (floor == floors)
                {
                    Console.Write("L");
                }
                else if (floor % 2 == 0)
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write("A");
                }

                Console.Write(floor);
                Console.Write(room);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
