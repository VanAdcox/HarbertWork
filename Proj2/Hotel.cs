public class Hotel
{
    private Reservation[] rooms;
    private List<String> waitList;

    public Hotel(int numRooms)
    {
        rooms = new Reservation[numRooms];
        waitList = new List<String>();
    }

    public Reservation? RequestRoom(String guestName)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] == null)
            {
                rooms[i] = new Reservation(guestName, i);
                return new Reservation(guestName, i);
            }
        }

        waitList.Add(guestName);

        return null;
    }
    public Reservation? CancelAndReassign(Reservation? res)
    {
        if (res == null)
        {
            return null;
        }
        rooms[res.RoomNumber] = null;
        if (waitList.Count > 0)
        {
            Reservation? newRes = RequestRoom(waitList[0]);
            rooms[res.RoomNumber] = newRes;

            // replace waitlist with a new waitlist without the used name
            //string[] newWaitlist = new string[waitList.Length - 1];
            //Array.Copy(waitList, 1, newWaitlist, 0, newWaitlist.Length);
            //waitList = newWaitlist;

            waitList.RemoveAt(0);

            return newRes;
        }
        return null;
    }

    public void Show()
    {
        Console.WriteLine("Current Hotel Occupancy");
        foreach (Reservation? room in rooms)
        {
            if (room != null)
            {
                Console.WriteLine(room);
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
        Console.WriteLine($"Waiting list: {string.Join(" ", waitList)}\n");
    }
}

