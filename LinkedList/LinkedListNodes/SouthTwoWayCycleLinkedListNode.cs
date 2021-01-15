namespace DealerOnMarsRovers.LinkedList.LinkedListNodes
{
    public class SouthTwoWayCycleLinkedListNode : TwoWayCycleLinkedListNode
    {
        public override void Move()
        {
            if(LinkedList.Rover.NorthCoordinate > 0)
                LinkedList.Rover.NorthCoordinate--;
        }
    }
}