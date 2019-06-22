﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayeronContact : MonoBehaviour {

    public int damageToGive;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<AudioSource>().Play();

            var player = other.GetComponent<PlayerController>();
            player.knockBackCount = player.knockBackLength;
            player.hurtPlayer(damageToGive);
            if(other.transform.position.x < transform.position.x)
            {
                player.knockFromRight = true;
            }else
            {
                player.knockFromRight = false;
            }
        }
    }
}
