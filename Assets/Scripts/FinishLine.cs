using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="collision">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider colider)
    {
        if(colider.tag == "car")
        {
            SceneManager.LoadScene(4);
        }
    }
}
