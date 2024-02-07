using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrolState : AIState {
	Vector3 destination;
	public AIPatrolState(AIStateAgent agent) : base(agent) {
		AIStateTransition transition = new AIStateTransition(nameof(AIIdleState));
		transition.AddCondition(new FloatCondition(agent.destinationDistance, Condition.Predicate.LESS, 1));
		transitions.Add(transition);

		transition = new AIStateTransition(nameof(AIChaseState));
		transition.AddCondition(new BoolCondition(agent.enemySeen));
		transitions.Add(transition);
	}

	public override void onEnter() {
		agent.movement.Resume();
		var navnode = AINavNode.GetRandomAINavNode();
		destination = navnode.transform.position;
	}

	public override void onExit() {

	}

	public override void onUpdate() {
		agent.movement.MoveTowards(destination);
	}
}