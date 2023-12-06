param location string

@description('App Service Plan Viscera')
resource aspviscera 'Microsoft.Web/serverfarms@2022-09-01' = {
  name: 'asp-viscera'
  kind: 'linux'
  location: location
  sku: {
    name: 'F1'
    tier: 'Free'
    size: 'F1'
    family: 'F'
    capacity: 1
  }
}

@description('Web App Viscera Web API')
resource appviscerawebapi  'Microsoft.Web/sites@2021-02-01' = {
  name: 'app-viscera-web-api'
  location: location
  properties: {
    serverFarmId: aspviscera.id
  }
}
