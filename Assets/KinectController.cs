using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class KinectController : MonoBehaviour, KinectGestures.GestureListenerInterface
{
    public delegate void GestureEvent();
    public static event GestureEvent OnWave;
    public static KinectController Instance = null;


    public KUser[] userList;

    private void Awake()
    {
        userList = GameObject.FindObjectsOfType<KUser>();
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Debug.LogWarning("Found more than 1 kinectControler instance");
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    private void Start()
    {

        //kinectManager.SetKinectToWorldMatrix(Vector3.zero, Quaternion.identity, new Vector3(DATA.SKELETON_SIZE, DATA.SKELETON_SIZE, DATA.SKELETON_SIZE));

    }





    //INTERFACE FORCES METHODS
    //................................
    //................................

    public void UserDetected(long userId, int userIndex)
    {
        foreach (var user in userList)
        {
            if (user.userIndex == userIndex)
            {
                user.SetActive(true);
            }
        }
    }

    public void UserLost(long userId, int userIndex)
    {
        foreach (var user in userList)
        {
            if (user.userIndex == userIndex)
            {
                user.SetActive(false);
            }
        }
    }

    public void GestureInProgress(long userId, int userIndex, KinectGestures.Gestures gesture, float progress, KinectInterop.JointType joint, Vector3 screenPos)
    {
        //...
    }

    public bool GestureCompleted(long userId, int userIndex, KinectGestures.Gestures gesture, KinectInterop.JointType joint, Vector3 screenPos)
    {


        return true;
    }

    public bool GestureCancelled(long userId, int userIndex, KinectGestures.Gestures gesture, KinectInterop.JointType joint)
    {
        return true;
    }
}