﻿using UnityEngine;

namespace SimpleTextProvider
{
    public abstract class AbstractTextProvider : MonoBehaviour
    {
        [SerializeField] private string _key;
        [SerializeField] private bool _fillOnStart;
        [SerializeField] private TextProviderDatabase _database;

        public abstract void Setup();
        protected abstract void SetLabelText(string text);

        private void Start()
        {
            Setup();

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
            string providedText = _database.GetText(_key);
            return providedText;
        }
    }
}