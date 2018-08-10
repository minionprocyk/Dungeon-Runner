using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour {

    public Player Player;

    void Update()
    {
        Exp();
        //TODO: add modifiers, regen, etc
        if (Input.GetKeyDown(KeyCode.E)) //use Unity InputManager
        {
            Player.Experience += 1;
            print("Rewarding exp");
        }
    }

    void LevelUp()
    {
        Player.LevelUp();
        Player.Experience = Player.Experience - Player.ExpToNextLevel;
        Player.ExpToNextLevel +=10;// 100 * (Level.Value + 1) * (Level.Value + 1);

        //TODO: rewards
        /*
        switch (Player.Level)
        {
            case 1:
                Player.MaxHealth += 25;
                print("Congratulations! Level 1");
                break;
            case 2:
                Player.Energy += 5;
                print("Congratulations! Level 2");
                break;
            case 3:
                Player.Health += 9875;
                print("Congratulations! Level 3. You are now much stronger");
                break;

        }
        */
    }

    void Exp()
    {
        if (Player.Experience >= Player.ExpToNextLevel)
        {
            LevelUp();
        }
    }
    
}
