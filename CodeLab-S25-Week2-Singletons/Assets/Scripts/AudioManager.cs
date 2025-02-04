using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public static AudioManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //start of the singleton to keep the audio not start in a new place on repeat. 
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this);
            
            audioSource = GetComponent<AudioSource>();
        
            audioSource.clip = audioClip;
    
            audioSource.Play();
        }
        else
        {
            Destroy(gameObject);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        //basic reset command
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
