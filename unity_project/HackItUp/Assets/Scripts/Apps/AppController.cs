using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{
    GameObject titleBar;
    GameObject workspace;

    RectTransform rt;
    public string appName;

    bool isMaximized = false;
    public Vector2 normalSizeMin, normalSizeMax;

    private void Awake()
    {
        rt = gameObject.GetComponent<RectTransform>();

        titleBar = transform.FindChild("TitleBar").gameObject;
        workspace = transform.FindChild("AppWorkspace").gameObject;

        titleBar.transform.FindChild("btnMaximize").GetComponent<Button>().onClick.AddListener(Maximize);
        titleBar.transform.FindChild("btnClose").GetComponent<Button>().onClick.AddListener(Close);

        normalSizeMin = new Vector2(205, 112);
        normalSizeMax = new Vector2(-205, -112);

        transform.localScale = new Vector3(1, 1, 1);
        rt.offsetMin = normalSizeMin;
        rt.offsetMax = normalSizeMax;

        GetComponentInChildren<TitleBarController>().txtAppName.text = appName;
    }    

    public void Maximize()
    {
        if (!isMaximized)
        {
            rt.offsetMin = Vector2.zero;
            rt.offsetMax = Vector2.zero;
            isMaximized = true;
        }
        else
        {
            rt.offsetMin = normalSizeMin;
            rt.offsetMax = normalSizeMax;
            isMaximized = false;
        }
    }

    public void Close()
    {
        Destroy(this.gameObject);
    }
}
