//using UnityEngine;
//using UnityEngine.UI;

//public class MiniGameBanner : MonoBehaviour
//{
//    public GameObject Banner;
//    public GameObject toolTips;

//    public void ShowBanner()
//    {
//        if (Banner != null)
//        {
//            // Check if the banner is active and toggle its state
//            bool isActive = Banner.activeSelf;

//            // If the banner is active, deactivate it; if it's inactive, activate it
//            Banner.SetActive(!isActive);

//            if (!isActive) // Banner đang tắt -> sẽ được bật
//            {
//                TooltipManager._intance.HideToolTip();
//                Debug.Log("Banner đã mở - Tooltip đã được ẩn");
//            }
//            else
//            {
//                Debug.Log("Banner đã đóng");
//            }
//        }
//    } 
//}

using UnityEngine;
using UnityEngine.UI;

public class MiniGameBanner : MonoBehaviour
{
    public GameObject Banner;

    public void ShowBanner()
    {
        if (Banner != null)
        {
            bool isActive = Banner.activeSelf;
            Banner.SetActive(!isActive);

            if (!isActive) // Banner được bật
            {
                // Thông báo TooltipManager rằng panel đã mở
                TooltipManager.SetPanelState(true);
                Debug.Log("Banner đã mở - Tooltip đã được vô hiệu hóa");
            }
            else // Banner được tắt
            {
                // Thông báo TooltipManager rằng panel đã đóng
                TooltipManager.SetPanelState(false);
                Debug.Log("Banner đã đóng - Tooltip được kích hoạt lại");
            }
        }
    }

    public void OpenBanner()
    {
        if (Banner != null && !Banner.activeSelf)
        {
            Banner.SetActive(true);
            TooltipManager.SetPanelState(true);
            Debug.Log("Banner đã mở - Tooltip đã được vô hiệu hóa");
        }
    }

    public void CloseBanner()
    {
        if (Banner != null && Banner.activeSelf)
        {
            Banner.SetActive(false);
            TooltipManager.SetPanelState(false);
            Debug.Log("Banner đã đóng - Tooltip được kích hoạt lại");
        }
    }
}
