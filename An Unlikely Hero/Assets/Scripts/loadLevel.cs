using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class loadLevel : MonoBehaviour
{
    public int ilevelToLoad;
    public string sLevelToLoad;

    public bool useIntegerToLoadLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject triggerObject = other.gameObject;
        
        if (triggerObject.name == "Player")
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(ilevelToLoad);
        } else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}
