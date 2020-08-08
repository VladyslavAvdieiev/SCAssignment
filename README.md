# SCAssignment
### This repo is the assignment for SC

It consist of one solution
- [SCAssignment](https://github.com/VladyslavAvdieiev/SCAssignment/tree/master/SCAssignment);

and two projects
- [Collections](https://github.com/VladyslavAvdieiev/SCAssignment/tree/master/SCAssignment/Collections);
- [Collections.Test](https://github.com/VladyslavAvdieiev/SCAssignment/tree/master/SCAssignment/Collections.Test).

#### Collections
An assembly with main functionality. Consists of
- [SinglyLinkedList](https://github.com/VladyslavAvdieiev/SCAssignment/blob/master/SCAssignment/Collections/SinglyLinkedList.cs) 
(represents linked list with [nodes](https://github.com/VladyslavAvdieiev/SCAssignment/blob/master/SCAssignment/Collections/SinglyLinkedListNode.cs) 
containing string value and pointing only to the next node);
- [DoublyLinkedList](https://github.com/VladyslavAvdieiev/SCAssignment/blob/master/SCAssignment/Collections/DoublyLinkedList.cs) 
(represents linked list with [nodes](https://github.com/VladyslavAvdieiev/SCAssignment/blob/master/SCAssignment/Collections/DoublyLinkedListNode.cs) 
containing string value and pointing to the next and the previous nodes).

Each linked list implements general interface [ILinkedList](https://github.com/VladyslavAvdieiev/SCAssignment/blob/master/SCAssignment/Collections/ILinkedList.cs).
Each node implements general interface [ILinkedListNode](https://github.com/VladyslavAvdieiev/SCAssignment/blob/master/SCAssignment/Collections/ILinkedListNode.cs).

#### Collections.Test
An assembly with tests for main functionality. There are 4 test classes for each functionality class. They test every property and every boundary case.

Tests were written using [xUnit](https://www.nuget.org/packages/xunit/) testing framework.

#### General
The repo has [workflow automation file](https://github.com/VladyslavAvdieiev/SCAssignment/blob/master/.github/workflows/dotnet-core.yml) 
which triggers every time the commit reaches the master branch. In does build, runs tests and publish new version of 
[NuGet package](https://www.nuget.org/packages/SCAssignment.Collections/).
