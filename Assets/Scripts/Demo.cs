using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void Update()
    {
        ShapeSystem.Update();
        CollisionDetectionSystem.QuadtreeTest();
    }

}
