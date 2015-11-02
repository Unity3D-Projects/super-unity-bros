using UnityEngine;
using UnityEditor;
using System.Collections;

using LunarCore;

[CustomEditor(typeof(Map))]
public class MapEditor : BaseEditor<Map>
{
    protected override void OnSceneGUI()
    {
        Map map = target;
        Cell[,] cells = map.m_Cells;

        if (cells == null)
            return;

        float x = map.transform.position.x - 0.5f * Constants.CELL_WIDTH;
        float y = map.transform.position.y - 0.5f * Constants.CELL_HEIGHT;

        for (int i = 0; i < 14; ++i)
        {
            for (int j = 0; j < 16; ++j)
            {
                Cell cell = cells [i, j];
                if (cell != null)
                {
                    DebugEx.DrawRect(x + cell.x, y + cell.y, Constants.CELL_WIDTH, Constants.CELL_HEIGHT);
                }
            }
        }
    }
}