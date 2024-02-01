using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrolState : AIState {
	Vector3 destination;
	public AIPatrolState(AIStateAgent agent) : base(agent) {

	}

	public override void onEnter() {
		var navnode = AINavNode.GetRandomAINavNode();
		destination = navnode.transform.position;
	}

	public override void onExit() {

	}

	public override void onUpdate() {
		agent.movement.MoveTowards(destination);
	}
}