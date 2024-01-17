using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedSpin;

    private void FixedUpdate()
    {
        Spin();
    }

    private void Spin()
    {
        transform.Rotate(0, 1 * _speedSpin, 0);
    }
}
