using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject deadVersion;
    Vector2 newPosition;

    void Start(){
        newPosition = (Vector2)transform.position + new Vector2(1f, 0f);
    }

    public void Destroy(){
        Instantiate(deadVersion, newPosition, transform.rotation);
        Destroy(gameObject);
    }
}
