using UnityEngine;
using TMPro;

public class MyGameManager : MonoBehaviour
{
    public GameObject endPanel;        
    public TextMeshProUGUI resultText; 
    
    private float startTime;
    private int hits = 0; 
    private bool isFinished = false;

    void Start()
    {
        startTime = Time.time;
        hits = 0; 
        if (endPanel != null) endPanel.SetActive(false);
    }

    
    public void AddHit()
    {
        if (!isFinished)
        {
            hits++;
            Debug.Log("Trafienie! Suma: " + hits);
        }
    }

    public void FinishGame()
    {
        if (isFinished) return;
        isFinished = true;

        float finalTime = Time.time - startTime;

        if (endPanel != null)
        {
            endPanel.SetActive(true);
            
            resultText.text = "META!\n" +
                              "Czas: " + finalTime.ToString("F2") + "s\n" +
                              "Trafienia: " + hits;
        }

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null) rb.isKinematic = true;
    }
}