using CommandLine;

namespace NeoWs
{
    [Verb("location", HelpText = "Select folder to save.")]
    public class MarsPhotoVerb
    {
        [Option('f', "folder", Required = true, HelpText = "Folder to save.")]
        public string Folder { get; set; }
    }
}
