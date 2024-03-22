dotnet --version
dotnet new webapi -n
dotnet run
dotnet watch run(openapi)

Entity framework
conceitos
DbContext
DbSet<T>
Data Annotations: [Key]
public guid Id {get;set;}
[strongLength = 100]
public string Description{...}

Migrations

nuGet gallery
ctrl + shift + p
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Tools

gof : solid

s responsabilidade unica
o principio do aberto e fechado
l principio da substituição de liskov (ñ quebrar) se quebrar , criar interface
i principio da segregação de interface
d principio da inversão de dependencia (passar o cara no construtor)
