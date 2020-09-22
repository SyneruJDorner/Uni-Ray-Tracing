using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sphere : MonoBehaviour
{
    [System.Serializable]
    public struct sSphere
    {
        public Vector3 position;
        [Range(3, 8)]
        public float radius;
        public Vector3 albedo;
        public Vector3 specular;
    };

    [SerializeField]
    public sSphere sphereInfo = new sSphere();

    // Start is called before the first frame update
    void Awake()
    {
        sphereInfo.position = transform.position;
        RayTracingMaster.Instance.spheres.Add(sphereInfo);
    }
}
