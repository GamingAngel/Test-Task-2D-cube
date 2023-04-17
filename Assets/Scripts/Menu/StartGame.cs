using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private const string LEVELNAME = "Level";

    public void OnStartGame() => SceneManager.LoadScene(LEVELNAME);
}
