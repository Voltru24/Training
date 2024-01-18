using System.Collections.Generic;
using UnityEngine;

public class Rogue : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private List<Transform> _routePoints;
        
    private int _indexRoute = 0;

    private void FixedUpdate()
    {
        if (Vector3.Distance(_routePoints[_indexRoute].position, transform.position) < 1)
        {
            _indexRoute = (_indexRoute + 1) % _routePoints.Count;
        }

        Move();
    }

    private void Move()
    {
        Vector3 direction = (_routePoints[_indexRoute].position - transform.position).normalized;

        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
