using System;
using TMPro;
using UnityEngine;

namespace SimpleTextProvider
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextProviderTMP : AbstractTextProvider
    {
        private TextMeshProUGUI _label;

        private void Awake()
        {
            Setup();
        }

        public override void Setup()
        {
            if (_label == null)
                _label = GetComponent<TextMeshProUGUI>();
        }

        protected override void SetLabelText(string text)
        {
            if (_label == null)
                throw new NullReferenceException("Call Setup() or wait for Awake before filling text");

            _label.text = text;
        }
    }
}