using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectFactory
{
    public CreateObject CreateObject(string objectType)
    {
        switch (objectType)
        {
            case "A":
                return new CreateCube();
            case "S":
                return new CreateSphere();
            case "D":
                return new CreateCylinder();
            default:
                return null;
        }
    }
}