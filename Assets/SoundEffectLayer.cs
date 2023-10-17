using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundEffectLayer : MonoBehaviour
{
    public AudioSource Sounds;
    public AudioClip bgSound, jumpSound,hitSound, tenSound;

    void Start()
    {
        Sounds.clip = bgSound;
        Sounds.Play();
    }

    public void jump()
    {
        
        Sounds.PlayOneShot(jumpSound);
    }
    public void hit()
    {
       
        Sounds.PlayOneShot(hitSound);
    }

    public void ten()
    {
        Sounds.PlayOneShot(tenSound);
    }
}
