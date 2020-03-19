using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundsplat : MonoBehaviour
{
    public static soundsplat sndMan; // not sure 
    private AudioSource audioSrc; //Stores source to play sounds out of
    private AudioClip[] SplatSounds; //An array os sfx's

    private int randomjumpsound;//Variable that'll hold a random picked sound

    // Start is called before the first frame update
    void Start()
    {
        sndMan = this;
        audioSrc = GetComponent<AudioSource>();
        SplatSounds = Resources.LoadAll<AudioClip>("SplatSounds");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySplatSound()
    {
        randomjumpsound = Random.Range(0, 4);//Randomly picks a splat sfx
        audioSrc.PlayOneShot(SplatSounds[randomjumpsound]);//Plays picked sfx
    }
}
