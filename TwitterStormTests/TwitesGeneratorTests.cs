using NUnit.Framework;

namespace TwitterStormTests {
    public class Tests {
        private const string TextToSplit =
            @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.";

        private static object[] TextSplitted = {
            new object[] {
                TextToSplit,
                new[] {
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph."
                }
            },
            new object[] {
                TextToSplit + TextToSplit,
                new[] {
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph."
                }
            },
            new object[] {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                new[] {
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                }
            },
            new object[] {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.L",
                new[] {
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.",
                    "L"
                }
            },
            new object[] {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph. ",
                new[] {
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis sollicitudin nibh, a pharetra metus pretium id. nibh, a pharetraa, a pharetraa, a ph.",
                    " "
                }
            },
            new object[] {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                new[] {
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                }
            },
            new object[] {
                "",
                new string[] {}
            },
            new object[] {
                null,
                new string[] {}
            }
        };

        [TestCaseSource(nameof(TextSplitted))]
        public void GetTwittes_WhenReceveingText_ShouldReturnTwites(string textToSplit,string[] expected) {
            var twitesGenerator = new TwitesGenerator();
            var result = twitesGenerator.Generate(textToSplit);

            Assert.AreEqual(expected.Length, result.Length);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}