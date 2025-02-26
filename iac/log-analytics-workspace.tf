resource "azurerm_log_analytics_workspace" "log-analytics-workspace-flight-booking" {
  name                = "dept-dev-log-analytics-workspace-flight-booking"
  location            = azurerm_resource_group.resource-group-flight-booking.location
  resource_group_name = azurerm_resource_group.resource-group-flight-booking.name
  sku                 = "PerGB2018"
  retention_in_days   = 30
}