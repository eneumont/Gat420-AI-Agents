using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AIDistancePerception : AIPerception
{
    public override GameObject[] GameObjects() { 
        List<GameObject> result = new List<GameObject>();

        Collider[] colliders = Physics.OverlapSphere(transform.position, distance);
        foreach () {
            if () continue;

            if () {
                float angle = Vector3.Angle(transform.forward, direction);
                if (angle <= maxAngle) {
                    result.Add(collider.gameObject);
                }
            }
        }
    }
}
