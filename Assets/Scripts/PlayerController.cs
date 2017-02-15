using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    public LayerMask selectableLayer;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Click");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Here is where we would need to check for actions on the object we hit
                Debug.Log("Move");
                agent.SetDestination(hit.point);
            }
            
        }
    }
}
