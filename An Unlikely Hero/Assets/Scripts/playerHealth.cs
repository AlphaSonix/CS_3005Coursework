using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float fullHealth;
    public GameObject deathFX;
    //public AudioClip playerHurt;

    public restartGame theGameManager; 

    float currentHealth;

    //AudioSource playerAS;

    playerController controlMovement;

    
    //HUD variables 
    public Slider healthSlider;
    public Text gameOverScreen;
    public Text winLevelScreen;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = fullHealth;

        controlMovement = GetComponent<playerController>();
    
        //HUD Initialisation
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;

       // playerAS = GetComponent<AudioSource>();
    
        }

    // Update is called once per frame
    void Update()
    {

    }

    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;

        //playerAS.clip = playerHurt;
        //playerAS.Play();
        //playerAS.PlayOneShot(playerHurt); Does same thing

        healthSlider.value = currentHealth;
        //damaged = true;

        if (currentHealth <= 0)
        {
            makeDead();
        }
    }
    
    public void addHealth(float healthAmount)
    {
        currentHealth += healthAmount;
        if (currentHealth > fullHealth)
        {
            currentHealth = fullHealth;
        }
        healthSlider.value = currentHealth;
    }

    public void makeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        //Destroy(healthSlider.gameObject);
        Destroy(gameObject);

        Animator gameOverAnimator = gameOverScreen.GetComponent<Animator>();
        gameOverAnimator.SetTrigger("gameOver");
        theGameManager.restartTheGame();
    }

    public void winLevel()
    {
        Destroy(gameObject);
        Animator winLevelAnimator = winLevelScreen.GetComponent<Animator>();
        winLevelAnimator.SetTrigger("passCheck");
    }

    public void damaged()
    {
        currentHealth -= 1; 
    }
    /* Never finished
     // For random sounds such as player expressing different grunts when being hit. 
      public AudioClip[] randomSound; 
     AudioSource playRandomSound


 //in start
     playRandomSound = GetComponent<AudioSource>();



 //in some function
 AudioClip tempClip = randomSounds[Random.Range(0, randomSounds.Length)];
     playRandomSound.clip = tempClip;
 playRandomSound.Play(); */
}
