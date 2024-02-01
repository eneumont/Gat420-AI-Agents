using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdleState : AIState {
	float timer;
	public AIIdleState(AIStateAgent agent) : base(agent) {

	}

	public override void onEnter() {
		timer = Time.time + Random.Range(1, 2);

	}

	public override void onExit() {

	}

	public override void onUpdate() {
		if (Time.time > timer) agent.stateMachine.SetState(nameof(AIPatrolState));

		var enemies = agent.enemyPerception.GetGameObjects();
		if (enemies.Length > 0) { agent.stateMachine.SetState(nameof(AIAttackState)); }
		Debug.Log("idle update");
	}
}