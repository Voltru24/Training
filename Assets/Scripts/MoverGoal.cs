using System.Collections.Generic;
using UnityEngine;

public class MoverGoal : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private List<Transform> _routePoints;
        
    private int _indexRoute = 0;

    private void FixedUpdate()
    {
        if (Vector3.Distance(_routePoints[_indexRoute].position, transform.position) < 1)
        {
            _indexRoute++;

            if (_indexRoute >= _routePoints.Count)
            {
                _indexRoute = 0;
            }
        }

        Move();
    }

    private void Move()
    {
        Vector3 direction = (_routePoints[_indexRoute].position - transform.position).normalized;

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
