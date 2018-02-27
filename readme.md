git init
touch .gitignore
touch readme.md
code .


#Création de l'espace de travail
## Création d'un projet console
Depuis le dossier Isen.DotNet:
mkdir Isen.DotNet.ConsoleApp
cd Isen.DotNet.ConsoleApp
dotnet new console 
dotnet run

## Commit Git
Repository Remote
Depuis la racine du projet:
Etat des fichiers: git status
Tracker les fichiers: git add .
Ils sont maintenant suivis : git status 
Commit : (ajout à l'historique local)  git commit -m "Message de commit"
git commit -a -m "updated readme"

## Création d'un projet librairie
Depuis le dossier Isen.DotNet:
mkdir Isen.DotNet.Library
cd Isen.DotNet.Library
dotnet new classlib 
dotnet run

## Ajout de la librairie en référence du projet console
on se met dans le dossier vers lequel on veut incorporer une référence --> cd ../Isen.DotNet.Console
dotnet add reference ../Isen.DotNet.Library/Isen.DotNet.Library.csproj
#Création d'une solution et ajout des projets
Depuis le projet racine:
Ajouter le fichier solution : dotnet new sin
Ajouter le projet console: 
dotnet sln add
Isen.DotNet.ConsoleApp/Isen.DotNet.consoleApp.csproj
#Commit git
git add
git commit -m 