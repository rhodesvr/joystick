using UnityEngine;
using System.Collections;

public class myo : MonoBehaviour {


    public ThalmicMyo Myo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Myo.gyroscope);
	}
}
