resource "azurerm_log_analytics_workspace" "log_analytics_workspace_flight_booking" {
  name                = "dept-dev-log-analytics-workspace-flight-booking"
  location            = azurerm_resource_group.resource_group_flight_booking.location
  resource_group_name = azurerm_resource_group.resource_group_flight_booking.name
  sku                 = "PerGB2018"
  retention_in_days   = 30
}