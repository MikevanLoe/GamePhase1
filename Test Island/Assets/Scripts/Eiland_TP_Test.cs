using UnityEngine;

public class Eiland_TP_Test : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        //Application.LoadLevel("Eiland_grootst");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eiland_grootst");
    }
}
