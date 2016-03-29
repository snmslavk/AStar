[![Build status](https://ci.appveyor.com/api/projects/status/k3278pi94h3000bx?svg=true)](https://ci.appveyor.com/project/snmslavk/astar)
[![NuGet version](https://badge.fury.io/nu/AStar.svg)](https://badge.fury.io/nu/AStar)

# AStar
Library with implementation of AStar algorithm 
# Example




      0  1  2  3  4
    0 __ __ __ N6 __
    1 N3 __ N5 __ __
    2 __ N2 __ N4 __
    3 __ __ N1 __ __
    4 __ __ __ __ __
   
     Begin:N1
     Goal:N6
     Links of Nodes: N3<-N2<-N1->N4->N5->N6
     Result way:N1->N4->N5->N6
     
# How to
To install AStar, run the following command in the Package Manager Console.
```
PM> Install-Package Astar
```

Add Nodes
```C#
Node N1 = G.AddNode(2,3,0);
```
Add Arcs
```C#
G.AddArc(N1,N2,1);
```
Get Result
```C#
AStar AS = new AStar(G);
AS.SearchPath(N1, N6)
foreach (Arc A in AS.PathByArcs)
      Console.WriteLine(A.ToString());
```

