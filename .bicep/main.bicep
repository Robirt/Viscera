targetScope = 'subscription'

param location string = 'West Europe'

@description('Viscera Resource Group')
resource resourceGroup 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: 'rg-viscera'
  location: location
}

@description('Viscera.WebAPI module')
module webapi 'Viscera.WebAPI/main.bicep' = {
  name: 'Viscera.WebAPI'
  scope: resourceGroup
  params: {
    location: location
  }
}

@description('Viscera.WebUI module')
module webui 'Viscera.WebUI/main.bicep' = {
  name: 'Viscera.WebUI'
  scope: resourceGroup
  params: {
    location: location
  }
}
