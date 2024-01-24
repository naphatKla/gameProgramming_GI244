using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Nation
{
    Neutral = 0,
    Britain,
    Pirates,
    France,
    Spain,
    Portuguese,
    Dutch
}

public class Faction : MonoBehaviour
{
    [SerializeField] private Nation nation;
    [Header("Resources")] [SerializeField] private int food;
    [SerializeField] private int wood;
    [SerializeField] private int gold;
    [SerializeField] private int stone;

    public Nation Nation => nation;
    public int Food { get => food; set => food = value;}
    public int Wood { get => wood; set => wood = value; }
    public int Gold { get => gold; set => gold = value; }
    public int Stone { get => stone; set => stone = value; }
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
