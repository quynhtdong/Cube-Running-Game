using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleted : MonoBehaviour
{
   void LoadNextLevel(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
