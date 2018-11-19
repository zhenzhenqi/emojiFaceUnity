using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UnifySize : MonoBehaviour {

    public List<Transform> children;


    public float targetSize = 10;

    public bool addParent = false;
    public bool getAllChild = false;
	// Use this for initialization
	void Start () {
        children = new List<Transform>();

    }
	
	// Update is called once per frame
	void Update () {

        if (getAllChild)
        {
            foreach (Transform child in transform)
            {
                children.Add(child);
            }
              
            getAllChild = false;
        }
        if (addParent)
        {
          foreach(Transform child in children)
            {
                GameObject mParent = new GameObject();
                mParent.name = child.name + " : wrapper";
                mParent.tag = "emojiWrapper";
                mParent.transform.parent = gameObject.transform;
              
                child.parent = mParent.transform;
            }
            addParent = false;
        }
	}
}
