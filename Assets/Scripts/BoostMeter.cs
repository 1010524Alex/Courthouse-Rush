using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostMeter : MonoBehaviour
{
    public Slider Boost;
    private int MaxBoost = 2000;
    public int CurrentBoost;
    public static BoostMeter Instance;
    private WaitForSeconds RechargeValue = new WaitForSeconds(0.1f);
    private Coroutine Recharge;
    
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
        if(CurrentBoost - amount >= 0)
        {
            CurrentBoost -= amount;
            Boost.value = CurrentBoost;
            if(Recharge != null)
            {
                StopCoroutine(Recharge);
            }
            Recharge = StartCoroutine(RegenBoost());
          
        }
        else
        {
            Debug.Log("Boost insufficient");
        }
    }

    private IEnumerator RegenBoost()
    {
        yield return new WaitForSeconds(0);
        while(CurrentBoost < MaxBoost)
        {
            CurrentBoost += MaxBoost / 20;
            Boost.value = CurrentBoost;
            yield return RechargeValue;
        }
        Recharge = null;

    }

   
}
