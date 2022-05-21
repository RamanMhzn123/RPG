using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField] AreaEnter areaEnter;
    [SerializeField] string transitonExitName;
    [SerializeField] int sceneToLoad;
    
    // Start is called before the first frame update
    void Start()
    {
        areaEnter.transitonEnterName = transitonExitName;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.instance.transitonName = transitonExitName;
            MenuManager.instance.FadeImage();        
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
