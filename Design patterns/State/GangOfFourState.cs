namespace Design_patterns.State
{
    // var sw = new Switch();
    //         
    // sw.On();
    // sw.Off();
    // sw.Off();


    // public class Switch
    // {
    //     public State state = new OffState();
    //
    //     public void On()
    //     {
    //         state.On(this);
    //     }
    //
    //     public void Off()
    //     {
    //         state.Off(this);
    //     }
    // }
    //
    // public class OffState : State
    // {
    //     public OffState()
    //     {
    //         Console.WriteLine("Light turned off");
    //     }
    //
    //     public override void On(Switch sw)
    //     {
    //         sw.state = new OnState();
    //     }
    // }
    //
    // public class OnState : State
    // {
    //     public OnState()
    //     {
    //         Console.WriteLine("Light turned on");
    //     }
    //
    //     public override void Off(Switch sw)
    //     {
    //         sw.state = new OffState();
    //     }
    // }
    //
    // public abstract class State
    // {
    //     public virtual void On(Switch sw)
    //     {
    //         Console.WriteLine("Light is already on");
    //     }
    //
    //     public virtual void Off(Switch sw)
    //     {
    //         Console.WriteLine("Light is already off");
    //     }
    // }
}