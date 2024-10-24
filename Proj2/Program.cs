class Program
{
    public static void Main(String[] args)
    {
        Hotel hotel = new Hotel(4);

        Console.WriteLine("Filling 4 room hotel with 6 guests | Test waitlist");

        Reservation? g1 = hotel.RequestRoom("g1");
        Reservation? g2 = hotel.RequestRoom("g2");
        Reservation? g3 = hotel.RequestRoom("g3");
        Reservation? g4 = hotel.RequestRoom("g4");
        Reservation? g5 = hotel.RequestRoom("g5");
        Reservation? g6 = hotel.RequestRoom("g6");

        hotel.Show();

        Console.WriteLine("Removing g3");
        hotel.CancelAndReassign(g3);
        hotel.Show();

        Console.WriteLine("Removing g1,g2,g5 | Test backfilling from waitlist & canceling rooms & empty waitlist");
        hotel.CancelAndReassign(g1);
        hotel.CancelAndReassign(g2);
        hotel.CancelAndReassign(g5);
        hotel.Show();

        Console.WriteLine("Test removing non existant guest (remove g99)");
        Reservation? g99 = hotel.RequestRoom("g99");
        Console.WriteLine($"Output:{hotel.CancelAndReassign(g99)}");

        hotel.Show();
    }
}


