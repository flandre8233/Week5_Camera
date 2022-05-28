using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Seeker : MonoBehaviour
{
    [SerializeField] RightCameraSwitcher switcher;
    [SerializeField] Transform Target;

    public bool IsSeeking()
    {
        if (!switcher.GetCurrentCamera().enabled)
        {
            return false;
        }
        Vector3 screenPoint = switcher.GetCurrentCamera().WorldToViewportPoint(Target.position);
        if (screenPoint.z > -.0f && screenPoint.x > -.0f && screenPoint.x < 1.1f && screenPoint.y > -.0f && screenPoint.y < 1.0f)
        {
            return IsCollision();
        }
        return false;
    }


    bool IsCollision()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(switcher.GetCurrentCamera().transform.position, GetDir(), 30.0F);
        hits = SortByClosest(hits);
        return (hits.Length > 0 && hits[0].collider.CompareTag("Player"));
    }

    RaycastHit[] SortByClosest(RaycastHit[] hits)
    {
        return hits.OrderBy(x => x.distance).ToArray();
    }

    Vector3 GetDir()
    {
        Vector3 pos = switcher.GetCurrentCamera().transform.position;
        return (Target.position - switcher.GetCurrentCamera().transform.position).normalized;
    }

}
