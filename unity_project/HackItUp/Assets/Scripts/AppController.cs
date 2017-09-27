using UnityEngine;

public class AppController : MonoBehaviour
{
    public void CloseThisApp()
    {
        Destroy(this.gameObject);
    }
}
