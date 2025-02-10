using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;

public class SingleObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab; // Hanya satu prefab
    private GameObject spawnedObject; // Menyimpan objek yang sudah muncul
    public Transform spawnPoint; // Tempat spawn objek

    private void Start()
    {
        var interactable = GetComponent<XRBaseInteractable>();
        if (interactable != null)
        {
            interactable.activated.AddListener(SpawnObject);
        }
    }

    private void SpawnObject(ActivateEventArgs args)
    {
        if (spawnedObject == null) // Cek apakah objek belum ada di scene
        {
            spawnedObject = Instantiate(objectPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
