using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private float _maxVolume;
    [SerializeField] private float _speedVolume;

    private float _minVolume = 0;
    private AudioSource _audioSource;

    public void Run()
    {
        StopAllCoroutines();
        StartCoroutine(�hangeVolume(_maxVolume));
    }

    public void Stop()
    {
        StopAllCoroutines();
        StartCoroutine(�hangeVolume(_minVolume));
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private IEnumerator �hangeVolume(float volume)
    {
        while (_audioSource.volume != volume)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, volume, _speedVolume * Time.deltaTime);

            yield return null;
        }
    }
}
