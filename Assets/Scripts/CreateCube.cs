using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : CreateObject
{
    public GameObject cubePrefab;

    public void Create(Vector3 position)
    {
        ObjectCreator.Instantiate(cubePrefab, position, Quaternion.identity);
    }
}