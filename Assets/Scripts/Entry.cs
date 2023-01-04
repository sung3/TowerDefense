using LuaInterface;
using UnityEngine;

public class Entry : MonoBehaviour
{
    LuaState lua = null;

    void Start () 
    {
        lua = new LuaState();                
        lua.Start();        

        string fullPath = Application.dataPath + "\\Lua";
        lua.AddSearchPath(fullPath);
        
        lua.Require("Entry");
    }
    
    void OnApplicationQuit()
    {
        lua.Dispose();
        lua = null;
    }
}
