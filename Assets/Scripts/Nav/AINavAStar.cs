using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Priority_Queue;

public class AINavAStar {
    public static bool generate(AINavNode StartNode, AINavNode EndNode, ref List<AINavNode> path) {
        var nodes = new SimplePriorityQueue<AINavNode>();

        StartNode.Cost = 0;
        float heuristic = Vector3.Distance(StartNode.transform.position, EndNode.transform.position);
        nodes.EnqueueWithoutDuplicates(StartNode, StartNode.Cost + heuristic);

        bool found = false;

        while (!found && nodes.Count > 0) {
            var node = nodes.Dequeue();

            if (node == EndNode) { 
                found = true;
                break;
            }

            foreach ( var neighbor in node.neighbors) {
                float cost = node.Cost + Vector3.Distance(node.transform.position, neighbor.transform.position);
                if (cost < neighbor.Cost) {
                    neighbor.Cost = cost;
                    neighbor.Parent = node;
                    heuristic = Vector3.Distance(neighbor.transform.position, EndNode.transform.position);
                    nodes.EnqueueWithoutDuplicates(neighbor, neighbor.Cost + heuristic);
                }
            }
        }

        path.Clear();
        if (found) {
            path.Clear();
            CreatePathFromParents(EndNode, ref path);
        }

        return found;
    }

	public static void CreatePathFromParents(AINavNode node, ref List<AINavNode> path) {
		// while node not null
		while (node != null) {
			// add node to list path
			path.Add(node);
			// set node to node parent
			node = node.Parent;
		}

		// reverse path
		path.Reverse();
	}
}