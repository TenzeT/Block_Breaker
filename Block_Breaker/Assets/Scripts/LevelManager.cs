using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //Load game level on Start click
    public void LoadLevel(string name)
    {
        Application.LoadLevel(name); // Load level with this name
    }

    //Quit game
    public void QuitGame(string name)
    {
        Application.Quit();
    }

    // Load the next level in sequence
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    // Check if last brick destroyed to move to next level
    public void BrickDestroyed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
