using UnityEngine;

public class Panel : MonoBehaviour
{
    public void Quit() {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
