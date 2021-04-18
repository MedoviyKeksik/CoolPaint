namespace CoolPaint
{
    public interface IUndovable
    {
        void CutOff();
        bool CanUndo();
        bool CanRedo();
        bool Undo();
        bool Redo();
    }
}