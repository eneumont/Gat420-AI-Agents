using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPerception : MonoBehaviour
{
    [SerializeField] protected string TagName = "";

    public abstract GameObject[] GameObjects();
}
