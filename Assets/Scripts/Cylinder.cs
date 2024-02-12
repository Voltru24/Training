using UnityEngine;
using DG.Tweening;
[RequireComponent(typeof(MeshRenderer))]
public class Cylinder : MonoBehaviour
{
    [SerializeField] private Color _colorForChange;
    [SerializeField] private float _durationChangeColor;

    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        ChangeColor();
    }

    private void ChangeColor()
    {
        Material material = _meshRenderer.material;

        material.DOColor(_colorForChange, _durationChangeColor);
    }
}
