using UnityEngine;
using System.Collections.Generic;

public class Node {

	public List<Node> adjacent = new List<Node>();      //List of the node
	public Node previous = null;						//The previous node
	public string label = ""; 							//names for each node

	public void Clear()
	{
		previous = null;
	}
}
