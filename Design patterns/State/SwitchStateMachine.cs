namespace Design_patterns.State
{
//     public enum State
//     {
//         Locked,
//         Unlocked,
//         Failed
//     }
//     
//     var code = "1132";
//     var state = State.Locked;
//     var entry = new StringBuilder();
//
//
//     while (true)
//     {
//         switch (state)
    //     {
    //         case State.Locked:
    //         entry.Append(Console.ReadKey().KeyChar);
    //
    //         if (entry.ToString() == code)
    //         {
    //             state = State.Unlocked;
    //             break;
    //         }
    //
    //         if (!code.StartsWith(entry.ToString()))
    //         {
    //             state = State.Failed;
    //         }
    //
    //         break;
    //         case State.Unlocked:
    //         Console.CursorLeft = 0;
    //         Console.WriteLine("Unlocked");
    //         return;
    //         case State.Failed:
    //         Console.CursorLeft = 0;
    //         Console.WriteLine("Failed");
    //         entry.Clear();
    //         state = State.Locked;
    //         break;
    //         default:
    //         return;
    //     }
//     }
// }
}