using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public Transform fanPosition;
    public float windForce = 10f;
    public float rayDistance = 10f;

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(fanPosition.position, Vector2.up, rayDistance);

        if (hit.collider != null && hit.collider.tag != "Grenade")
        {
            Debug.Log("yes");
            // Collider (not a grenade) is blocking the wind
            Debug.DrawRay(fanPosition.position, Vector2.up * hit.distance, Color.red);
        }
        else
        {
            // No blocking or the only hit is the grenade, apply wind force
            Debug.DrawRay(fanPosition.position, Vector2.up * rayDistance, Color.green);
            ApplyWindForce();
        }
    }

    void ApplyWindForce()
    {
        // Code to apply wind force to the grenade
    }
}