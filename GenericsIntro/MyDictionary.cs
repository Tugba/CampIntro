using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<TKey,TValue>
    {
        internal int count;
        TKey[] _arrayKeys;
        TValue[] _arrayValues;

        TKey[] _tempArrayKey;
        TValue[] _tempArrayValue;

        public MyDictionary()
        {
            _arrayKeys = new TKey[0];
            _arrayValues = new TValue[0];
        }

        public int Count { get; internal set; }

        public void Add(TKey key,TValue value)
        {
            _tempArrayKey = _arrayKeys; //geçici dizi
            _tempArrayValue = _arrayValues; //geçici dizi

            _arrayKeys = new TKey[_arrayKeys.Length + 1];
            _arrayValues = new TValue[_arrayValues.Length + 1];

            for (int i = 0; i < _tempArrayKey.Length; i++)
            {
                _arrayKeys[i] = _tempArrayKey[i];
            }
            for (int j = 0; j < _tempArrayValue.Length; j++)
            {
                _arrayValues[j] = _tempArrayValue[j];

            }
            _arrayKeys[_arrayKeys.Length - 1] = key;
            _arrayValues[_arrayValues.Length - 1] = value;


            

        }
       
       
    }
}
