resource "azurerm_container_registry" "container_registry_flight_booking" {
  name                = "deptDevAcrgFlightBooking"  # Set the name for the container registry
  resource_group_name = azurerm_resource_group.resource_group_flight_booking.name
  location            = azurerm_resource_group.resource_group_flight_booking.location
  sku                  = "Standard"           # Set the SKU to Standard

  admin_enabled = true  # Enable admin user for registry access
  
  tags = {
    environment = "Development"  # Example tag: key = "Environment", value = "Development"
    src = var.src_key
  }
}