using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade : MonoBehaviour
{
    
    float countdown;
    bool hasExploded = false;
    
    public GameObject effect;
    public float delay = 7f;
    public float radius = 200f;
    public Collider2D[] colliders;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasExploded){
            Explode();
            hasExploded = true;
        }
    }

    void Explode(){
        Instantiate(effect, transform.position, transform.rotation);

        colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        
        foreach (Collider2D nearbyObject in colliders)
        {
            if(nearbyObject.CompareTag("Enemy")){
                Destructible dest = nearbyObject.GetComponent<Destructible>();
                if(dest != null){
                    dest.Destroy();
                }
            }
        }

        Destroy(gameObject);

    }
}
