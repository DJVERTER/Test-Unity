using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //private Transform target;

    //[SerializeField]
    //private Vector3 offsetPosition;
    //void Awake()
    //{
    //    target = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
    //}

    //void LateUpdate()
    //{
    //    FollowPlayer();
    //}

    //void FollowPlayer()
    //{
    //    transform.position = target.TransformPoint(offsetPosition);
    //    transform.rotation = target.rotation;
    //}

    public Transform target;
    public float lerpRate;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * lerpRate);
    }
}
