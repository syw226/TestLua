using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaMgr : MonoSingleton<LuaMgr>
{
    /// <summary>
    /// 全局的xlua引擎
    /// </summary>
    public static LuaEnv luaEnv;
    private void Awake()
    {
        luaEnv = new LuaEnv();

        luaEnv.DoString(string.Format("package.path = '{0}/?.lua'", Application.dataPath));
    }

    public void DoString(string str)
    {
        luaEnv.DoString(str);
    }

    // Use this for initialization
    void Start () {
		
	}

    protected override void Init()
    {
        
    }

    protected override void DisInit()
    {
        
    }
}
