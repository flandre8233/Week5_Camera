using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalResourceSound : MonoBehaviour
{
    public static void SpawnSound(string name, Vector3 SpawnPos)
    {
        GameObject Prefab = Resources.Load<GameObject>(name);
        GameObject SpawnObject = Instantiate(Prefab, SpawnPos, Quaternion.identity);
        SpawnObject.name = Prefab.name;
        Destroy(SpawnObject, 5);
    }
}
