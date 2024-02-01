using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttackState : AIState {
	float timer = 0;
	public AIAttackState(AIStateAgent agent) : base(agent) {

	}

	public override void onEnter() {
		agent.animator?.SetTrigger("attack");
		timer = Time.time + 2;
	}

	public override void onExit() {

	}

	public override void onUpdate()	{
		if (Time.time > timer) agent.stateMachine.SetState(nameof(AIIdleState));
	}
}