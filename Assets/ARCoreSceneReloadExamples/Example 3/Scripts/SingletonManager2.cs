using UnityEngine;
using UnityEngine.SceneManagement;

public class SingletonManager2 : MonoBehaviour
{

    public static SingletonManager2 SingletonInstance { get; set; }
    public static GameObject ARDeviceInstance { get; set; }
    public GameObject ARDevice;

    void Start()
    {
        if (ARDeviceInstance == null)
        {
            ARDeviceInstance = ARDevice;
            DontDestroyOnLoad(ARDeviceInstance);
        }
        else
        {
            Destroy(ARDevice);
        }

        if (SingletonInstance == null)
        {
            SingletonInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (arg0.name == "ARScene_3")
        {
            ARDeviceInstance.SetActive(true);
        }
    }
}
