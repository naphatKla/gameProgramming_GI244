using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] private GameObject selectionmaker;
    public GameObject SelectionMaker { get { return selectionmaker; } }
    
    [SerializeField] private TextMeshProUGUI unitCountText;
    [SerializeField] private TextMeshProUGUI foodText;
    [SerializeField] private TextMeshProUGUI woodText;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private TextMeshProUGUI stoneText;
    
    public static MainUI instance;
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateAllResource(Faction faction)
    {
        unitCountText.text = faction.AliveUnits.Count.ToString();
        foodText.text = faction.Food.ToString();
        woodText.text = faction.Wood.ToString();
        goldText.text = faction.Gold.ToString();
        stoneText.text = faction.Stone.ToString();
    }
}
