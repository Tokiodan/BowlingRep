using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
    public Transform ball;
    public Transform cone;
    //public float followTime = 3f;
    public float stopDistance = 5f;

    void Update()
    {
        if (Vector3.Distance(transform.position, cone.position) > stopDistance)
        {
            transform.position = ball.position + new Vector3(0, 5, -10);
            //followTime -= Time.deltaTime;
        }
    }

    //Hehe, ik ben niet zoals de andere normies. SIGMA GIZMO 
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, stopDistance);
    }
}
