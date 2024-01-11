using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIKinematicMovement : AIMovement {
	public override void ApplyForce(Vector3 force) {
		Acceleration += force;
	}

	public override void MoveTowards(Vector3 target) {
		Vector3 direction = (target - transform.position).normalized;
		ApplyForce(direction * maxForce);
	}

	public override void Stop() {
		Velocity = Vector3.zero;
	}

	public override void Resume() {
		throw new System.NotImplementedException();
	}
}
