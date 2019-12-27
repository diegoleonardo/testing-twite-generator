using System.Collections.Generic;

namespace TwitterStormTests {
    public class TwitesGenerator {
        private const int TwitLimit = 160;

        public string[] Generate(string textToSplit) {
            var twitesList = new List<string>();
            if (string.IsNullOrWhiteSpace(textToSplit)) {
                return twitesList.ToArray();
            }
            var splittedText = textToSplit.ToCharArray();
            var count = 0;
            var characters = string.Empty;

            for (int i = 0; i < splittedText.Length; i++) {
                if (count == TwitLimit) {
                    twitesList.Add(characters);
                    characters = string.Empty;
                    count = 0;
                }

                characters += splittedText[i];

                if (i == splittedText.Length - 1) {
                    twitesList.Add(characters);
                }

                count++;
            }

            return twitesList.ToArray();
        }
    }
}