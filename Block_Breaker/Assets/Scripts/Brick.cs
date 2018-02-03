using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public static int breakableCount = 0;
    public AudioClip crack;
    public Sprite[] hitSprites;
    public LevelManager levelManager;
    private int timesHit;
    private bool isBreakable;

    // Initialize variables
    void Start()
    {
        isBreakable = (this.tag == "Breakable");
        // Add count to breakable bricks in scene
        if (isBreakable)
        {
            breakableCount++;
        }
        timesHit = 0;
        levelManager = (LevelManager)FindObjectOfType(typeof(LevelManager));
    }

    // Check if block is tagged Breakable, if so call HandleHits()
    void OnCollisionEnter2D(Collision2D col)
    {
        // Play sound where brick is
        AudioSource.PlayClipAtPoint(crack, transform.position);
        if (isBreakable == true)
            HandleHits();
    }

    // Increment number of times hit, if necessary, destroy block and decrement breakable countr
    void HandleHits()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            breakableCount--;
            levelManager.BrickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    public void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }

    }

    // TODO Remove when we can win
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }

}
