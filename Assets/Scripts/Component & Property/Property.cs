using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Property : MonoBehaviour
{
    public static Property property;
    public GameObject nodeObject, effect;
    public Transform nodeParent;
    public Sprite[] nodeSprites;
    public BoxCollider2D[] boxCollider2Ds;
    public BoxCollider2D[] rowsCheckBoxCollider2Ds;
    public int nodeRow1Amount { get; set; } = 0;
    public int nodeRow2Amount { get; set; } = 0;
    public int nodeRow3Amount { get; set; } = 0;

    // row-1
    public static string _row1column1{ get; set; } = string.Empty;
    public static string _row1column2{ get; set; } = string.Empty;
    public static string _row1column3{ get; set; } = string.Empty;
    // row-2
    public static string _row2column1{ get; set; } = string.Empty;
    public static string _row2column2{ get; set; } = string.Empty;
    public static string _row2column3{ get; set; } = string.Empty;
    // row-3
    public static string _row3column1{ get; set; } = string.Empty;
    public static string _row3column2{ get; set; } = string.Empty;
    public static string _row3column3{ get; set; } = string.Empty;
    
    public Transform[] row1, row2, row3; 

    public Transform targetObjectInstantRow1, targetObjectInstantRow2, targetObjectInstantRow3;

    public Text coinBetText, creditText, coinsWinText;
    public int coinsBet, credit = 29943, coinsWin;
    public Button decreaseButton, increaseButton;

    void Awake()
    {
        property = GetComponent<Property>();
    }
}
