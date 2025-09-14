using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void play()
    {
        SceneManager.LoadScene(0); //bên trong load scene là số thứ tự của scene game add vô. Lưu ý đánh số thứ tự đúng theo thứ tự
        animator.SetTrigger("FadedScreen");
        Debug.Log("animator use");
    }

    public void cancel()
    {
        ObjectButton.instance.CloseBanner();
        Debug.Log("Banner Close");
    }
}
