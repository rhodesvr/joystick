using UnityEngine;
using System.Collections;

public class GamepadLocomotion : LocomotionInterface
{
    public float joySpeed;
    public int joy;
	// Use this for initialization

    void Start ()
    {
        if (joySpeed == 0)
        {
            joySpeed = 1;
        }

    }


	void Update () {
        //Debug.Log("gamepad update" + Input.GetAxis("Vertical") * joySpeed + " " + Input.GetAxis("Horizontal") * joySpeed);
        //Debug.Log(Input.IsJoystickPreconfigured(Input.GetJoystickNames()[joy]));
        //Debug.Log(Input.GetAxis("Horizontal"));
    }


    public override Vector2 getMovement(float speed)
    {
        Vector2 move = new Vector2(Input.GetAxis("Vertical") * joySpeed, Input.GetAxis("Horizontal") * joySpeed);
        return move;
    }
}
