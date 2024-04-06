using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Advertisements.Instance.SetUserConsent(true);
        Advertisements.Instance.Initialize();
    }

}
