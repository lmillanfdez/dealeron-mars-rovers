using DealerOnMarsRovers.Utils;

namespace DealerOnMarsRovers.LinkedList.LinkedListNodes
{
    public abstract class TwoWayCycleLinkedListNode
    {
        public char Head { get; set; }
        public TwoWayCycleLinkedListNode LeftNode { get; set; }
        public TwoWayCycleLinkedListNode RightNode { get; set; }

        public TwoWayCycleLinkedList LinkedList { get; set; }

        public TwoWayCycleLinkedListNode Turn(char action)
        {
            return action == Constants.TURN_LEFT ? LeftNode : RightNode;
        }

        public abstract void Move();
    }
}