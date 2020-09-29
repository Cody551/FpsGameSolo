﻿using System.Collections;
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

    





    public enum GameState
    {
        Start,
        Playing,
        GameOver
    };
    private GameState m_GameState;
    public GameState State { get { return m_GameState; } }

    private void Awake()
    {
        m_GameState = GameState.Start;
        slider.gameObject.SetActive(false);

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









                break;

            case GameState.Playing:





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

        m_GameState = GameState.Playing;


    }
    
    public void OnQuit()
    {
        
    }







}
