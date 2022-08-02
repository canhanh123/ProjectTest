using System.Collections;
using UnityEngine;
using UnityEditor;
public class Filedofvieweditor : Editor
{[CustomEditor(typeof (Fliedofview))]
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnSceneGUI()
    {
        Fliedofview fow = (Fliedofview)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fow.transform.position, Vector3.up, Vector3.forward, 360, fow.viewRadius);
        Vector3 viewAngleA = fow.DirFromAngle(-fow.viewAngle / 2, false);
        Vector3 viewAngleB = fow.DirFromAngle(fow.viewAngle / 2, false);
        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleA * fow.viewRadius);
        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleB * fow.viewRadius);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
