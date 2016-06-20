using UnityEngine;
using System.Collections;
using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class CameraHolderScript : MonoBehaviour {
    public float speed;
    public float baseHeight;
    public float userHeight;
    private Rigidbody rb;
    public GameObject mainCamera;
    public LocomotionInterface locomotion;

    public const float HEIGHT_TO_STRIDE =  3 * .414f;

    private Vector3 previous;

    // Use this for initialization
    void Start () {
        // why do we need rigid body? Can't we just use our own position?
        rb = GetComponent<Rigidbody>();
        
        transform.position = new Vector3(0.0f, baseHeight + userHeight, 0.0f);
        Debug.Log("camera" + GameObject.Find("Main Camera"));
        mainCamera = GameObject.Find("Main Camera");
        Debug.Log("assigned: " + mainCamera);

        speed = HEIGHT_TO_STRIDE * userHeight;
    }

    // x is the forward direction
    void LateUpdate()
    {
        //Debug.Log(locomotion);
        float y = mainCamera.transform.eulerAngles.y;
        
        Vector2 moveAmount = locomotion.getMovement(speed);
        Debug.Log(moveAmount);
        Vector3 newMove = new Vector3(
            Mathf.Sin(y * Mathf.Deg2Rad) * moveAmount.x + Mathf.Cos(y * Mathf.Deg2Rad) * moveAmount.y,
            0.0f,
            Mathf.Cos(y * Mathf.Deg2Rad) * moveAmount.x + Mathf.Sin(y * Mathf.Deg2Rad) * -moveAmount.y)
        ;
        rb.transform.Translate(newMove);
        Debug.Log(rb.velocity);     
        
    }
}
