using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlLaunch : MonoBehaviour
{
    Vector3 launchVelocity;
    Rigidbody rigidBody;
    AudioSource audioSource;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        rigidBody.useGravity = true; 
        launchVelocity = new Vector3(0, 0, 200);
        Launch(launchVelocity);
    }

    public void Launch(Vector3 launchVelocity)
    {
        rigidBody.AddForce(launchVelocity, ForceMode.Impulse); 
        audioSource.Play();
    }
}
