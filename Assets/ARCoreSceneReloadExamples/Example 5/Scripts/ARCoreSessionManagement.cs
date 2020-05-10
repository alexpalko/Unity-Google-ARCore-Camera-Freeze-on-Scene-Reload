using System.Collections;
using UnityEngine;

public class ARCoreSessionManagement : MonoBehaviour
{

    [SerializeField] GameObject arCoreSessionPrefab;
    private GameObject newArCoreSessionPrefab;
    private GoogleARCore.ARCoreSession arcoreSession;


    private void Start()
    {
        newArCoreSessionPrefab = Instantiate(arCoreSessionPrefab, Vector3.zero, Quaternion.identity);
        arcoreSession = newArCoreSessionPrefab.GetComponent<GoogleARCore.ARCoreSession>();
        arcoreSession.enabled = true;
    }



    public void Reset()
    {
        arcoreSession.enabled = false;
        if (newArCoreSessionPrefab != null)
            DestroyImmediate(newArCoreSessionPrefab);

        newArCoreSessionPrefab = Instantiate(arCoreSessionPrefab, Vector3.zero, Quaternion.identity);
        arcoreSession = newArCoreSessionPrefab.GetComponent<GoogleARCore.ARCoreSession>();
        arcoreSession.enabled = true;
    }
}