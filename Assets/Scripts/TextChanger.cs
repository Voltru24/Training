using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _textForChange1;
    [SerializeField] private string _textForChange2;
    [SerializeField] private string _textForChange3;
    [SerializeField] private float _durationChange;

    private Text _text;
    
    private void Start()
    {
        _text = GetComponent<Text>();

        Change();
    }

    private void Change()
    {
        Sequence textSequence = DOTween.Sequence();

        textSequence.Append(_text.DOText(_textForChange1, _durationChange));
        textSequence.Append(_text.DOText(_textForChange2, _durationChange).SetRelative());
        textSequence.Append(_text.DOText(_textForChange3, _durationChange, true, ScrambleMode.All));
    }
}
