using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    private HashSet<GameObject> portalObj = new HashSet<GameObject>();
    [SerializeField]private Transform destination;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(portalObj.Contains(collision.gameObject))
        {
            return;
        }

        if(destination.TryGetComponent(out PortalManager destinationPortal))
        {
            destinationPortal.portalObj.Add(collision.gameObject);
        }
        collision.transform.position = destination.position;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        portalObj.Remove(collision.gameObject);
    }
}
