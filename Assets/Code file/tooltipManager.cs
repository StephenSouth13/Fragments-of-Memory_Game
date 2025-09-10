using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class tooltipManager : MonoBehaviour
{
    public static tooltipManager Instance;

    [Header("Tooltip UI")]
    public GameObject tooltipPanel;
    public TextMeshProUGUI tooltipText;
    public RectTransform tooltipRect;

    [Header("Settings")]
    public float followSpeed = 5f;
    public Vector2 offset = new Vector2(10, 10);

    private Camera uiCamera;
    private bool isVisible = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        uiCamera = Camera.main;
        if (tooltipPanel != null)
            tooltipPanel.SetActive(false);
    }

    void Update()
    {
        if (isVisible)
        {
            UpdateTooltipPosition();
        }
    }

    public void ShowTooltip(string text)
    {
        if (tooltipPanel == null || tooltipText == null) return;

        tooltipText.text = text;
        tooltipPanel.SetActive(true);
        isVisible = true;

        // Resize tooltip to fit text
        LayoutRebuilder.ForceRebuildLayoutImmediate(tooltipRect);
    }

    public void HideTooltip()
    {
        if (tooltipPanel != null)
            tooltipPanel.SetActive(false);
        isVisible = false;
    }

    private void UpdateTooltipPosition()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 targetPos = mousePos + offset;

        // Keep tooltip within screen bounds
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        float tooltipWidth = tooltipRect.rect.width;
        float tooltipHeight = tooltipRect.rect.height;

        if (targetPos.x + tooltipWidth > screenSize.x)
            targetPos.x = mousePos.x - tooltipWidth - offset.x;

        if (targetPos.y + tooltipHeight > screenSize.y)
            targetPos.y = mousePos.y - tooltipHeight - offset.y;

        tooltipRect.position = Vector2.Lerp(tooltipRect.position, targetPos, followSpeed * Time.deltaTime);
    }
}
