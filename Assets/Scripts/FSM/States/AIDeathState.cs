using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDeathState : AIState {
	float timer = 0;
	public AIDeathState(AIStateAgent agent) : base(agent) {

	}

	public override void onEnter() {
		agent.movement.Stop();
		agent.movement.Velocity = Vector3.zero;
		agent.animator?.SetTrigger("death");
		timer = Time.time + 5;
	}

	public override void onExit() {

	}

	public override void onUpdate() {
		if (Time.time > timer) GameObject.Destroy(agent.gameObject);
	}
}