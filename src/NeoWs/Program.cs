using CommandLine;
using NeoWs.Verbs;
using NeoWs.Verbs.Parsers;
using System.Collections.Generic;

namespace NeoWs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<MarsPhotoVerb, AsteroidVerb>(args)
                .MapResult(
                (MarsPhotoVerb opts) => new MarsPhotoParser().PhotoParse(opts).GetAwaiter().GetResult(),
                (AsteroidVerb opts) => new AsteroidParser().ParseAstro(opts).GetAwaiter().GetResult(),
                (IEnumerable<Error> errs) => new ExeptionParser().ExceptionHandling(errs).GetAwaiter().GetResult());
        }

    }
}