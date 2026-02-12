using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{
    public static FlagManager Instance;

    private Dictionary<string, bool> gameFlags = new Dictionary<string, bool>();

    void Awake()
    {
        Instance = this;
    }

    public void SetFlag(string flagName, bool value)
    {
        gameFlags[flagName] = value;
    }

    public bool GetFlag(string flagName)
    {
        if (gameFlags.ContainsKey(flagName))
            return gameFlags[flagName];

        return false;
    }
}
