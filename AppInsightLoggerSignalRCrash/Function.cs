using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;
using Microsoft.Azure.WebJobs.Host;

namespace AppInsightLoggerSignalRCrash
{
    public static class Function
    {
        public const string DatabaseName = "<insert databasename>";
        public const string CollectionName = "<insert collectionname>";
        public const string HubName = "<insert hubname>";
        public const string LeaseCollectioneName = "leases";

        [FunctionName("Function")]
        public static async Task Run(
            [CosmosDBTrigger(
            databaseName: DatabaseName,
            collectionName: CollectionName,
            ConnectionStringSetting = "COSMOS_CONNECTION_STRING",
            LeaseCollectionName = LeaseCollectioneName,
            CreateLeaseCollectionIfNotExists = true)]IReadOnlyList<Document> documents,
            [SignalR(ConnectionStringSetting = "SIGNALR_CONNECTIONSTRING", HubName = HubName)]IAsyncCollector<SignalRMessage> signalRMessages,
            TraceWriter log)
        {
            if (documents != null && documents.Count > 0)
            {
                foreach (var document in documents)
                {
                    await signalRMessages.AddAsync(new SignalRMessage
                    {
                        Target = "DocumentUpdate",
                        Arguments = new object[] {document}
                    });
                }
            }
        }
    }
}
