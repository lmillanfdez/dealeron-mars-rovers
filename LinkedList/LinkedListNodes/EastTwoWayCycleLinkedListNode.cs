namespace DealerOnMarsRovers.LinkedList.LinkedListNodes
{
    public class EastTwoWayCycleLinkedListNode : TwoWayCycleLinkedListNode
    {
        public override void Move()
        {
            if(LinkedList.Rover.EastCoordinate < LinkedList.EastBound)
                LinkedList.Rover.EastCoordinate++;
        }
    }
}