using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KUser : MonoBehaviour
{

    public int userIndex;

    public AvatarController avatarController;
    public UserMeshVisualizer userMeshVisualizer;
    public EmojiSpawner emojiSpawner;

    private void Awake()
    {
        avatarController.playerIndex = userIndex;
        userMeshVisualizer.playerIndex = userIndex;
    }

    // Use this for initialization
    void Start()
    {

    }

    public void SetActive(bool state)
    {
        if (state)
        {
            emojiSpawner.SpawnOne();
        }
        else
        {
            emojiSpawner.DespawnAll();
        }
        gameObject.name = "KUser: " + userIndex + (state ? "ON" : "OFF");
    }
    
 
}
