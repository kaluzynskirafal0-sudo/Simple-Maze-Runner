using UnityEngine;

public class NeonWall : MonoBehaviour
{
    private bool isOff = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !isOff)
        {
            isOff = true;

           
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            

            Material mat = mesh.material;

       
            mat.color = Color.black;
            mat.SetColor("_EmissionColor", Color.black);
            mat.DisableKeyword("_EMISSION");
            
     
            DynamicGI.SetEmissive(mesh, Color.black);

 
            var manager = Object.FindFirstObjectByType<MyGameManager>();
            if (manager != null) manager.AddHit();
        }
    }
}