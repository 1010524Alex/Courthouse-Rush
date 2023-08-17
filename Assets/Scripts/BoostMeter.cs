using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoostMeter : MonoBehaviour
{
    public Slider Boost;
    private int MaxBoost = 2000;
    private int CurrentBoost;
    public static BoostMeter Instance;
    // Start is called before the first frame update
    
     private void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        CurrentBoost = MaxBoost;
        Boost.maxValue = MaxBoost;
        Boost.value = MaxBoost;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoostUse(int amount)
    {
        if(CurrentBoost - amount >= 0f)
        {
            CurrentBoost -= amount;
            Boost.value = CurrentBoost;
          
        }
    }

    private IEnumerable RegenBoost()
    {
        yield return new WaitForSeconds(2);
        while(CurrentBoost < MaxBoost)
        {
            CurrentBoost += MaxBoost / 2000;
            Boost.value += CurrentBoost;
            yield return new WaitForSeconds(0.1f);
        }
    }

   
}
