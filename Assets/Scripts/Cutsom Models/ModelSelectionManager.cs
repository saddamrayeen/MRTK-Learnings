using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelectionManager : MonoBehaviour
{
    [SerializeField] GameObject lowPolyModel, highPolyModel;
    // Start is called before the first frame update
    public void showLowPolyModel()
    {
        lowPolyModel.SetActive(true);
    }
    public void showHighPolyModel()
    {
        highPolyModel.SetActive(true);
    }
    public void RemoveAllModels()
    {
        lowPolyModel.SetActive(false);
        highPolyModel.SetActive(false);
    }
}
