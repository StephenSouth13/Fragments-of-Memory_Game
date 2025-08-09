using UnityEngine;

public class ObjectButton : MonoBehaviour
{
    public MiniGameBanner miniGameBanner;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CloseBanner();
        }
    }
    private void CloseBanner()
    {
        if (miniGameBanner != null && miniGameBanner.Banner.activeSelf)
        {
            miniGameBanner.Banner.SetActive(false);
            Debug.Log("Banner đã đóng");
        }
    }
}
