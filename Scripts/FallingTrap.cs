using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    private bool hasHit = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !hasHit)
        {
            hasHit = true;
            var manager = Object.FindFirstObjectByType<MyGameManager>();
            if (manager != null) manager.AddHit();

            // Gaszenie neonu
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.material.SetColor("_EmissionColor", Color.black);
            mesh.material.DisableKeyword("_EMISSION");
        }
    }
}