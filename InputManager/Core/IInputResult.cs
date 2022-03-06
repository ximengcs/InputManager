
namespace Input.Core
{
    public interface IInputResult
    {
        bool IsSuccess { get; }
        object Data { get; }
    }
}
