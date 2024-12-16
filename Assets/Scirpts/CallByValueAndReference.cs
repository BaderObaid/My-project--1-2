using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {
            
            int a = 2;
            int b = 4;

            
            Debug.Log($"Before CallByValue: a = {a}");
            CallByValue(a);
            Debug.Log($"After CallByValue: a = {a}");

            
            Debug.Log($"Before CallByReference: b = {b}");
            CallByReference(ref b);
            Debug.Log($"After CallByReference: b = {b}");

            
            int c;
            AssignUsingOut(out c);
            Debug.Log($"After AssignUsingOut: c = {c}");
        }

       
        void CallByValue(int value)
        {
            value += 10;
            Debug.Log($"Inside CallByValue: value = {value}");
        }

       
        void CallByReference(ref int value)
        {
            value += 10;
            Debug.Log($"Inside CallByReference: value = {value}");
        }

        
        void AssignUsingOut(out int value)
        {
            value = 20; 
            Debug.Log($"Inside AssignUsingOut: value = {value}");
        }
    }
}