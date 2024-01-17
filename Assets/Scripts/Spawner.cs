using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _transformGoal;

    [SerializeField] private Enemy _enemy;

    [SerializeField] private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, _repeatRate);
    }

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemy, transform);

        enemy.SetTransformGoal(_transformGoal);
    }
}