using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetIndexScene : MonoBehaviour
{
    
    public void GameOver()
    {
        PlayerPrefs.SetInt("ThisScene", 0);
        SceneManager.LoadScene(0);
        this.gameObject.SetActive(false);
    }

   
}
