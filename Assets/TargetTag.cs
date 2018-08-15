using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class TargetTag : MonoBehaviour {
    public string Tag;
    public List<GameObject> TargetsInRange;
    public float Range=10;

    private SphereCollider Collider;
    private void Start()
    {
        Collider = GetComponent<SphereCollider>();
        Collider.radius = Range;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(Tag))
        {
            TargetsInRange.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(Tag))
        {
            TargetsInRange.Remove(other.gameObject);
        }
    }
}
