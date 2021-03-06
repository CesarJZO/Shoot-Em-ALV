using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    public List<GameObject> asteroids;
    [SerializeField] float _waitingTime = 1;
    [SerializeField] GameObject _asteroid;
    [SerializeField] Boundary _boundary;

    Vector3 _generationPoint;
    WaitForSeconds waitForSeconds;

    private void Awake()
    {
        asteroids = new List<GameObject>();
        _generationPoint = new Vector3(0, _boundary.MaxY, 0);
        waitForSeconds = new WaitForSeconds(_waitingTime);
    }
    private void Start()
    {
        StartCoroutine(GenerateAsteroid());
    }
    IEnumerator GenerateAsteroid()
    {
        _generationPoint.x = Random.Range(_boundary.MinX, _boundary.MaxX);
        asteroids.Add(Instantiate(_asteroid, _generationPoint, Quaternion.identity));
        yield return waitForSeconds;
        StartCoroutine(GenerateAsteroid());
    }
}
