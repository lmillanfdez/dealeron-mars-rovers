using DealerOnMarsRovers.LinkedList.LinkedListNodes;

namespace DealerOnMarsRovers.LinkedList
{
    public class TwoWayCycleLinkedList
    {
        private TwoWayCycleLinkedListNode Head { get; set; }
        private TwoWayCycleLinkedListNode Current { get; set; }

        public Rover Rover { get; set; }

        public int NorthBound { get; set; }
        public int EastBound { get; set; }

        public void AddNode(TwoWayCycleLinkedListNode node)
        {
            if(Head != null)
            {
                Head.LeftNode = node;
                node.RightNode = Head;

                Current.RightNode = node;
                node.LeftNode = Current;
            }
            else
            {
                Head = node;
            }

            node.LinkedList = this;
            Current = node;
        }

        public TwoWayCycleLinkedListNode FindNodeByHead(char head)
        {
            if(Head == null)
                return null;

            var result = Head;

            do
            {
                if(result.Head == head)
                    break;

                result = result.RightNode;
            }
            while(result != null && result != Head);

            return result;
        }
    }
}