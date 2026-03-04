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
├── test-vibe-agent.csproj       # Fichier de projet .NET
├── appsettings.json             # Configuration de l'application
├── appsettings.Development.json # Configuration pour le développement
├── .gitignore                   # Fichiers à ignorer par Git
└── README.md                    # Ce fichier
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

## Endpoints disponibles

### GET /ping
- **Description** : Endpoint de test qui retourne "pong"
- **Réponse** : `"pong"`
- **Status Code** : 200

### GET /
- **Description** : Endpoint racine avec informations sur l'API
- **Réponse** : JSON avec informations générales

## Documentation API

Quand l'application est lancée en mode développement, Swagger UI est disponible à la racine : https://localhost:5001

## Technologies utilisées

- ASP.NET Core 8.0
- Swagger/OpenAPI pour la documentation
- Kestrel comme serveur web