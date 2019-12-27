using System;

namespace TwitterStormTests {
    public class TwitesGenerator {
        private const int TwiteCharacterLimit = 160;

        public string[] Generate(string textsToTwite) {
            if (string.IsNullOrWhiteSpace(textsToTwite)) {
                return Array.Empty<string>();
            }
            
            var totalSizeCharacter = (int)Math.Ceiling((double)textsToTwite.Length / TwiteCharacterLimit);
            var twiterList = new string[totalSizeCharacter];
            var characterSize = textsToTwite.Length;
            
            for (int i = 0; i < totalSizeCharacter; i++) {
                var lengthToUse = Math.Min(characterSize, TwiteCharacterLimit);
                var twite = textsToTwite.Substring(i * TwiteCharacterLimit, lengthToUse);
                twiterList[i] = twite;
                characterSize = characterSize - TwiteCharacterLimit;
            }

            return twiterList;
        }
    }
}