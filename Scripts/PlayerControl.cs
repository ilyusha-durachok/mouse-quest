using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Character character;
    SpriteAnimation spriteAnimation;
    Attacker attacker;

    // Start is called before the first frame update
    void Start()
    {
        spriteAnimation = GetComponent<SpriteAnimation>();
        character = GetComponent<Character>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!character.busy) {
            character.MoveRelative(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))); 

            if (Input.GetMouseButtonDown(0)) {
                attacker.Attack(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            }
        }
    }
}
