using UnityEngine;
using TMPro;

public class TooltipManager : MonoBehaviour
{
    public RectTransform toolTip;
    public static TooltipManager _intance;
    public TextMeshProUGUI content;

    [Header("Panel Blocking Settings")]
    public GameObject[] panelsToCheck; // Danh sách các panel cần kiểm tra
    public bool useStaticFlag = true; // Có sử dụng static flag không

    // Static flag để các script khác có thể set
    public static bool IsAnyPanelOpen = false;

    private void Awake()
    {
        if (_intance != null && _intance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _intance = this;
        }
    }

    private void Start()
    {
        //toolTip.pivot = new Vector2 (0,0);
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
        Vector2 mousePos = Input.mousePosition;

        // Nếu chuột ở bên phải màn hình → pivot sang phải
        if (transform.position.x > Screen.width / 2)
            toolTip.pivot = new Vector2(1, 1);
        else
            toolTip.pivot = new Vector2(0, 0);

        toolTip.position = mousePos;
    }

    public void SetandShowToolTips(string message)
    {
        // Kiểm tra xem có panel nào đang mở không
        if (ShouldBlockTooltip())
        {
            Debug.Log("Panel đang mở - Không hiển thị tooltip: " + message);
            return; // Không hiện tooltip
        }

        gameObject.SetActive(true);
        content.text = message;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        content.text = string.Empty;
    }

    /// <summary>
    /// Kiểm tra xem có nên block tooltip hay không
    /// </summary>
    private bool ShouldBlockTooltip()
    {
        // Phương pháp 1: Kiểm tra static flag
        if (useStaticFlag && IsAnyPanelOpen)
        {
            return true;
        }

        // Phương pháp 2: Kiểm tra danh sách panel
        if (panelsToCheck != null && panelsToCheck.Length > 0)
        {
            foreach (GameObject panel in panelsToCheck)
            {
                if (panel != null && panel.activeSelf)
                {
                    return true;
                }
            }
        }

        // Phương pháp 3: Tự động tìm tất cả GameObject có tag "Panel"
        GameObject[] allPanels = GameObject.FindGameObjectsWithTag("Panel");
        foreach (GameObject panel in allPanels)
        {
            if (panel != null && panel.activeSelf)
            {
                return true;
            }
        }

        return false; // Không có panel nào mở
    }

    /// <summary>
    /// Phương thức để các script khác gọi khi mở panel
    /// </summary>
    public static void SetPanelState(bool isOpen)
    {
        IsAnyPanelOpen = isOpen;

        // Ẩn tooltip ngay lập tức nếu panel được mở
        if (isOpen && _intance != null)
        {
            _intance.HideToolTip();
        }
    }

    /// <summary>
    /// Phương thức để force show tooltip (bỏ qua tất cả kiểm tra)
    /// </summary>
    public void ForceShowToolTip(string message)
    {
        gameObject.SetActive(true);
        content.text = message;
    }

    /// <summary>
    /// Kiểm tra xem tooltip có đang hiển thị không
    /// </summary>
    public bool IsTooltipVisible()
    {
        return gameObject.activeSelf;
    }
}