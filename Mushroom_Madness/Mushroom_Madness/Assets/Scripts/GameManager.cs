using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public string objectTag1 = "AppleCounter";
    public string objectTag2 = "RockCounter";

    public static GameManager instance = null;

    public GameObject AppleSpawner;
    public GameObject RockSpawner;
    public GameObject WinPanel;
    public GameObject LosePanel;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != null)
            Destroy(gameObject);
    }

    public void Win()
    {
        AppleSpawner.SetActive(false);
        RockSpawner.SetActive(false);
        DestroyObjectsWithTag(objectTag1);
        DestroyObjectsWithTag(objectTag2);
        WinPanel.SetActive(true);
    }

    public void Lose()
    {
        AppleSpawner.SetActive(false);
        RockSpawner.SetActive(false);
        LosePanel.SetActive(true);
    }
    private void DestroyObjectsWithTag(string tag)
    {
        // Find all objects with the specified tag
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(tag);

        // Destroy each object
        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
