using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameAudio : MonoBehaviour
{
    //My code to fade out music once player has beaten boss 

    public float musicFadeSpeed;
    public AudioClip victoryMusic;
    private AudioSource currentAudio;
    private AudioSource newAudio; 

    void Awake()
    {
        if (gameObject.tag == "Ground")
        {
            currentAudio = GetComponent<AudioSource>();
        }
        newAudio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider other) 
    {
        //fades out music
        currentAudio.volume = Mathf.Lerp(currentAudio.volume, 0f, musicFadeSpeed * Time.deltaTime);

        if (gameObject.tag == "Finished")
        {
            //plays victory celebration
            newAudio.clip = victoryMusic; 
        }
    }
}
