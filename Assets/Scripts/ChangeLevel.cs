using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [Header("Nezabudni nasledovnu scenu pridat do build settings!")]
    [Space]
    [Tooltip("nazov levelu, na ktory sa ma prepnut")]
    [SerializeField] private string nextLevel;


    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextLevel);
    }
}
