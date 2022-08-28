using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    public interface iBridgeRoomsWithAmenities
    {
        void AssignAmmenityTo(string room);
    }
    public abstract class MapRoomAndAmenities
    {
        public iBridgeRoomsWithAmenities? BridgeRoomsWithAmenities { get; set; }
        public abstract void AssignAmmenity();
    }
    public class OneStarRoom : MapRoomAndAmenities
    {
        public override void AssignAmmenity()
        {
            BridgeRoomsWithAmenities?.AssignAmmenityTo("One star room");
        }
    }
    public class TwoStarRoom : MapRoomAndAmenities
    {
        public override void AssignAmmenity()
        {
            BridgeRoomsWithAmenities?.AssignAmmenityTo("Two star room");
        }
    }
    public class ComplimentryBreakfastAmmentiy : iBridgeRoomsWithAmenities
    {
        public void AssignAmmenityTo(string room) => Console.WriteLine($"BreakfastAmmentiy assigned to {room}");
    }
    public class SwimmingPoolAmmentiy : iBridgeRoomsWithAmenities
    {
        public void AssignAmmenityTo(string room)
        {
            Console.WriteLine($"SwimmingPoolAmmentiy assigned to {room}");
        }
    }
}
