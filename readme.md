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
git add .
git commit -m 
#TDD
Test driven Development
Créer le dossier de tests: 
mkdir Isen.DotNet.tests
Connaitre une liste des news: dotnet new -h

dotnet new xunit 

Ajouter ce projet à la solution (depuis la racine)
dotnet sln add reference  Isen.Dotnet.Tests 

Depuis le dossier du projet tests:
dotnet add reference
 ../Isen.Dotnet.Library/Isen.DotNet.Library.csproj'

 git add .
 git commit -m "Test project"
 ## Push du projet sur un repo remote 
 git remote add origin "URL"
 Push en indiquand que master correspond à origin/master


 git push -u origin master

 ## Ajout d'un tag Git
 git tag v0.1
Pushe le tag dans le remote repo
git push origin v0.1