using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAutonomousAgent : AIAgent
{
    public AIPerception perception = null;
    void Update() {
        var gameObjects = perception.GetGameObjects();
        
        for (var go in gameObjects) {
            Debug.DrawLine(transform.position, go.transform.position);
        }
    }
}
