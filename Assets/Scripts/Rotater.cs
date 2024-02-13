using UnityEngine;
using DG.Tweening;

public class Rotater : MonoBehaviour
{
    [SerializeField] private Vector3 _endValueRotate;
    [SerializeField] private float _durationRotate;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DOLocalRotate(_endValueRotate, _durationRotate);
    }
}
