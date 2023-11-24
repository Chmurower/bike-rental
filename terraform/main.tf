provider "azurerm" {
  subscription_id = var.azure_subscription_id
  client_id       = var.azure_client_id
  client_secret   = var.azure_client_secret
  tenant_id       = var.azure_tenant_id
  features {}
}

resource "azurerm_resource_group" "rg" {
  name     = "bike-rental-rg"
  location = "Poland Central"
}

resource "azurerm_app_service_plan" "plan" {
  name                = "myAppServicePlan"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name

  sku {
    tier = "Standard"
    size = "S1"
  }
}

resource "azurerm_app_service" "backend" {
  name                = "bike-rental-backend"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  app_service_plan_id = azurerm_app_service_plan.plan.id

  site_config {
    always_on        = true
    linux_fx_version = "DOCKER|${var.dockerhub_username}/bike-rental-backend:0.1.86"
  }

  app_settings = {
    "WEBSITES_ENABLE_APP_SERVICE_STORAGE" = "false"
  }
}

resource "azurerm_app_service" "frontend" {
  name                = "bike-rental-frontend"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  app_service_plan_id = azurerm_app_service_plan.plan.id

  site_config {
    always_on        = true
    linux_fx_version = "DOCKER|${var.dockerhub_username}/bike-rental-frontend:0.1.98"
  }

  app_settings = {
    "WEBSITES_ENABLE_APP_SERVICE_STORAGE" = "false"
  }
}

resource "azurerm_app_service" "frontend" {
  name                = "bike-rental-frontend"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  app_service_plan_id = azurerm_app_service_plan.plan.id

  site_config {
    always_on        = true
    linux_fx_version = "DOCKER|${var.dockerhub_username}/bike-rental-frontend:0.1.98"
  }

  app_settings = {
    "WEBSITES_ENABLE_APP_SERVICE_STORAGE" = "false"
  }
}