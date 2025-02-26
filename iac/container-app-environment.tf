resource "azurerm_container_app_environment" "container_app_environment" {
  name                       = "DeptDevContainerAppEnvironmentFlightBooking"
  location                   = azurerm_resource_group.resource-group-flight-booking.location
  resource_group_name        = azurerm_resource_group.resource-group-flight-booking.name
  log_analytics_workspace_id = azurerm_log_analytics_workspace.log-analytics-workspace-flight-booking.id
  
    tags = {
    environment = "Development"  # Example tag: key = "Environment", value = "Development"
    src = var.src_key
  }
}