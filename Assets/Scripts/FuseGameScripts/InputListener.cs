using UnityEngine;
using System.Collections;

public class InputListener : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Touch[] touches = Input.touches;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            

            if (Physics.Raycast(ray, out hit, 50f))
            {
                if (hit.collider.gameObject.transform.parent != null)
                {
                    if (hit.collider.gameObject.transform.parent.tag == "CircuitBreaker")
                    {
                        hit.collider.gameObject.transform.parent.GetComponent<CircuitBreaker>().ChangeState();
                    }
                }

                if (hit.collider.gameObject.transform.parent.parent != null)
                {
                    if (hit.collider.gameObject.transform.parent.parent.tag == "CircuitBreaker")
                    {
                        hit.collider.gameObject.transform.parent.parent.GetComponent<CircuitBreaker>().ChangeState();
                    }
                }

            }
        }
        else if(touches != null && touches.Length > 0)
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(touches[0].position);


            if (Physics.Raycast(ray, out hit, 50f))
            {
                if (hit.collider.gameObject.transform.parent != null)
                {
                    if (hit.collider.gameObject.transform.parent.tag == "CircuitBreaker")
                    {
                        hit.collider.gameObject.transform.parent.GetComponent<CircuitBreaker>().ChangeState();
                    }
                }

                if (hit.collider.gameObject.transform.parent.parent != null)
                {
                    if (hit.collider.gameObject.transform.parent.parent.tag == "CircuitBreaker")
                    {
                        hit.collider.gameObject.transform.parent.parent.GetComponent<CircuitBreaker>().ChangeState();
                    }
                }

            }
        }
    }
}