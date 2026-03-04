# test-vibe-agent

API Web ASP.NET Core simple avec endpoint ping/pong.

## Description

Cette application expose une API HTTP minimaliste avec un endpoint GET `/ping` qui retourne `"pong"`.

## Prérequis

- .NET 8.0 SDK

## Structure du projet

```
test-vibe-agent/
├── Program.cs                    # Point d'entrée et configuration de l'application
├── Controllers/
│   └── PingController.cs         # Contrôleur avec endpoint ping
├── Tests/
│   └── PingControllerTests.cs    # Tests unitaires pour le contrôleur ping
├── test-vibe-agent.csproj        # Fichier de projet .NET principal
├── test-vibe-agent.Tests.csproj  # Fichier de projet pour les tests
├── appsettings.json              # Configuration de l'application
├── appsettings.Development.json  # Configuration pour le développement
├── .gitignore                    # Fichiers à ignorer par Git
└── README.md                     # Ce fichier
```

## Installation et lancement

1. Cloner le repository
2. Se placer dans le dossier du projet
3. Restaurer les packages NuGet :
   ```bash
   dotnet restore
   ```
4. Lancer l'application :
   ```bash
   dotnet run
   ```

L'API sera disponible sur :
- HTTP : http://localhost:5000
- HTTPS : https://localhost:5001

## Tests unitaires

### Exécution des tests

Pour exécuter tous les tests unitaires :
```bash
dotnet test
```

Pour exécuter les tests avec plus de détails :
```bash
dotnet test --verbosity normal
```

Pour exécuter les tests avec couverture de code :
```bash
dotnet test --collect:"XPlat Code Coverage"
```

### Tests disponibles

Le projet inclut des tests unitaires pour l'endpoint ping qui vérifient :
- ✅ Retour d'une réponse HTTP 200 OK
- ✅ Retour de la chaîne exacte "pong"
- ✅ Aucune valeur null n'est retournée
- ✅ Idempotence de l'endpoint (même résultat à chaque appel)
- ✅ Performance de base (temps de réponse < 100ms)

### Structure des tests

Les tests sont organisés dans le projet `test-vibe-agent.Tests.csproj` et utilisent :
- **xUnit** comme framework de tests
- **Microsoft.AspNetCore.Mvc.Testing** pour les tests d'intégration
- **Coverlet** pour la couverture de code

## Endpoints disponibles

### GET /ping
- **Description** : Endpoint de test qui retourne "pong"
- **Réponse** : `"pong"`
- **Status Code** : 200 OK
- **Exemple** :
  ```bash
  curl https://localhost:5001/ping
  # Réponse: "pong"
  ```

### GET /
- **Description** : Endpoint racine avec informations sur l'API
- **Réponse** : JSON avec informations générales
- **Status Code** : 200 OK
- **Exemple** :
  ```bash
  curl https://localhost:5001/
  # Réponse: {"message":"Test Vibe Agent API","version":"1.0.0","endpoints":["/ping"]}
  ```

## Documentation API

Quand l'application est lancée en mode développement, Swagger UI est disponible à la racine : https://localhost:5001

La documentation interactive permet de :
- Explorer tous les endpoints disponibles
- Tester directement les endpoints depuis l'interface
- Voir les schémas de requête/réponse
- Télécharger la spécification OpenAPI

## Développement

### Commandes utiles

```bash
# Restaurer les dépendances
dotnet restore

# Compiler le projet
dotnet build

# Lancer l'application
dotnet run

# Lancer les tests
dotnet test

# Lancer les tests avec couverture
dotnet test --collect:"XPlat Code Coverage"

# Publier l'application
dotnet publish -c Release
```

### Contribution

Pour contribuer au projet :
1. Créer une branche pour votre fonctionnalité
2. Implémenter les changements
3. Ajouter/mettre à jour les tests unitaires
4. Vérifier que tous les tests passent : `dotnet test`
5. Créer une pull request

## Technologies utilisées

- **ASP.NET Core 8.0** - Framework web
- **Swagger/OpenAPI** - Documentation API
- **Kestrel** - Serveur web
- **xUnit** - Framework de tests unitaires
- **Microsoft.AspNetCore.Mvc.Testing** - Tests d'intégration ASP.NET Core
- **Coverlet** - Couverture de code