using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Destroy : MonoBehaviour
{
    public Button DeleteButton;

    void Start()
    {
        Button btn = DeleteButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        GameObject[] prefabsToDestroy = GameObject.FindGameObjectsWithTag("ARSpawnedPrefab");
        foreach (GameObject prefab in prefabsToDestroy)
        {
            Destroy(prefab);
        }
    }
}

