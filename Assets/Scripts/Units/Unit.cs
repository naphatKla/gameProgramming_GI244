using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public enum UnitState
{
    Idle,
    Move,
    Attack,
    Die
}

public class Unit : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private string unitName;
    [SerializeField] private Sprite unitPic;
    [SerializeField] private int curHP;
    [SerializeField] private int maxHP = 100;
    [SerializeField] private int moveSpeed = 5;
    [SerializeField] private int minWpnDamage;
    [SerializeField] private int maxWpnDamage;
    [SerializeField] private int armour;
    [SerializeField] private float visualRange;
    [SerializeField] private UnitState state;
    [SerializeField] private Faction faction;
    [SerializeField] private GameObject selectionVisual;
    

    public int ID { get => id; set => id = value; }
    public string UnitName => unitName;
    public Sprite UnitPic => unitPic;
    public int CurHP { get => curHP; set => curHP = value; }
    public int MaxHP => maxHP;
    public int MoveSpeed => moveSpeed;
    public int MinWpnDamage => minWpnDamage;
    public int MaxWpnDamage => maxWpnDamage;
    public int Armour => armour;
    public float VisualRange => visualRange;
    public UnitState State { get => state; set => state = value; }
    public Faction Faction => faction;
    public GameObject SelectionVisual => selectionVisual;

    private void Start()
    {
    }

    private void Update()
    {
    }
    
    public void ToggleSelectionVisual(bool flag)
    {
        if (selectionVisual != null)
            selectionVisual.SetActive(flag);
    }
}