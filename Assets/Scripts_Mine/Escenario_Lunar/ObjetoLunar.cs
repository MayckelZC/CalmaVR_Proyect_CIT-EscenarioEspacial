using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class ObjetoLunar : MonoBehaviour
{
    private ConstantForce cForce;
    private UnityEngine.Vector3 forceDirection;

    // Start is called before the first frame update
    void Start()
    {
        cForce = GetComponent<ConstantForce>();
        forceDirection = new UnityEngine.Vector3(0, -1.5f, 0);
        cForce.force = forceDirection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
