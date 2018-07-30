using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour {

    public Player Player;

    void Update()
    {
        Exp();
        //TODO: add modifiers, regen, etc
        if (Input.GetKeyDown(KeyCode.E))
        {
            Player.Experience.RuntimeValue += 1;
            print("Rewarding exp");
        }
    }

    void LevelUp()
    {
        Player.Level.RuntimeValue += 1;
        Player.Experience.RuntimeValue = Player.Experience.RuntimeValue - Player.ExpToNextLevel.RuntimeValue;
        Player.ExpToNextLevel.RuntimeValue = Player.Level.RuntimeValue;// 100 * (Level.Value + 1) * (Level.Value + 1);

        //TODO: rewards
        switch (Player.Level.RuntimeValue)
        {
            case 1:
                Player.Health.RuntimeValue += 25;
                print("Congratulations! Level 1");
                break;
            case 2:
                Player.Energy.RuntimeValue += 5;
                print("Congratulations! Level 2");
                break;
            case 3:
                Player.Health.RuntimeValue += 9875;
                print("Congratulations! Level 3. You are now much stronger");
                break;

        }
    }

    void Exp()
    {
        if (Player.Experience.RuntimeValue >= Player.ExpToNextLevel.RuntimeValue)
        {
            LevelUp();
        }
    }
    
}
