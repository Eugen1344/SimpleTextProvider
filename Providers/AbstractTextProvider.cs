using UnityEngine;

namespace SimpleTextProvider
{
    public abstract class AbstractTextProvider : MonoBehaviour
    {
        private const string MissingTextMessage = "[missing text]";
        private const string MissingKeyMessage = "[missing key]";

        [SerializeField] private string _key;
        [SerializeField] private bool _fillOnStart;
        [SerializeField] private TextProviderDatabase _database;

        protected abstract void SetLabelText(string text);

        private void Start()
        {
            if (_fillOnStart)
                FillText();
        }

        public void FillText()
        {
            string providedText = GetText();

            SetLabelText(providedText);
        }

        public void FillText(params object[] args)
        {
            string providedText = GetText();
            string text = string.Format(providedText, args);

            SetLabelText(text);
        }

        private string GetText()
        {
            if (string.IsNullOrWhiteSpace(_key))
                return MissingKeyMessage;

            string providedText = _database.GetText(_key);

            return providedText ?? MissingTextMessage;
        }
    }
}