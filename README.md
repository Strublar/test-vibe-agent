# test-vibe-agent

Application C# Web API exposant une API HTTP simple avec une route GET `/ping` qui renvoie `pong`.

## 🚀 Démarrage rapide

### Prérequis
- .NET 8.0 SDK ou version supérieure

### Installation et lancement

```bash
# Cloner le repository
git clone <repository-url>
cd test-vibe-agent

# Restaurer les dépendances
dotnet restore

# Lancer l'application
dotnet run
```

L'application sera disponible sur :
- HTTP : http://localhost:5000
- HTTPS : https://localhost:5001

### API Endpoints

#### GET /ping
Endpoint de test qui renvoie "pong"

**Exemple de requête :**
```bash
curl http://localhost:5000/ping
```

**Réponse :**
```
pong
```

## 🛠️ Développement

### Structure du projet

```
test-vibe-agent/
├── Program.cs                    # Point d'entrée et configuration de l'application
├── test-vibe-agent.csproj      # Fichier de projet C#
├── appsettings.json             # Configuration de l'application (production)
├── appsettings.Development.json # Configuration pour l'environnement de développement
├── Properties/
│   └── launchSettings.json     # Configuration de lancement (profils de debug)
└── README.md                   # Documentation du projet
```

### Configuration

La configuration est gérée via les fichiers `appsettings.json` et `appsettings.Development.json`.

Le serveur Kestrel est configuré pour écouter sur :
- Port 5000 (HTTP)
- Port 5001 (HTTPS)

### Swagger UI

En mode développement, l'interface Swagger est disponible sur :
- https://localhost:5001/swagger
- http://localhost:5000/swagger

## 🏗️ Technologies utilisées

- **.NET 8.0** - Framework de développement
- **ASP.NET Core** - Framework web
- **Kestrel** - Serveur HTTP
- **Swagger/OpenAPI** - Documentation de l'API (développement)

## 📝 Notes

Ce projet a été créé dans le cadre de la PR #1 "Setup projet et configuration initiale" pour initialiser la structure de base de l'application Web API.