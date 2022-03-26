using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance.gameObject);
    }

    public SaveLoad _saveLoad;
    public Scene _scene;
    public Audio _audio;
    public Progress _progress;
}
