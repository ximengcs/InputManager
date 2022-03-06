using Input.Core;

namespace Input.ConsoleImpl
{
    public class ConsoleKeyBoardHelper : IInputControllerHelper
    {
        public IInputResult Check(int inputCode)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            switch (inputCode)
            {
                case ConsoleInputCode.A:
                    if (info.Key == ConsoleKey.A)
                        return new Result(true, info.KeyChar);
                    break;

                case ConsoleInputCode.S:
                    if (info.Key == ConsoleKey.S)
                        return new Result(true, info.KeyChar);
                    break;

                case ConsoleInputCode.D:
                    if (info.Key == ConsoleKey.D)
                        return new Result(true, info.KeyChar);
                    break;

                case ConsoleInputCode.W:
                    if (info.Key == ConsoleKey.W)
                        return new Result(true, info.KeyChar);
                    break;

                case ConsoleInputCode.ESC:
                    if (info.Key == ConsoleKey.Escape)
                        return new Result(true, info.KeyChar);
                    break;
            }

            return new Result(false, null);
        }

        public class Result : IInputResult
        {
            private bool m_Success;
            private object m_Data;

            public Result(bool success, object data)
            {
                m_Success = success;
                m_Data = data;
            }

            public bool IsSuccess
            {
                get
                {
                    return m_Success;
                }
            }

            public object Data
            {
                get
                {
                    return m_Data;
                }
            }
        }
    }
}
