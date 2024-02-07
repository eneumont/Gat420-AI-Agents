using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChaseState : AIState {
	float initialSpeed;
	public AIChaseState(AIStateAgent agent) : base(agent) {
		AIStateTransition transition = new AIStateTransition(nameof(AIAttackState));
		transition.AddCondition(new FloatCondition(agent.enemyDistance, Condition.Predicate.LESS, 1));
		transition.AddCondition(new BoolCondition(agent.enemySeen));
		transitions.Add(transition);

		transition = new AIStateTransition(nameof(AIIdleState));
		transition.AddCondition(new BoolCondition(agent.enemySeen, false));
		transitions.Add(transition);
	}

	public override void onEnter() {
		agent.movement.Resume();
		initialSpeed = agent.movement.maxSpeed;
		agent.movement.maxSpeed *= 2;
	}

	public override void onExit() {
		agent.movement.maxSpeed = initialSpeed;
	}

	public override void onUpdate() {
		if (agent.enemySeen) agent.movement.Destination = agent.enemy.transform.position;
	}
}