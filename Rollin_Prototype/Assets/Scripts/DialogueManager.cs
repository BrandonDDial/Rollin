using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {
    
    private Queue<string> sentences;

            // use this for initialization
    void Start() {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
