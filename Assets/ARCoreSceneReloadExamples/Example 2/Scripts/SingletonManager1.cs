using UnityEngine;
using UnityEngine.SceneManagement;

public class SingletonManager1 : MonoBehaviour
{

    public static SingletonManager1 SingletonInstance { get; set; }
    public static GameObject ARDeviceInstance { get; set; }
    public GameObject ARDevice;

    // Start is called before the first frame update
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

    void OnSceneLoaded(Scene arg0, LoadSceneMode loadSceneMode)
    {
        if (SceneManager.GetActiveScene().name == "StartScene_2")
        {
            ARDeviceInstance.SetActive(false);
        }
        else
        {
            ARDeviceInstance.SetActive(true);
        }

    }
}
