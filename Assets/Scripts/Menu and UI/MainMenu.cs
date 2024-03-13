using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenuCanvas, levelSelectionCanvas, gameCanvas;
    public void StartButton()
    {
        levelSelectionCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void BackButton()
    {
        mainMenuCanvas.SetActive(true);
        levelSelectionCanvas.SetActive(false);
    }

    public void LoadLevel(int levelNum)
    {
        LevelSelection.CurrLevel = levelNum;
        gameCanvas.SetActive(true);
        levelSelectionCanvas.SetActive(false);
    }

    public void BackToMenu()
    {
        levelSelectionCanvas.SetActive(true);
        gameCanvas.SetActive(false);
    }
}
