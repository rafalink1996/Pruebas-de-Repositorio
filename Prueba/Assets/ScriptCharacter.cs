using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCharacter : MonoBehaviour
{
    bool mergeConflict;
    bool NoMeEnredo;
    // Start is called before the first frame update
    void Start()
    {
        if (mergeConflict && NoMeEnredo)
        {
            ResolveConflicts();
        } else 
        {
            Panic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResolveConflicts()
    {
        //resolve all merge conflicts
    }
    void Panic()
    {

    }
}
