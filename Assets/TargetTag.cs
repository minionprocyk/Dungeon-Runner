using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[RequireComponent(typeof(SphereCollider))]
public class TargetTag : MonoBehaviour {
    public string Tag;
    [SerializeField]
    private List<GameObject> targetsInRange;
    public List<GameObject> TargetsInRange
    {
        get
        {
            targetsInRange.RemoveAll(go => go == null);
            return targetsInRange;
        }
    }
    public float Range=10;

    private SphereCollider Collider;
    private void Start()
    {
        Collider = GetComponent<SphereCollider>();
        Collider.radius = Range;
    }
    private void OnTriggerStay(Collider other)
    {
        if (!other)
        {
            targetsInRange = targetsInRange.Where(go => go != null).ToList();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(Tag))
        {
            targetsInRange.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(Tag))
        {
            targetsInRange.Remove(other.gameObject);
        }
    }
}
