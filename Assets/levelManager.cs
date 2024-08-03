using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public Collider2D[] colliders;
    public Vector2 size = new Vector2(50,50);
    public Vector2 position = new Vector2(0f, 0f);
    public float boxAngle = 0f;
    public LayerMask layermask;
    public int enemies = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        colliders = Physics2D.OverlapBoxAll(position, size, boxAngle, layermask);
        
        foreach (Collider2D nearbyObject in colliders)
        {
            if(nearbyObject.CompareTag("Enemy")){
                enemies++;
            }
        }

        if(enemies <= 0){
            LoadNextLevel();
        }    

        enemies = 0;
    }

    void LoadNextLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
