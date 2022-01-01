using CommandLine;

namespace NeoWs.Verbs
{
    [Verb("asteroid", HelpText = "Get Asteroid info.")]
    public class AsteroidVerb
    {
        [Option('i', "info", Required = true, HelpText = "All info")]
        public string Asteroid { get; set; }
    }
}
