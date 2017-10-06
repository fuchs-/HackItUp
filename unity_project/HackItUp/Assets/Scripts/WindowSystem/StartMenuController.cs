using UnityEngine;

public class StartMenuController : MonoBehaviour
{
    public GameObject workspace;

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void BtnCreditsPressed()
    {
        Hide();

        if (!workspace.transform.FindChild("CreditsApp"))
        {
            GameObject app = Instantiate(Resources.Load<GameObject>("Apps/CreditsApp"), workspace.transform);
            app.name = "CreditsApp";
        }
        else
        {
            Debug.LogWarning("There can't be more than one CreditsApp instances openned at one time");
        }
    }
}
