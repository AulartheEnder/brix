using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private int maxHits;
    private int timesHit;

    public static int breakableCount = 0;

    public Sprite[] hitSprites;
    private LevelManager levelManager;

    bool isBreakable;

    // Use this for initialization
    void Start ()
    {
        isBreakable = (this.tag == "Breakable");

        //Keeps track of breakable bricks
        if(isBreakable)
        {
            breakableCount++;
        }
         
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;  
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void OnCollisionExit2D(Collision2D collision)
    { 
        if (isBreakable)
        {
            HandleHits();
        }
    }
    
    // TODO remove this function when we can actually win.
    void HandleHits()
    {
        maxHits = hitSprites.Length + 1;

        timesHit++;

        if (timesHit >= maxHits)
        {
            breakableCount--;
            levelManager.brickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }

    }

    private void LoadSprites()
    {
        int spriteIndex = timesHit - 1;

        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }
}
