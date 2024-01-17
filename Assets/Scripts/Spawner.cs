using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _transformGoal;

    [SerializeField] private MoverEnemy _enemy;

    [SerializeField] private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, _repeatRate);
    }

    public void Spawn()
    {
        GameObject enemy = Instantiate(_enemy, transform);

        enemy.GetComponent<MoverEnemy>().SetTransformGoal(_transformGoal);
    }
}