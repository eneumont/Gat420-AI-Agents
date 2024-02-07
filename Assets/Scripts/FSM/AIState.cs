using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIState {
	protected AIStateAgent agent;
	public AIState(AIStateAgent agent) {
		this.agent = agent;
	}
	public List<AIStateTransition> transitions { get; set; } = new List<AIStateTransition>();

	public string name { get { return GetType().Name; } }
	public abstract void onEnter();
	public abstract void onExit();
	public abstract void onUpdate();
}