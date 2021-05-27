using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sesler;
    void Awake()
    {
        foreach (Sound s in sesler)
        {
            s.source =gameObject.AddComponent<AudioSource>();
            s.source.clip = s.sesKlibi;
            s.source.volume = s.kuvvet;
            s.source.pitch = s.perde;
        }
    }

    // Update is called once per frame
    public void Play(string isim)
    {
        Sound s = Array.Find(sesler, Sound => Sound.isim == isim);
        s.source.Play();
    }
}
