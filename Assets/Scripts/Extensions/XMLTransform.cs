using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSystem
{
    /// <summary>
    /// Serializable transform handling.
    /// </summary>
    public class XMLTransform 
    {
        [XmlElement("Position")] public Vector3 position;
        [XmlElement("Rotation")] public Vector3 rotation;
        [XmlElement("Scale")] public Vector3 scale;

        // Constructor for XML Object.
        public XMLTransform(Transform t)
        {
            position = t.position;
            rotation = t.eulerAngles;
            scale = t.localScale;
        }

        // Transfering parameters from the XMLTransform object.
        public Transform LoadTransform(Transform t, XMLTransform xmlT)
        {
            t.localPosition = xmlT.position;
            t.rotation = Quaternion.Euler(xmlT.rotation);
            t.localScale = xmlT.scale;
            return t;
        }
    }
}
