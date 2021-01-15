namespace DealerOnMarsRovers.LinkedList.LinkedListNodes
{
    public class WestTwoWayCycleLinkedListNode : TwoWayCycleLinkedListNode
    {
        public override void Move()
        {
            if(LinkedList.Rover.EastCoordinate > 0)
                LinkedList.Rover.EastCoordinate--;
        }
    }
}