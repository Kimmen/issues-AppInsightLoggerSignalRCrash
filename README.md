# issues-AppInsightLoggerSignalRCrash

Add a local.settings.json in project folder
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "<connection string to storage account>",
    "AzureWebJobsDashboard": "<connection string to storage account>",
    "COSMOS_CONNECTION_STRING": "<connection string to cosmosdb account>",
    "SIGNALR_CONNECTIONSTRING": "<connection string to signalr services account>",
    "FUNCTIONS_EXTENSION_VERSION": "beta",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "APPINSIGHTS_INSTRUMENTATIONKEY": "<instrumentation key to a AppInsights account>"
  }
}
