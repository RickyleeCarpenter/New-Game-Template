using UnityEngine;

public class Startup : MonoBehaviour
{
    public bool RestartData;

    private void Start()
    {
        if (RestartData)
            GameManager.instance._saveLoad.DeleteSaveData();

        GameManager.instance._saveLoad.Initialise();

        GameManager.instance._scene.GoToTitleScreen();
    }
}
