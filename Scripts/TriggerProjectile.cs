using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    
    [SerializeField] GameObject[] projectiles; 
    
    
    [SerializeField] float launchForce = 1000f; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            Vector3 targetPosition = other.transform.position;

            
            foreach (GameObject p in projectiles)
            {
                if (p != null)
                {
                    
                    p.SetActive(true);

                    
                    Rigidbody rb = p.GetComponent<Rigidbody>();
                    
                    if (rb != null)
                    {
                        
                        Vector3 direction = (targetPosition - p.transform.position).normalized;
                        
                        
                        rb.AddForce(direction * launchForce);
                    }
                }
            }

            
            Destroy(gameObject, 5f);
        }
    }
}