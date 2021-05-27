using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    public string isim;
    public AudioClip sesKlibi;

    [Range(0f,1f)]
    public float kuvvet;

    [Range(.1f,3f)]
    public float perde;

    [HideInInspector]
    public AudioSource source;
}
