using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 VectorDirection { private get; set; }

    [SerializeField] private int _speed;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(VectorDirection * Time.deltaTime * _speed);
    }
}
