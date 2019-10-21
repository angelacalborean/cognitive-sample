using System;

namespace Microsoft.Azure.CognitiveServices.Samples.TextAnalytics
{
    public static class Program
    {
        private const string SubscriptionKey = "";
        private const string Endpoint = "";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SentimentAnalysisSample.RunAsync(Endpoint, SubscriptionKey).Wait();
            
            //LanguageDetectionSample.RunAsync(Endpoint, SubscriptionKey).Wait();
            
            //RecognizeEntitiesSample.RunAsync(Endpoint, SubscriptionKey).Wait();
            
            //KeyPhraseExtractionSample.RunAsync(Endpoint, SubscriptionKey).Wait();

            Console.WriteLine("\nPress any to exit.");
            Console.ReadKey();
        }
    }
}