using UnityEngine;
using DG.Tweening;

public class CubeRotate : MonoBehaviour
{
    [SerializeField] Vector3 _endValueRotate;
    [SerializeField] float _durationRotate;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DOLocalRotate(_endValueRotate, _durationRotate);
    }
}
