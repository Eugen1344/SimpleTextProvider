using UnityEngine;

namespace SimpleTextProvider
{
    [CreateAssetMenu(menuName = "Text Provider Database")]
    public class TextProviderDatabase : ScriptableObject
    {
        private const string MissingTextMessage = "[missing text: {0}]";
        private const string MissingKeyMessage = "[missing key]";

        [SerializeField] private SerializedDictionary<string, string> _texts;

        public string GetText(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return MissingKeyMessage;

            if (_texts.TryGetValue(key, out string text))
                return text;

            return string.Format(MissingTextMessage, key);
        }

        public bool ContainsKey(string key)
        {
            return _texts.ContainsKey(key);
        }
    }
}