using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateMachine {
	private Dictionary<string, AIState> states = new Dictionary<string, AIState>();
	public AIState currentState { get; private set; } = null;
	public void Update() { 
		currentState?.onUpdate();
	}

	public void addState(string name, AIState state) {
		Debug.Assert(!states.ContainsKey(name), "State Machine already contains state " + name);
		states[name] = state;
	}

	public void SetState(string name) {
		Debug.Assert(states.ContainsKey(name), "State Machine does not contain state " + name);

		AIState state = states[name];
		if (state == currentState) return;

		currentState?.onExit();
		currentState = state;
		currentState?.onEnter();
	}
}