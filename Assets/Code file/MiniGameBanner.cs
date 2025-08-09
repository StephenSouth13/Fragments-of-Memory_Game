using UnityEngine;
using UnityEngine.UI;

public class MiniGameBanner : MonoBehaviour
{
    public GameObject Banner;

    public void ShowBanner()
    {
        if (Banner != null)
        {
            // Check if the banner is active and toggle its state
            bool isActive = Banner.activeSelf;

            // If the banner is active, deactivate it; if it's inactive, activate it
            Banner.SetActive(!isActive);

            Debug.Log("Banner đã mở");
        }
    }
}
