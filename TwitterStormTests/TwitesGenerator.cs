using System.Collections.Generic;

namespace TwitterStormTests {
    public class TwitesGenerator {
        private const int TwiteCharacterLimit = 160;

        public string[] Generate(string textsToTwite) {
            var twiteList = new List<string>();
            if (string.IsNullOrWhiteSpace(textsToTwite)) {
                return twiteList.ToArray();
            }
            
            var splittedText = textsToTwite.ToCharArray();
            var count = 0;
            var characters = string.Empty;

            for (int i = 0; i < splittedText.Length; i++) {
                if (count == TwiteCharacterLimit) {
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