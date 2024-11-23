
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static MusicScript instance;
    // Start is called before the first frame update
    private void Awake(){
        if (instance ==null){
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else{
            Destroy (gameObject);
        }
    }
}
