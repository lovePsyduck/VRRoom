using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;

    private void Interaction()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward , out hit,5, layerMask))
        {

        }
    }

}
