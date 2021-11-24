using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowUp : MonoBehaviour
{
    public GameObject enemyDeathFX;
    playerHealth currentHealth;
    public AudioClip enemyDestroyed;

    AudioSource enemyAudio; 

    // Start is called before the first frame update
    void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag != "Player") return;

        Instantiate(enemyDeathFX, transform.position, transform.rotation);
        enemyAudio.clip = enemyDestroyed;
        enemyAudio.Play();
        Destroy(gameObject);
        currentHealth.damaged();
        
    }
}
