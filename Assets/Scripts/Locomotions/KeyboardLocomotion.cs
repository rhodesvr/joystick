using UnityEngine;
using System.Collections;
using System;

public class KeyboardLocomotion : LocomotionInterface {

    public override Vector2 getMovement(float speed)
    {
        if (Input.GetKeyDown("up"))
            return new Vector2(speed, 0);
        else
            return new Vector2(0, 0);
    }

    // Use this for initialization
    void Start () {
        Debug.Log("starting keyboard locomotion");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
