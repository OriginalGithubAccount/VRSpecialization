using UnityEngine.XR.Interaction.Toolkit;

public class HandHold : XRBaseInteractable
{
    protected Weapon weapon;

    public void Setup(Weapon weapon)
    {
        this.weapon = weapon;
    }

    protected override void Awake()
    {
        base.Awake();
        onSelectEntered.AddListener(Grab);
        onSelectExited.AddListener(Drop);
    }

    private void OnDestroy()
    {
        onSelectEntered.RemoveListener(Grab);
        onSelectExited.RemoveListener(Drop);
    }

    protected virtual void BeginAction(XRBaseInteractor interactor)
    {
        // Empty
    }

    protected virtual void EndAction(XRBaseInteractor interactor)
    {
        // Empty
    }

    protected virtual void Grab(XRBaseInteractor interactor)
    {

    }

    protected virtual void Drop(XRBaseInteractor interactor)
    {

    }

    private void TryToHideHand(XRBaseInteractor interactor, bool hide)
    {

    }

    public void BreakHold(XRBaseInteractor interactor)
    {

    }
}
