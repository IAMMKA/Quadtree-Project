<b> Describtion </b>

Proceed "recursive" until the bottom ("Leaf") node is found to contain the object to be added (i.e. its square area will be within the boundaries of the quadtree node),
Then an object is added to the relevant node,
If the number of objects in the node to which the object is added is within the allowed limits, the process is completed,
If the number of objects in the node to which the object is added exceeds the allowable limit, the relevant node is again divided into four and the objects are distributed to these nodes.

<b>Design Patterns</b>

Composite Singelton Builder


<b>Conclusion</b>

We try to minimize the work done as performance and search results by limiting the work to be done to the nodes.




<b>Contributing</b>

https://github.com/popcron/gizmos
