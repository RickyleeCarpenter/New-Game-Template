using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    private string currentScene = "Startup";

    [Header("Scene Names")]
    [SerializeField] private string titleScreen = "TitleScreen";
    [SerializeField] private string ending = "Ending";
    [SerializeField] private string gameOver = "GameOver";
    [SerializeField] private string[] levelsInOrder;
    [SerializeField] private string[] secrets;

    [Header("DEBUG")]
    [Tooltip("Insert a scene/level to load, then use the appropriate context menu")]
    [SerializeField] private int goToLevel;
    [SerializeField] private string goToScene;

    [ContextMenu("GoToTitleScreen")]
    public void GoToTitleScreen() { GoToScene(titleScreen); }

    [ContextMenu("GoToLevel")]
    private void DebugGoToLevel() 
    {
        if (goToLevel == 0 || levelsInOrder.Length == 0 || goToLevel > levelsInOrder.Length)
            return;

        GoToLevel(goToLevel);

    } // Debug Method

    [ContextMenu("GoToNextLevel")]
    public void GoToNextLevel()
    {
        for (int i = 0; i < levelsInOrder.Length; i++) 
        {
            if(i == levelsInOrder.Length - 1)
            {
                GoToEnding();
                return;
            }

            if (levelsInOrder[i] == currentScene)
            {
                GoToLevel(i + 1);
                return;
            }
        }
    }

    public void GoToLevel(int level)
    {
        GoToScene(levelsInOrder[level - 1]);
    }

    [ContextMenu("GoToNextLevel")]
    public void GoToEnding() { GoToScene(ending); }

    [ContextMenu("GoToGameOver")]
    public void GoToGameOver() { GoToScene(gameOver); }

    [ContextMenu("GoToScene")]
    private void DebugGoToScene() 
    {
        if (goToScene == titleScreen || goToScene == ending || goToScene == gameOver)
            GoToScene(goToScene);
        else
        {
            foreach (string level in levelsInOrder)
            {
                if (goToScene == level)
                {
                    GoToScene(goToScene);
                    return;
                }
            }

            foreach (string secret in secrets)
            {
                if (goToScene == secret)
                {
                    GoToScene(goToScene);
                    return;
                }
            }
        }

    } // Debug Method

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        currentScene = sceneName;
    }
}
