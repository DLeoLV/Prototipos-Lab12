using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCylinder : CreateObject
{
    public GameObject cylinderPrefab;

    public void Create(Vector3 position)
    {
        ObjectCreator.Instantiate(cylinderPrefab, position, Quaternion.identity);
    }
}