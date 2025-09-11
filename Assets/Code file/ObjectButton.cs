using UnityEngine;

public class ObjectButton : MonoBehaviour
{
    public static ObjectButton instance;
    public MiniGameBanner miniGameBanner;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        if (miniGameBanner == null)
        {
            miniGameBanner = Object.FindFirstObjectByType<MiniGameBanner>();
        }
    }
    private void openBanner()
    {
        if (miniGameBanner != null)
        {
            miniGameBanner.Banner.SetActive(true);
        }
        else
        {
            Debug.LogWarning("MiniGameBanner not found!");
        }

    }

    private void OnMouseUpAsButton()
    {
        openBanner();
        Debug.Log("ObjectButton clicked!");
    }

    public void CloseBanner()
    {
        if (miniGameBanner != null && miniGameBanner.Banner.activeSelf)
        {
            miniGameBanner.Banner.SetActive(false);
            
        }
    }
}
