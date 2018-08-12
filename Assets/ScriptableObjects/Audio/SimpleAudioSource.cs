using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Audio/Audio Effect")]
public class SimpleAudioSource : AudioEvent
{
    [SerializeField]
    private AudioClip[] clips;

    [MinMaxRange(0, 100)]
    [SerializeField]
    private RangedFloat volume;

    [MinMaxRange(0,1)]
    [SerializeField]
    private RangedFloat pitch;
    public override void Play(AudioSource source)
    {
        if (clips.Length !=0)
        {
            source.clip = clips[Random.Range(0, clips.Length)];
            source.volume = Random.Range(volume.Min, volume.Max);
            source.pitch = Random.Range(pitch.Min, pitch.Max);
            source.PlayOneShot(source.clip);
        }
    }
}
