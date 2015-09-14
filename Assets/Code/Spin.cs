using UnityEngine;
using System.Collections;

public class Spin : Pickup {

    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
        //voeg hier code toe zo dat de speler zijn score omhoog gaat
        _GO.CoinsCollected();
        _GO.goRotate = true;

        Destroy(this.gameObject);
    }
}
