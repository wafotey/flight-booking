resource "azurerm_resource_group" "resource_group_flight_booking" {
  name     = "dept-dev-resource-group-flight-booking"
  location = "Central US"

   tags = {
    environment = "Development"  # Example tag: key = "Environment", value = "Development"
    src = var.src_key
  }
}