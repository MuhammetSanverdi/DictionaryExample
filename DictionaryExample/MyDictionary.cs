namespace DictionaryExample
{
    class MyDictionary<T, X>
    {
        int[] _keys;
        string[] _values;
        public MyDictionary()
        {
            _keys = new int[0];
            _values = new string[0];
        }
        public void Add(int key, string value)
        {
            int[] _tempkeys = _keys;
            string[] _tempvalues = _values;
            _keys = new int[_keys.Length + 1];
            _values = new string[_values.Length+1];            
            for (int i = 0; i < _tempkeys.Length; i++)
            {
                _keys[i] = _tempkeys[i];
            }
            for (int i = 0; i < _tempvalues.Length; i++)
            {
                _values[i] = _tempvalues[i];
            }
            _keys[_keys.Length-1] = key;
            _values[_keys.Length-1] = value;
        }

        public int[] Keys
        {
            get { return _keys; }
        }
        public string[] Values
        {
            get { return _values; }
        }

    }
}
