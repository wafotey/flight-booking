resource "azurerm_container_registry" "container-registry-flight-booking" {
  name                = "deptDevAcrTranslation"  
  resource_group_name = azurerm_resource_group.resource-group-flight-booking.name
  location            = azurerm_resource_group.resource-group-flight-booking.location
  sku                  = "Standard"           # Set the SKU to Standard

  admin_enabled = true  # Enable admin user for registry access
  
  tags = {
    environment = "Development"  # Example tag: key = "Environment", value = "Development"
    src = var.src_key
  }
}