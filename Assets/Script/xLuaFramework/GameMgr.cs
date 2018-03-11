using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {

    private void Awake()
    {
        gameObject.AddComponent<LuaMgr>();
    }

    // Use this for initialization
    void Start () {
        LuaMgr.instance.DoString("require 'Resoure/lua/luatest'");
	}
	
}
