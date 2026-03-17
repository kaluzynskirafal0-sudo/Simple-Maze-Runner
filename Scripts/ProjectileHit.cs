using System;
using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    private bool hasHit = false;

    void OnEnable()
    {
        Destroy(gameObject, 1.3f);
    }
    

  private void OnCollisionEnter(Collision other)
{
    if (other.gameObject.CompareTag("Player") && !hasHit)
    {
        hasHit = true;  
        var manager = UnityEngine.Object.FindFirstObjectByType<MyGameManager>();
        if (manager != null) manager.AddHit();
 
        MeshRenderer mesh = GetComponent<MeshRenderer>(); 
     
        Material mat = mesh.material; 
        mat.color = Color.black;

        mat.SetColor("_EmissionColor", Color.black); 
        mat.DisableKeyword("_EMISSION");             
        DynamicGI.SetEmissive(mesh, Color.black);

        Destroy(gameObject, 0.2f);
    }
}
}