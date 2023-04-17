using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class Lose : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
