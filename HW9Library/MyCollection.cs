namespace HW9Library
{
    public class MyCollection<IMovable>
    {
        private List<IMovable> _imovables = new List<IMovable>();
        public int amount
        {
            get { return _imovables.Count; }  
        }

        public void Add(IMovable item)
        {
            _imovables.Add(item);
        }
        public IMovable? GetValue(int index)
        {
            for (int i = 0; i < _imovables.Count; i++)
            {
                if(index == i)
                {
                    return _imovables[i];
                }
            }
            return default(IMovable);
        }
    }
}