using UnityEngine;

namespace SimpleTextProvider
{
    [CreateAssetMenu(menuName = "Text Provider Database")]
    public class TextProviderDatabase : ScriptableObject
    {
        [SerializeField] private SerializedDictionary<string, string> _texts;

        public string GetText(string key)
        {
            if (_texts.TryGetValue(key, out string text))
                return text;

            return null;
        }

        public bool ContainsKey(string key)
        {
            return _texts.ContainsKey(key);
        }
    }
}