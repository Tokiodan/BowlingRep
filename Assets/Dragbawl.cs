using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BowlLaunch))]
public class Dragbawl : MonoBehaviour

{
    private BowlLaunch ball;
    private Vector3 dragStart, dragEnd;
    private float startTime, endTime;
    public void DragStart() // Capture time and position of drag start
    {
        dragStart = Input.mousePosition;
        startTime = Time.time;
    }
    public void DragEnd() // Launch the ball
    {
        dragEnd = Input.mousePosition;
        endTime = Time.time;

        float dragDuration = endTime - startTime;

        float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
        float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

        Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeedZ);

        ball.Launch(launchVelocity);
    }
}
