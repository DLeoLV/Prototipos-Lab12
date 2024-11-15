using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSphere : CreateObject
{
    public GameObject spherePrefab;

    public void Create(Vector3 position)
    {
        ObjectCreator.Instantiate(spherePrefab, position, Quaternion.identity);
    }
}