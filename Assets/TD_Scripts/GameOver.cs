using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text roundsText;

    private void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Retry()
    {
        //Load Active Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        //Load Scene by name
        //SceneManager.LoadScene("MainScene");

        //Load Scene by build index
        //SceneManager.LoadScene(0);
    }

    public void Menu()
    {
        Debug.Log("Go To Menu");
    }

}
