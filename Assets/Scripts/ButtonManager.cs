using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }
    public void StartScene()
    {
        SceneManager.LoadScene((int)Scenes.StartScene);
    }
    public void NextShooting()
    {
        SceneManager.LoadScene((int)Scenes.ShootingGame);
    }
    public void NextHitting()
    {
        SceneManager.LoadScene((int)Scenes.HittingGame);
    }
    public void NextEnding()
    {
        SceneManager.LoadScene((int)Scenes.EndingGame);
    }
    public enum Scenes
    {
        StartScene,
        ShootingGame,
        HittingGame,
        EndingGame
    }
}
