using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button PlayButton;
    public Button QuitButton;
    public Text TitleScreen;
    public GameObject BackgroundPanal;
    public Slider slider;

    public GameObject[] Turrets;
    public Text gameOverText;
    public Button continueButton;
    
    public GameObject FpsController;
    public GameObject winningCubeTrigger;
    public Text winningText;

    public GameObject[] doorBlocks;
    





    public enum GameState
    {
        Start,
        Playing,
        GameOver,
        Win
    };
    private GameState m_GameState;
    public GameState State { get { return m_GameState; } }

    private void Awake()
    {
        m_GameState = GameState.Start;
        slider.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        winningText.gameObject.SetActive(false);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        switch (m_GameState)
        {
            case GameState.Start:
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                FpsController.GetComponent<PlayerHealth>().currentHealth = 100f;
                slider.value = FpsController.GetComponent<PlayerHealth>().currentHealth;

                for (int i = 0; i < Turrets.Length; i++)                     // loop though all thew turrets in the array
                {
                    Turrets[i].SetActive(true);                             // and turn them on 
                }

                for (int i = 0; i < doorBlocks.Length; i++)                     // loop though all thew turrets in the array
                {
                    doorBlocks[i].SetActive(true);                             // and turn them on 
                }



                    break;

            case GameState.Playing:
                bool isGameOver = false;

                if (IsPlayerDead() == true)
                {
                    isGameOver = true;
                }
                else if (winningCubeTrigger.GetComponent<Winning>().WinningTrigger == true) 
                {
                    m_GameState = GameState.Win;
                }
                if(isGameOver == true)
                {
                    m_GameState = GameState.GameOver;

                }
                



                break;

               case GameState.GameOver:
                slider.gameObject.SetActive(false);
                continueButton.gameObject.SetActive(true);
                gameOverText.gameObject.SetActive(true);
                BackgroundPanal.gameObject.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;


                break;
            case GameState.Win:
                slider.gameObject.SetActive(false);
                BackgroundPanal.SetActive(true);
                continueButton.gameObject.SetActive(true);
                winningText.gameObject.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;


                break;

        }
   

    }

    public void OnPlay()
    {
        
        BackgroundPanal.gameObject.SetActive(false);
        PlayButton.gameObject.SetActive(false);
        QuitButton.gameObject.SetActive(false);
        TitleScreen.gameObject.SetActive(false);
        slider.gameObject.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        m_GameState = GameState.Playing;


    }
    
    public void OnQuit()
    {
        
    }

    private bool IsPlayerDead()
    {
        if (FpsController.GetComponent<PlayerHealth>().currentHealth <= 0f)
        {
            return true;
        }
        return false;
    }

    public void OnContinue()
    {
        continueButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        PlayButton.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);
        TitleScreen.gameObject.SetActive(true);
        winningText.gameObject.SetActive(false);

        
        m_GameState = GameState.Start;
    }



}
