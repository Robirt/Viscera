param location string

@description('Static Web App Viscera Web UI')
resource stappviscerawebui 'Microsoft.Web/staticSites@2022-09-01' = {
  name: 'stapp-viscera-web-ui'
  location: location
  properties: {
    stagingEnvironmentPolicy: 'Enabled'
    allowConfigFileUpdates: true
    provider: 'None'
    enterpriseGradeCdnStatus: 'Disabled'
  }
  sku: {
    name: 'Free'
    tier: 'Free'
  }
}
