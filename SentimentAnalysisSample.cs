﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace Microsoft.Azure.CognitiveServices.Samples.TextAnalytics
{
    public static class SentimentAnalysisSample
    {
        public static async Task RunAsync(string endpoint, string key)
        {
            Console.WriteLine("===== Sentiment Analysis =====\n");

            var credentials = new ApiKeyServiceClientCredentials(key);
            var client = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };

            // The documents to be analyzed. Add the language of the document. The ID can be any value.
            var inputDocuments = new MultiLanguageBatchInput(
                new List<MultiLanguageInput>
                {
                    new MultiLanguageInput("1", "I had the best day of my life.", "en"),
                    new MultiLanguageInput("2", "This was a waste of my time. The speaker put me to sleep.", "en"),
                    new MultiLanguageInput("3", "No tengo dinero ni nada que dar...", "es"),
                    new MultiLanguageInput("4", "L'hotel veneziano era meraviglioso. È un bellissimo pezzo di architettura.", "it"),
                });

            var result = await client.SentimentBatchAsync(inputDocuments);
            foreach (var document in result.Documents)
            {
                Console.WriteLine($"Text: {inputDocuments.Documents.FirstOrDefault(d => d.Id == document.Id)?.Text}\nSentiment Score: {document.Score:0.00}\n\n");
            }
        }
    }
}