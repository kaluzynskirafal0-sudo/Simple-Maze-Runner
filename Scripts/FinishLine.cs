using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MyGameManager manager = Object.FindFirstObjectByType<MyGameManager>();
            
            if (manager != null)
            {
                manager.FinishGame();
            }
        }
    }
}