## Create Migratinos ## 

dotnet ef migrations add `Name_Migration` --startup-project ../OpenSauce.Presentation --project ../OpenSauce.Infrastructure/Infrastructure

## Update DB ##

dotnet ef database update --startup-project ../OpenSauce.Presentation --project ../OpenSauce.Infrastructure/Infrastructure