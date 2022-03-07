using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CollisionDetector : MonoBehaviour
{
    public UnityEvent OnCollision;
    void OnCollisionEnter2D(Collision2D col)
    {
        OnCollision?.Invoke();
    }
}
