using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIState {
	private AIStateAgent agent;
	public AIState(AIStateAgent agent) {
		this.agent = agent;
	}

	public abstract void onEnter();
	public abstract void onExit();
	public abstract void onUpdate();
}