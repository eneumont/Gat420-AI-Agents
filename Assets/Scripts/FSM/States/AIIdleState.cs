using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdleState : AIState {
	public AIIdleState(AIStateAgent agent) : base(agent) {

	}

	public override void onEnter() {
		Debug.Log("idle enter");
	}

	public override void onExit() {
		Debug.Log("idle exit");
	}

	public override void onUpdate() {
		Debug.Log("idle update");
	}
}