variable "env_id" {
  description = "This is an environment variable."
  type        = string
  default     = "dev"
}
variable "subscription_id" {
  description = "Azure subscription id"
  type        = string
  default     = "ad50654f-ef25-40ea-a007-1b57fba94baa"
}
variable "src_key" {
  description = "Azure subscription id"
  type        = string
  default     = "terraform"
}

variable "sql_password" {
  description = "Sql password"
  type        = string
}
