using System;

namespace Input.Core
{
    public interface IInputManager
    {
        void AddInputHelper(IInputControllerHelper helper);
        void RemoveInputHelper(IInputControllerHelper helper);
        void RegisterOpCallback(int opCode, Action<object> callback);
        void UnRegisterOpCallback(int opCode, Action<object> callback);
        void RegisterOpInputCode(int opCode, int inputCode);
        void UnRegisterOpInputCode(int opCode, int inputCode);
    }
}