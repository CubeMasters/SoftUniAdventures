using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 70f))
            {
                if (hit.collider.gameObject.transform.tag == "RiddleBook")
                {
                    SceneManager.LoadScene("BookRiddles");
                }
                else if (hit.collider.gameObject.transform.tag == "CircuitBreaker")
                {
                    SceneManager.LoadScene("FuseGame");
                }
                else if (hit.collider.gameObject.transform.tag == "SafeGame")
                {
                    SceneManager.LoadScene("backPackScene");
                }
                else if (hit.collider.gameObject.transform.tag == "TyperNarGame")
                {
                    SceneManager.LoadScene("game");
                }
            }
        }
    }
}