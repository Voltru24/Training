using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _vectorDirection;

    [SerializeField] private float _speed;

    public void SetVectorDirection(Vector3 vectorDirection)
    {
        _vectorDirection = vectorDirection;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_vectorDirection * Time.deltaTime * _speed);
    }
}
