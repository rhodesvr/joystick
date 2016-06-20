using UnityEngine;
using System.Collections;
using System;

public class MyoLocomotion : LocomotionInterface {
    public GameObject myo;
    public float jitterBoundary;
    // this might be a little redundant, but it enables us to have finer control over how much we move
    public float scalingFactor;

    private Vector3 previous;

	// Use this for initialization
	void Start () {
        Debug.Log("starting arm swinging myo locomotion");
        previous = myo.GetComponent<ThalmicMyo>().transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override Vector2 getMovement(float speed)
    {
        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();

        Vector3 current = thalmicMyo.transform.forward;

        Vector3 diff = current - previous;
        previous = current;

        // make sure that we aren't gesticulating
        if (Mathf.Abs(diff.z) < jitterBoundary &&
            Mathf.Abs(diff.x) < jitterBoundary)
        {
            return new Vector2 (Mathf.Abs(diff.y * speed *scalingFactor),0);
        }
        else
            return new Vector2(0.0f, 0.0f);
    }
}
