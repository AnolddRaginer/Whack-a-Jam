using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public static sound sndMan;
    private AudioSource audioSrc;
    private AudioClip[] jumpSounds;

    private int randomjumpsound;

    // Start is called before the first frame update
    void Start()
    {
        sndMan = this;
        audioSrc = GetComponent<AudioSource>();
        jumpSounds = Resources.LoadAll<AudioClip>("JumpSounds");
    }

    public void PlayJumpSound()
    {
        randomjumpsound = Random.Range(0, 4);
        audioSrc.PlayOneShot(jumpSounds[randomjumpsound]);
    }
}
