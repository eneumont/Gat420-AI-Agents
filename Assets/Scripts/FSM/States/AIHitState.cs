using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHitState : AIState {
	float timer;

	public AIHitState(AIStateAgent agent) : base(agent) {
		AIStateTransition transition = new AIStateTransition(nameof(AIChaseState));
		transition.AddCondition(new FloatCondition(agent.timer, Condition.Predicate.LESS, 0.01f));
		transitions.Add(transition);
	}

	public override void onEnter() {
		agent.movement.Stop();
		agent.movement.Velocity = Vector3.zero;
		agent.animator?.SetTrigger("Hit");
		agent.timer.value = 2;
	}

	public override void onExit() {

	}

	public override void onUpdate() {

	}
}