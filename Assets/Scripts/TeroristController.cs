﻿using UnityEngine;
using System.Collections;

public class TeroristController : MonoBehaviour {

    public Rigidbody2D bullet;
    
    // Use this for initialization
	void Start () 
    {
        Rigidbody2D movingBullet;
        movingBullet = Instantiate(bullet, new Vector2(-7.13f, -1.54f), Quaternion.identity) as Rigidbody2D;
        
        //movingBullet.velocity = transform.TransformDirection(Vector2.right * 10);
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}
}