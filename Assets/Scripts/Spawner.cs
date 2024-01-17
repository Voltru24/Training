using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 _vectorDirection;

    [SerializeField] private GameObject _enemy;

    [SerializeField] private List<GameObject> _spawnPoints;

    [SerializeField] private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, _repeatRate);
    }

    public void Spawn()
    {
        int index = Random.Range(0, _spawnPoints.Count);

        GameObject enemy = Instantiate(_enemy, _spawnPoints[index].transform);

        enemy.GetComponent<Mover>().SetVectorDirection(_vectorDirection);
    }
}
