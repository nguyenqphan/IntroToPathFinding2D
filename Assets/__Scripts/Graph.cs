using UnityEngine;
using System.Collections;

public class Graph {

	public int rows = 0;
	public int cols = 0;
	public Node[] nodes;

	//Graph constructor
	public Graph(int[,] grid)
	{
		rows = grid.GetLength (0);
		cols = grid.GetLength (1);	
		//Debug.Log(rows + " rows");
		//Debug.Log (cols + " cols");

		nodes = new Node[grid.Length];

		//Loop through the nodes and name them as its index.
		for(int i = 0; i < nodes.Length; i++)
		{
			Node node = new Node();
			node.label = i.ToString();
			nodes[i] = node;	
		}

		//Loop to create grids
		for(int r = 0; r < rows; r++)
		{
			for(int c = 0; c < cols; c++)
			{
				Node node = nodes[cols * r + c];       //formula create indexes from 0 to last node of the grid

				//0 for open tile, 1 for solid tile. 
				if(grid[r,c] == 1)
				{
					continue;
				}


				//Conditions to find all adjacent nodes to a given nodes
				//Up
				if(r > 0)
				{
					node.adjacent.Add(nodes[cols * (r - 1) + c]);
				}

				//Right
				if(c < cols - 1)
				{
					node.adjacent.Add(nodes[cols * r + c + 1]);
				}

				//Down
				if(r < rows -1)
				{
					node.adjacent.Add(nodes[cols * (r + 1) + c)]);
				}

				//Left
				if(c > 0)
				{
					node.adjacent.Add(nodes[cols * r + c - 1]);
				}
			}

		}
	}

}
