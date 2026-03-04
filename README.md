# test-vibe-agent

API Web ASP.NET Core avec endpoint de ping pour vérification de connectivité.

## Fonctionnalités

- **GET /ping** : Retourne "pong" pour vérifier que l'API est accessible

## Démarrage rapide

```bash
# Restaurer les packages NuGet
dotnet restore

# Lancer l'application en mode développement
dotnet run
```

L'API sera accessible par défaut sur `https://localhost:5001` (HTTPS) et `http://localhost:5000` (HTTP).

## Test de l'endpoint

```bash
curl http://localhost:5000/ping
# Retourne: pong
```

## Structure du projet

```
├── Controllers/
│   └── PingController.cs    # Contrôleur avec endpoint GET /ping
├── Program.cs               # Point d'entrée et configuration de l'application
├── test-vibe-agent.csproj   # Fichier projet .NET
└── README.md               # Documentation
```