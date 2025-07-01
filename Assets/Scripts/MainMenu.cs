using UnityEngine;
using UnityEngin.SceneManager;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        // Change Scene to Level 1
        SceneManager.LoadScene("Level_01");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
