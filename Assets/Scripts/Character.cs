using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected int hp;
    protected int mp;
    private Vector2 coords;

    public void useAttack(Attack a) {
        //go through list of attack offsets and damage the enemy on that tile if it exists.
        foreach ((Vector2 coord, int dmg) att in a.attackOffsets) {
            GameManager.Instance.damageCharacterOnBoard(a.enemy, att.dmg, (int) att.coord.x, (int) att.coord.y);
        }
    }
    public void move(int xOffset, int yOffset) {
        coords.x = coords.x + xOffset;
        coords.y = coords.y + yOffset;
        //add reference to new tile
        GameManager.Instance.moveCharacterOnBoard(this, (int) coords.x, (int) coords.y);
    }
    public Vector2 getPos() {
        return coords;
    }
    public void takeDamage(int dmg) {
        hp -= dmg;
        if (hp <= 0) {
            die();
        }
    }
    public virtual void die() {
        //delete reference from tile
        GameManager.Instance.deleteCharacterFromBoard(this);
    }
}


public class Attack {
    public bool enemy;
    public string attackName;
    public (Vector2 coord, int dmg)[] attackOffsets;

    public Attack(string name, bool enemy, (Vector2 coord, int dmg)[] attackOffsets) {
        this.attackOffsets = attackOffsets;
        attackName = name;
        this.enemy = enemy;
    }
}