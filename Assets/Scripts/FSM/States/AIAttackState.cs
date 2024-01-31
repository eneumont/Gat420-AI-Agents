using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttackState : AIState {
	public AIAttackState(AIStateAgent agent) : base(agent) {

	}

	public override void onEnter() {

	}

	public override void onExit() {

	}

	public override void onUpdate()	{
		Debug.Log("attack update");
	}
}