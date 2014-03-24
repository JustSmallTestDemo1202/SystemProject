using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class GamePlay : GameScreen
{
	// by luxiaohen for test
    public GamePlay()
    {
    }

    public override void OnEnter(object param)
    {
        base.OnEnter(param);
    }


    public override void OnGUI()
    {
        base.OnGUI();

        GUILayout.BeginArea(new Rect(Screen.width / 2 - 200, 200, 400, 100));

        if (GUILayout.Button("Quit"))
        {
            Framework.ScreenManager.ChangeScreen(typeof(MainMenu));
        }

        GUILayout.EndArea();
    }
}

