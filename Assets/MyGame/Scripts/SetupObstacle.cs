using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupObstacle : MonoBehaviour
{

    private void Start()
    {
        FindObjectOfType<CreateGameObjectsPool>().CreateGameObject("Obstacle",Vector3.zero);
    }




}
