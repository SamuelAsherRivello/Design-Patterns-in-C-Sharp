//The Product class is the class that will be created by the Builder
using UnityEngine;

public class Product : MonoBehaviour {
    
    private delegate void OnActivate();
    private OnActivate onActivate;
    public void Activate() {
        onActivate();
    }

    public void AddActivateListener(OnActivate onActivate) {
        this.onActivate += onActivate;
    }
}