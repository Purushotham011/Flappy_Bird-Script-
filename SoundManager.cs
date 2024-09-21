using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{
    public static AudioClip birdPoint, birdFly, birdDeath;
    static AudioSource audioSrc;

    void Start()
    {
        birdPoint = Resources.Load<AudioClip> ("points");
        birdFly = Resources.Load<AudioClip> ("fly");
        birdDeath = Resources.Load<AudioClip> ("die");

        audioSrc = GetComponent<AudioSource> ();
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
        case "points":
        audioSrc.PlayOneShot (birdPoint);
        break;
        case "fly":
        audioSrc.PlayOneShot (birdFly);
        break;
        case "die":
        audioSrc.PlayOneShot (birdDeath);
        break;
        }
    }








}