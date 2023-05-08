// Bibliotheken importieren
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Klasse anlegen (erbt von Klasse MonoBehavior)
public class MovingPlatform : MonoBehaviour
{
    // Eine AnimationCurve, die die Bewegung der Plattform beeinflusst
    public AnimationCurve curve;

    // Die Startposition der Plattform
    Vector3 startPosition;

    // Die Plattform kann folgende Höhe erreichen
    public float height = 1;

    // Die Plattform bewegt sich mit folgender Geschwindigkeit
    public float speed = 1;

    // Am Anfang beträgt der Wert von 'startPosition', den Wert von 'transfor.position'
    void Start()
    {
        startPosition = transform.position;
    }

    // Funktion, die bei jedem Frame ausgeführt wird
    void Update()
    {
        // Die Position der Plattform wird berechnet
        transform.position = startPosition + new Vector3(0, curve.Evaluate(Time.time * speed) * height, 0);
    }
}
