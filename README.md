# SimpleTextProvider
Simple text provider for Unity. Allows you to store texts inside of databases

Usage:

Odin inspector is required!

1. Create asset of type "Text Provider Database"
2. Use it directly or add TextProviderTMP to a game object with TextMeshProUGUI component to auto provide texts for it
3. Assign some key and the created database to the component
4. Add text for the key to the created database
5. Check "Fill on Start" checkbox to automatically fill texts or use FillText() method on the component. There is also an override for FillText that supports string format. Arguments for string format should be put into texts database
