# how to get it to run.

- Add a local.settings.json in project folder
- Insert text from below and update the proper settings:
```javascript
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
```

- In **Functions.cs** update the follow constants to proper values:
```csharp
  public const string DatabaseName = "<insert databasename>";
  public const string CollectionName = "<insert collectionname>";
  public const string HubName = "<insert hubname>";
  public const string LeaseCollectioneName = "leases";
```
