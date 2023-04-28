using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class PlayMenu : MonoBehaviour
{
    [SerializeField] TMP_InputField PlayerNameInput;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        MenuManager.Instance.PlayerName = PlayerNameInput.text;
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit();
        #endif
    }

    // public input playerName;
    // public Button startButton;
    // public Button quitButton;
    // public Texmeshrp scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGame()
    {
        // SceneManager.LoadScene(1);
        // MenuManager.Instance.PlayerData=adsfsd;
        
    }
}
