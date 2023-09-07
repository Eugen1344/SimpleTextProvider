using UnityEngine;

namespace SimpleTextProvider
{
    public abstract class AbstractTextProvider : MonoBehaviour
    {
        public string Key;
        public bool FillOnStart;

        [SerializeField] private TextProviderDatabase _database;

        protected abstract void Setup();
        protected abstract void SetLabelText(string text);

        private void Start()
        {
            Setup();

            if (FillOnStart)
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
            string providedText = _database.GetText(Key);
            return providedText;
        }
    }
}