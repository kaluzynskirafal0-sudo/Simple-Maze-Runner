using UnityEditor.Build.Content;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player") && gameObject.tag != "Hit")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            other.gameObject.GetComponent<MyGameManager>().AddHit();
            gameObject.tag = "Hit";
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
