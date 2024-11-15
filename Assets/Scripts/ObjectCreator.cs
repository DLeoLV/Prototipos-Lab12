using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public static void InstantiateObject(GameObject prefab, Vector3 position)
    {
        Instantiate(prefab, position, Quaternion.identity);
    }

    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Create("A");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Create("S");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Create("D");
        }
    }

    void Create(string objectType)
    {
        CreateObjectFactory factory = new CreateObjectFactory();
        CreateObject obj = factory.CreateObject(objectType);

        if (obj is CreateCube createCube)
        {
            createCube.cubePrefab = cubePrefab;
            createCube.Create(transform.position);
        }
        else if (obj is CreateSphere createSphere)
        {
            createSphere.spherePrefab = spherePrefab;
            createSphere.Create(transform.position);
        }
        else if (obj is CreateCylinder createCylinder)
        {
            createCylinder.cylinderPrefab = cylinderPrefab;
            createCylinder.Create(transform.position);
        }
    }
}
