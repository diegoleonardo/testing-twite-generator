using System.Collections.Generic;

namespace TwitterStormTests {
    public class TwitesGenerator {
        private const int TwiteLimit = 160;

        public string[] Generate(string textToSplit) {
            var twiteList = new List<string>();
            if (string.IsNullOrWhiteSpace(textToSplit)) {
                return twiteList.ToArray();
            }
            var splittedText = textToSplit.ToCharArray();
            var count = 0;
            var characters = string.Empty;

            for (int i = 0; i < splittedText.Length; i++) {
                if (count == TwiteLimit) {
                    twiteList.Add(characters);
                    characters = string.Empty;
                    count = 0;
                }

                characters += splittedText[i];

                if (i == splittedText.Length - 1) {
                    twiteList.Add(characters);
                }

                count++;
            }

            return twiteList.ToArray();
        }
    }
}