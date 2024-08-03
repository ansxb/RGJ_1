using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalscript : MonoBehaviour
{

    private HashSet<GameObject> portalObjects = new HashSet<GameObject>();
    [SerializeField] private Transform destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (portalObjects.Contains(collision.gameObject))
            return;
        if (destination.TryGetComponent(out portalscript destinationPortal))
        {
            destinationPortal.portalObjects.Add(collision.gameObject);
        }
        collision.transform.position=destination.position;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        portalObjects.Remove(collision.gameObject);
    }
    //public float x;
    //public float y;
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    collision.transform.position=new Vector3(x,y);

    //}
}
