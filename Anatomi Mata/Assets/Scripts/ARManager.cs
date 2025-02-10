using UnityEngine;

public class ARManager : MonoBehaviour
{
    public GameObject[] allAnatomy;

    void Start()
    {
        // Initialize or perform setup here if needed
    }

    void Update()
    {
        // Regular updates or functionality
    }

    public void ActivateAnatomy(int id)
    {
        Debug.Log("Debug");
        allAnatomy[id].SetActive(true);
        // Ensure all objects are inactive first
        for (int i = 0; i < allAnatomy.Length; i++)
        {
            allAnatomy[i].SetActive(false);
        }

        // Activate the selected object
        if (id >= 0 && id < allAnatomy.Length) // Ensure id is within bounds
        {
            allAnatomy[id].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Invalid ID provided for ActivateAnatomy");
        }
    }
}
