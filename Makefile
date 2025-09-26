# Projeto principal
PROJECT = src/Api

# Comando padrão (executado quando você digita apenas "make")
default: run

# Rodar a aplicação
run:
	dotnet watch run --project $(PROJECT)