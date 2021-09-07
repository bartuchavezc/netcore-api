clean:
	dotnet clean
restore:
	dotnet restore
build:
	dotnet build
watch:
	dotnet watch --verbose run --project projects/app/aam-bonmark-api
start:
	dotnet run --project projects/app/aam-bonmark-api