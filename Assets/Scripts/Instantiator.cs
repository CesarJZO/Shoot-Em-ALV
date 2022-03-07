using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField] GameObject _object;
    public void InstantiateObject()
    {
        Instantiate(_object, transform.position, Quaternion.identity);
    }
}
