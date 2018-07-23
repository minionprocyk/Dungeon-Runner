using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour {
    /*
    void Start()
    {
        //TODO: set these to a normal assigned value. HARD CODE THIS SHIT FOR NOW
        Player.BaseHealth.Value = 100;
        Player.BaseEnergy.Value = 100;
        Level.Value = 0;
        Experience.Value = 0;
        ExpToNextLevel.Value = 1;
        Health.Value = BaseHealth.Value;
        Energy.Value = BaseEnergy.Value;
    }

    void Update()
    {
        Exp();
        //TODO: add modifiers, regen, etc
        if (Input.GetKeyDown(KeyCode.E))
        {
            Experience.Value += 1;
            print("Rewarding exp");
        }
    }

    void LevelUp()
    {
        Level.Value += 1;
        Experience.Value = Experience.Value - ExpToNextLevel.Value;
        ExpToNextLevel.Value = Level.Value;// 100 * (Level.Value + 1) * (Level.Value + 1);

        //TODO: rewards
        switch (Level.Value)
        {
            case 1:
                BaseHealth.Value += 25;
                print("Congratulations! Level 1");
                break;
            case 2:
                BaseEnergy.Value += 5;
                print("Congratulations! Level 2");
                break;
            case 3:
                BaseHealth.Value += 9875;
                print("Congratulations! Level 3. You are now much stronger");
                break;

        }
    }

    void Exp()
    {
        if (Experience.Value > ExpToNextLevel.Value)
        {
            LevelUp();
        }
    }
    */
}
