using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class Win : MonoBehaviour
{
    private const string MENU = "Menu";
    private void OnCollisionEnter2D(Collision2D collision) => SceneManager.LoadScene(MENU);

}
