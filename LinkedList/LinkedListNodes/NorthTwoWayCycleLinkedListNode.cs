namespace DealerOnMarsRovers.LinkedList.LinkedListNodes
{
    public class NorthTwoWayCycleLinkedListNode : TwoWayCycleLinkedListNode
    {
        public override void Move()
        {
            if(LinkedList.Rover.NorthCoordinate < LinkedList.NorthBound)
                LinkedList.Rover.NorthCoordinate++;
        }
    }
}