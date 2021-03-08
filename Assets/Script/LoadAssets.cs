using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    // Start is called before the first frame update
    public int hideCount;
    void Start()
    {
        Randomize();
    }

    public void Randomize()
    {
        int length = transform.childCount;
        int counter = 0;
        List<int> intList = new List<int>();
        List<int> removeList = new List<int>();
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
            intList.Add(counter);
            counter++;
        }
        for(int i = 0; i < hideCount; i++)
        {
            int rand = Random.Range(0, intList.Count);
            removeList.Add(intList[rand]);
            intList.RemoveAt(rand);
        }
        foreach (int index in removeList)
        {
            transform.GetChild(index).gameObject.SetActive(false);
        }
    }
    public void DestroyAll()
    {
        GameObject empty = GameObject.Find("Empty");
        foreach (Transform child in empty.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
