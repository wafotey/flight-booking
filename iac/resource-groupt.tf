resource "azurerm_resource_group" "resource-group-flight-booking" {
  name     = "dept-dev-resource-group-flight-booking"
  location = "Central US"

   tags = {
    environment = "Development"  # Example tag: key = "Environment", value = "Development"
    src = var.src_key
  }
}