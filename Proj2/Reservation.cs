
public class Reservation
{
    private String guestName;
    public String GuestName { get { return guestName; } }

    private int roomNumber;
    public int RoomNumber { get { return roomNumber; } }

    public Reservation(String guestName, int roomNumber)
    {
        this.guestName = guestName;
        this.roomNumber = roomNumber;
    }

    public override string ToString()
    {
        return ($"Guest: {guestName}, Roomnumber: {roomNumber}");
    }
}
