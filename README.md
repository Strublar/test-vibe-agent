# test-vibe-agent

Une API HTTP simple en C# ASP.NET Core exposant un endpoint ping qui renvoie pong.

## 🚀 Démarrage rapide

### Prérequis

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou version ultérieure
- Un éditeur de code (Visual Studio, Visual Studio Code, JetBrains Rider)

### Installation et démarrage

1. **Cloner le repository**
   ```bash
   git clone <repository-url>
   cd test-vibe-agent
   ```

2. **Restaurer les dépendances**
   ```bash
   dotnet restore
   ```

3. **Lancer l'application**
   ```bash
   dotnet run --project test-vibe-agent
   ```

4. **Tester l'endpoint**
   
   L'application démarre par défaut sur `https://localhost:5001` et `http://localhost:5000`
   
   ```bash
   curl http://localhost:5000/ping
   # Réponse attendue: pong
   ```

## 📋 API Documentation

### Endpoint disponible

#### GET /ping
- **Description** : Endpoint de vérification de santé qui renvoie "pong"
- **URL** : `/ping`
- **Méthode** : `GET`
- **Paramètres** : Aucun
- **Réponse** : 
  - **Code** : `200 OK`
  - **Content-Type** : `text/plain; charset=utf-8`
  - **Body** : `pong`

### Exemples d'utilisation

#### cURL
```bash
curl -X GET http://localhost:5000/ping
```

#### PowerShell
```powershell
Invoke-RestMethod -Uri "http://localhost:5000/ping" -Method Get
```

#### JavaScript (fetch)
```javascript
fetch('http://localhost:5000/ping')
  .then(response => response.text())
  .then(data => console.log(data)); // Affiche: pong
```

### 📮 Collection Postman

Une collection Postman complète est disponible dans le dossier `postman/` avec :
- Tests automatisés pour l'endpoint ping
- Environnements préconfigurés (local HTTP/HTTPS)
- Validation des réponses et performances

#### Import dans Postman
1. Ouvrir Postman
2. Cliquer sur "Import"
3. Sélectionner les fichiers :
   - `postman/test-vibe-agent.postman_collection.json`
   - `postman/test-vibe-agent.postman_environment.json`
4. Sélectionner l'environnement "test-vibe-agent - Local"
5. Exécuter la collection

## 🧪 Tests

### Lancer les tests unitaires

```bash
dotnet test
```

### Lancer les tests avec couverture de code

```bash
dotnet test --collect:"XPlat Code Coverage"
```

### Tests inclus

Le projet contient des tests unitaires complets dans `PingControllerTests.cs` :

- ✅ **Test de base** : Vérification que `/ping` renvoie `pong` avec status 200
- ✅ **Test Content-Type** : Validation du type de contenu `text/plain`
- ✅ **Test insensibilité à la casse** : Vérification que `/ping`, `/Ping`, `/PING` fonctionnent
- ✅ **Test de performance** : Vérification que 100 requêtes concurrentes s'exécutent en moins de 5 secondes

### Couverture de code attendue

- **PingController** : 100%
- **Endpoint ping** : 100%

## 🏗️ Structure du projet

```
test-vibe-agent/
├── test-vibe-agent/                 # Projet principal
│   ├── Controllers/
│   │   └── PingController.cs        # Contrôleur pour l'endpoint ping
│   ├── Program.cs                   # Point d'entrée de l'application
│   └── test-vibe-agent.csproj       # Fichier de projet
├── test-vibe-agent.Tests/           # Projet de tests
│   ├── PingControllerTests.cs       # Tests unitaires
│   └── test-vibe-agent.Tests.csproj # Fichier de projet de tests
├── postman/                         # Collection Postman
│   ├── test-vibe-agent.postman_collection.json
│   └── test-vibe-agent.postman_environment.json
└── README.md                        # Ce fichier
```

## 🔧 Configuration

### Environnements

- **Development** : Configuration par défaut pour le développement local
- **Production** : Configuration optimisée pour la production

### Ports par défaut

- **HTTPS** : `5001`
- **HTTP** : `5000`

### Variables d'environnement

Aucune variable d'environnement spécifique n'est requise pour ce projet simple.

## 📚 Technologies utilisées

- **Framework** : ASP.NET Core 8.0
- **Language** : C# 12
- **Tests** : xUnit, Microsoft.AspNetCore.Mvc.Testing
- **Build** : .NET SDK

## 🤝 Contribution

1. Fork le projet
2. Créer une branche pour votre fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commit vos changements (`git commit -m 'Add some AmazingFeature'`)
4. Push vers la branche (`git push origin feature/AmazingFeature`)
5. Ouvrir une Pull Request

## 📝 License

Ce projet est sous licence MIT. Voir le fichier `LICENSE` pour plus de détails.

## 🎯 Roadmap

- [x] Endpoint ping basique
- [x] Tests unitaires
- [x] Documentation
- [x] Collection Postman
- [ ] Swagger/OpenAPI documentation
- [ ] Docker support
- [ ] Logging avancé
- [ ] Métriques et monitoring