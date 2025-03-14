resource "azurerm_mssql_server" "mssql_server_flight_booking" {
  name                         = "dept-dev-sqlserver-flight"
  resource_group_name          = azurerm_resource_group.resource_group_flight_booking.name
  location                     = azurerm_resource_group.resource_group_flight_booking.location
  version                      = "12.0"
  administrator_login          = "willichie"
  administrator_login_password = var.sql_password

   tags = {
    environment = "Development"  # Example tag: key = "Environment", value = "Development"
    src = var.src_key
  }
}

resource "azurerm_mssql_database" "mssql_database_flight_booking" {
  name         = "flight-booking"
  server_id    = azurerm_mssql_server.mssql_server_flight_booking.id
  collation    = "SQL_Latin1_General_CP1_CI_AS"
  license_type = "LicenseIncluded"
  max_size_gb  = 10
  sku_name     = "S0"
  zone_redundant = false

  tags = {
    environment = "Development"  # Example tag: key = "Environment", value = "Development"
    src = var.src_key
  }

  # prevent the possibility of accidental data loss
  lifecycle {
    prevent_destroy = false
  }
}

resource "azurerm_mssql_firewall_rule" "mssql_flight_booking_firewall_rule" {
  name             = "AllowAllAzureResources"
  server_id        = azurerm_mssql_server.mssql_server_flight_booking.id
  start_ip_address = "0.0.0.0"
  end_ip_address   = "0.0.0.0"
}