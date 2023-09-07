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

        protected override void Setup()
        {
            if (_label == null)
                _label = GetComponent<TextMeshProUGUI>();
        }

        protected override void SetLabelText(string text)
        {
            if (_label == null)
                Setup();

            _label.text = text;
        }
    }
}