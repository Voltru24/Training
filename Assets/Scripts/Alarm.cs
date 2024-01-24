using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private float _maxVolume;
    [SerializeField] private float _speedVolume;

    private float _minVolume = 0;
    private AudioSource _audioSource;
    private Coroutine _workChangeVolume;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        if (_workChangeVolume != null)
        {
            StopCoroutine(_workChangeVolume);
        }

        _workChangeVolume = StartCoroutine(ChangeVolume(_maxVolume));
    }

    public void Stop()
    {
        if (_workChangeVolume != null)
        {
            StopCoroutine(_workChangeVolume);
        }

        _workChangeVolume = StartCoroutine(ChangeVolume(_minVolume));
    }

    private IEnumerator ChangeVolume(float volume)
    {
        while (_audioSource.volume != volume)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, volume, _speedVolume * Time.deltaTime);

            yield return null;
        }
    }
}
