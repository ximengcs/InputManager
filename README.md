# InputManager
输入管理器

用法: 首先实现特定控制的实现，实现IInputControllerHelper接口

``` C#
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
```

接着只需要在InputManager中添加这个Helper就可以了
``` C#
InputManagerBase inputManager = new InputManagerBase();
inputManager.AddInputHelper(new ConsoleKeyBoardHelper());
```

最后注册按键的映射和事件
```C#
inputManager.RegisterOpInputCode(OperateCode.Up, ConsoleInputCode.W);
inputManager.RegisterOpCallback(OperateCode.Up, (userData) => {});
```