using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


[CreateAssetMenu(fileName = "cat", menuName = "creat new cat")]
public class Category : ScriptableObject
{
    public new string  Name;
    [SerializeField] Sprite Logo;
    public Sprite Logotext;


}
