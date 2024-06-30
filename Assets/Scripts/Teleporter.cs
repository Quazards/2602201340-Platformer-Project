using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GetComponent<Collider2D>().tag == "Point")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
            collision.gameObject.SetActive(false);
            
        }
        if(GetComponent<Collider2D>().tag == "Emoji")
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            collision.gameObject.SetActive(false);
        }   
    }
    
}
