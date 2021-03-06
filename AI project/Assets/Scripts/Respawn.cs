﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public int respawn;
    NewBehaviourScript health;
    // Start is called before the first frame update
    void Start()
    {
        health = FindObjectOfType<NewBehaviourScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Startover();
    }

    private void Startover()
    {
        if(health.Player_health <= 0)
        {
            SceneManager.LoadScene(respawn);
        }
    }
}
