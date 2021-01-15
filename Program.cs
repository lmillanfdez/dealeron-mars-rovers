using System;
using System.Collections.Generic;
using System.IO;

using DealerOnMarsRovers.LinkedList;
using DealerOnMarsRovers.LinkedList.LinkedListNodes;
using DealerOnMarsRovers.Utils;

namespace DealerOnMarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var streamReader = new StreamReader(@args[0]))
            {
                var gridBoundsInput = streamReader.ReadLine();
                var gridBounds = gridBoundsInput.Split(" ");
                var eastLimit = Convert.ToInt32(gridBounds[0]);
                var northLimit = Convert.ToInt32(gridBounds[1]);

                var outputs = new List<string>();
                var rover = new Rover();

                var linkedList = BuildLinkedList(rover, eastLimit, northLimit);

                string positionInput = "";

                while((positionInput = streamReader.ReadLine()) != null)
                {
                    var commandsInput = streamReader.ReadLine();

                    var position = positionInput.Split(" ");
                    var eastPosition = Convert.ToInt32(position[0]);
                    var northPosition = Convert.ToInt32(position[1]);
                    var headPosition = position[2];

                    rover.EastCoordinate = eastPosition;
                    rover.NorthCoordinate = northPosition;
                    rover.Head = headPosition;

                    var currentLinkedListNode = linkedList.FindNodeByHead(Convert.ToChar(headPosition));

                    foreach(var letter in commandsInput)
                    {
                        if(letter == Constants.MOVE_FOWARD)
                        {
                            currentLinkedListNode.Move();
                        }
                        else
                        {
                            currentLinkedListNode = currentLinkedListNode.Turn(letter);
                            rover.Head = currentLinkedListNode.Head.ToString();
                        }
                    }

                    outputs.Add(rover.Position);
                }

                Console.WriteLine(String.Join('\n', outputs));
            }

            Console.ReadLine();
        }

        static TwoWayCycleLinkedList BuildLinkedList(Rover rover, int eastLimit, int northLimit)
        {
            var northLinkedListNode = new NorthTwoWayCycleLinkedListNode(){ Head = 'N' };
            var eastLinkedListNode = new EastTwoWayCycleLinkedListNode(){ Head = 'E' };
            var southLinkedListNode = new SouthTwoWayCycleLinkedListNode(){ Head = 'S' };
            var westLinkedListNode = new WestTwoWayCycleLinkedListNode(){ Head = 'W' };

            var linkedList = new TwoWayCycleLinkedList()
            {
                Rover = rover,
                EastBound = eastLimit,
                NorthBound = northLimit
            };

            linkedList.AddNode(northLinkedListNode);
            linkedList.AddNode(eastLinkedListNode);
            linkedList.AddNode(southLinkedListNode);
            linkedList.AddNode(westLinkedListNode);

            return linkedList;
        }
    }
}
