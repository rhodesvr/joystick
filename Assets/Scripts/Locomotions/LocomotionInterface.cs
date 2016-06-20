using UnityEngine;
using System.Collections;

public abstract class LocomotionInterface : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // implement this function!
    public abstract Vector2 getMovement(float speed);
}
