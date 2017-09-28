using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{
    RectTransform rt;
    GameObject titleBar;
    string appName;

    private void Awake()
    {
        this.Initialize();
    }

    protected void Initialize()
    {
        rt = gameObject.GetComponent<RectTransform>();

        titleBar = transform.FindChild("TitleBar").gameObject;

        titleBar.transform.FindChild("btnMaximize").GetComponent<Button>().onClick.AddListener(Maximize);
        titleBar.transform.FindChild("btnClose").GetComponent<Button>().onClick.AddListener(CloseThisApp);
    }

    protected void ChangeAppName(string newName)
    {
        appName = newName;
        GetComponentInChildren<TitleBarController>().txtAppName.text = newName;
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
