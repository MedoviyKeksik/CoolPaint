using System;
using System.Collections.Generic;
using CoolPaint.Shapes;

namespace CoolPaint
{
    [Serializable]
    public class History
    {
        private int _index = -1;
        private List<BaseShape> _items;
        
        public History()
        {
            _items = new List<BaseShape>();
        }
        public List<BaseShape> Items
        {
            get => _items;
        }

        public BaseShape LastItem => Items[_index];

        public bool CanUndo
        {
            get => _index > 0 || _index == 0 && Items[_index].CanUndo();
        }

        public bool CanRedo
        {
            get => _index + 1 < Items.Count || _index >= 0 && Items[_index].CanRedo();
        }

        public bool Undo()
        {
            if (!CanUndo) return false;
            while (_index >= 0 && !Items[_index].Undo())
            {
                _index--;
            }

            return true;
        }

        public bool Redo()
        {
            if (!CanRedo) return false;
            if (_index == -1) _index++;
            while (_index < Items.Count && !Items[_index].Redo())
            {
                _index++;
            }
            
            return true;
        }

        private void CutOff()
        {
            if (_index >= 0 && !Items[_index].CanUndo()) _index--;
            if (_index + 1 < Items.Count)
            {
                var tmp = _index + 1;
                Items.RemoveRange(tmp, Items.Count - tmp);
            }
            
            if (_index >= 0)
                Items[_index].CutOff();
        }
        
        public void Add(BaseShape shape)
        {
            CutOff();
            Items.Add(shape);
            _index++;
        }
    }
}