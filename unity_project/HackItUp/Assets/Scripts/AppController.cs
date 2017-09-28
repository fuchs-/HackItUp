using UnityEngine;

public class AppController : MonoBehaviour
{
    string appName;
    string windowTitle;

    RectTransform rt;


    private void Awake()
    {
        rt = gameObject.GetComponent<RectTransform>();
    }

    

    public void Maximize()
    {
        Vector2 v = Vector2.zero;
        rt.offsetMin = v;
        rt.offsetMax = v;
    }

    public void CloseThisApp()
    {
        Destroy(this.gameObject);
    }
}
