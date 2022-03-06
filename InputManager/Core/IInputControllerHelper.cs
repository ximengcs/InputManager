using System;

namespace Input.Core
{
    public interface IInputControllerHelper
    {
        IInputResult Check(int inputCode);
    }
}