using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeLogger : MonoBehaviour
{
    void Awake()
    {
        Debug.Log(this.gameObject, this.gameObject);
    }
}
