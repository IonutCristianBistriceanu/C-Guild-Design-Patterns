
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns
{
    class Program
    {
        //private static Dictionary<State, List<(Trigger, State)>> rules =
        //    new Dictionary<State, List<(Trigger, State)>>
        //    {
        //        [State.OffHook] = new List<(Trigger, State)>
        //    {
        //        (Trigger.CallDialed, State.Connecting)
        //    },
        //        [State.Connecting] = new List<(Trigger, State)> { (Trigger.HungUp, State.OffHook),

        //    (Trigger.CallDialed, State.Connected)},
        //        [State.Connected] = new List<(Trigger, State)>
        //        {
        //            (Trigger.LeftMessage, State.OffHook),
        //            (Trigger.HungUp, State.OffHook),
        //            (Trigger.PlacedOnHold, State.OnHold)
        //        },
        //        [State.OnHold] = new List<(Trigger, State)>
        //        {
        //            (Trigger.TakenOffHold, State.Connected),
        //            (Trigger.HungUp, State.OffHook)
        //        }
        //    };

        static void Main(string[] args)
        {
            //State machines as per the gang of four implementation
            //Modeling a light switch (2 states on / off)
            //In the classic implementation each state is a class

            //var ls = new Switch();
            //ls.On();
            //ls.Off();
            //ls.Off();

            //Handmade state machine
            //Bunch of states and transitions with orchestrator
            //Model a phone (states and triggers)


            //Switch based state machine short example in a more simple way with no transitions
            //Model a combination lock

            string code = "1234";
            var state = State.Locked;

            var entry = new StringBuilder();

            while (true)
            {
                switch (state)
                {
                    case State.Locked:
                        entry.Append(Console.ReadKey().KeyChar);

                        if(entry.ToString() == code)
                        {
                            state = State.Unlocked;
                            break;
                        }

                        if (!code.StartsWith(entry.ToString()))
                        {
                            state = State.Failed;
                        }

                        break;
                    case State.Failed:
                        Console.CursorLeft = 0;
                        Console.WriteLine("Failed");
                        entry.Clear();
                        state = State.Locked;
                        break;
                    case State.Unlocked:
                        Console.CursorLeft = 0;
                        Console.WriteLine("Unlocked");
                        return;
                }


                //var state = State.OffHook;
                //    while (true)
                //    {
                //        System.Console.WriteLine($"The phone is currently {state}");
                //        System.Console.WriteLine("Select a trigger");

                //        for (int i = 0; i < rules[state].Count; i++)
                //        {
                //            var (t, _) = rules[state][i];
                //            System.Console.WriteLine($"{i}. {t}");
                //        }

                //        int input = int.Parse(Console.ReadLine());
                //        var (_, s) = rules[state][input];
                //        state = s;
                //    }
            }
        }

        //public class Switch
        //{
        //    public State state = new OffState();
        //    public void On() { state.On(this); }
        //    public void Off() { state.Off(this); }
        //}

        //public class OffState : State
        //{
        //    public OffState()
        //    {
        //        System.Console.WriteLine("Light turned off");
        //    }

        //    public override void On(Switch sw)
        //    {
        //        System.Console.WriteLine("Turning light on");
        //        sw.state = new OnState();
        //    }
        //}

        //public class OnState : State
        //{
        //    public OnState()
        //    {
        //        System.Console.WriteLine("Light turned on");
        //    }

        //    public override void Off(Switch sw)
        //    {
        //        System.Console.WriteLine("Turning light off");
        //        sw.state = new OffState();s
        //    }
        //}

        //public abstract class Statee {
        //    public virtual void On(Switch sw) { System.Console.WriteLine("Light already on"); }
        //    public virtual void Off(Switch sw) { System.Console.WriteLine("Light already off"); }
        //}

        ////Handmade state machine
        //public enum State
        //{
        //    OffHook,
        //    Connecting,
        //    Connected,
        //    OnHold
        //}

        //public enum Trigger 
        //{
        //    CallDialed,
        //    HungUp,
        //    CallConnected,
        //    PlacedOnHold,
        //    TakenOffHold,
        //    LeftMessage
        //}


        //Switch based state machine
        public enum State
        {
            Locked,
            Failed,
            Unlocked
        }


    }
}