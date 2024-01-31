using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateAgent : AIAgent {
	[SerializeField] AIPerception enemyPerception;
	AIStateMachine stateMachine = new AIStateMachine();
	void Start() {
		//add states to state machine
		stateMachine.addState(nameof(AIIdleState), new AIIdleState(this));
		stateMachine.addState(nameof(AIDeathState), new AIDeathState(this));
		stateMachine.addState(nameof(AIAttackState), new AIAttackState(this));
		stateMachine.addState(nameof(AIPatrolState), new AIPatrolState(this));

		stateMachine.SetState(nameof(AIIdleState));
	}

	void Update() {
		var enemies = enemyPerception.GetGameObjects();
		if (enemies.Length > 0) { stateMachine.SetState(nameof(AIAttackState)); }
		else { stateMachine.SetState(nameof(AIIdleState)); }

		stateMachine.Update();
	}
}