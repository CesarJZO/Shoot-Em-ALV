using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnTriggerDo : MonoBehaviour
{
    [SerializeField] private UnityEvent OnDie;
    [SerializeField] private UnityEvent OnLimitReached;
    private GameObject collisionee;
    void OnTriggerEnter2D(Collider2D collider)
    {
        collisionee = collider.gameObject;
        OnDie?.Invoke();
        if (collider.tag == "Limit") return;
        OnLimitReached?.Invoke();
    }

    public void DestroyCollisionee()
    {
        if (collisionee == null) return;

        Destroy(collisionee);
    }
}
