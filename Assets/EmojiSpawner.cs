using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// turn on random emoji when active
/// turn off all emoji when inactive
/// </summary>
public class EmojiSpawner : MonoBehaviour
{

    public List<Transform> emojis = new List<Transform>();

    public Transform targetTransform;
    void Awake()
    {
        //load all emojis
        foreach (Transform child in transform)
        {
            emojis.Add(child);
        }

    }

    private void Update()
    {
        transform.position = targetTransform.position;
        transform.rotation = targetTransform.rotation;
    }

    private void Start()
    {
        DeactiveAllEmojis();
    }


    public void SpawnOne()
    {
        DeactiveAllEmojis();
        int i = Random.Range(0, emojis.Count-1);
        emojis[i].gameObject.SetActive(true);
    }

    public void DespawnAll()
    {
        DeactiveAllEmojis();
    }

    private void DeactiveAllEmojis()
    {
        foreach (var emoji in emojis)
        {
            print(emoji);
            emoji.gameObject.SetActive(false);
        }
    }


}
