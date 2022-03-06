using Input.ConsoleImpl;
using Input.Core;

namespace Input.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InputManagerBase inputManager = new InputManagerBase();
            inputManager.AddInputHelper(new ConsoleKeyBoardHelper());
            inputManager.RegisterOpInputCode(OperateCode.Up, ConsoleInputCode.W);
            inputManager.RegisterOpCallback(OperateCode.Up, (userData) =>
            {
                Console.WriteLine("press up");
            });

            bool run = true;
            inputManager.RegisterOpInputCode(OperateCode.Exit, ConsoleInputCode.ESC);
            inputManager.RegisterOpCallback(OperateCode.Exit, (userData) =>
            {
                Console.WriteLine("press esc");
                run = false;
            });
            while (run)
                inputManager.Update();
        }
    }
}