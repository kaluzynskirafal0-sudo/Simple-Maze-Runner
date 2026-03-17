using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject trapToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (trapToActivate != null)
            {
                trapToActivate.SetActive(true); 
            }
            Destroy(gameObject); 
        }
    }
}