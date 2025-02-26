terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "4.16.0"
    }
  }

  required_version = ">= 1.0"

   backend "azurerm" {
    resource_group_name   = "your-resource-group-name"
    storage_account_name  = "yourstorageaccountname"
    container_name        = "your-container-name"
    key                    = "terraform.tfstate"
  }
}


provider "azurerm" {
  features {}

  # Authenticate using the Azure CLI (if logged in)
  # You can skip the `client_id`, `client_secret`, `tenant_id`, and `subscription_id` if using Azure CLI or Managed Identity
  subscription_id = var.subscription_id
}
