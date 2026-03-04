# Hello World Project

Un programme JavaScript simple qui affiche "Hello World" dans la console.

## Description

Ce projet contient un fichier `hello.js` qui implémente un programme basique affichant "Hello World". Le code est structuré de manière propre et modulaire pour servir d'exemple ou de point de départ pour d'autres projets.

## Prérequis

- Node.js version 12.0.0 ou supérieure

## Installation

1. Clonez le repository ou téléchargez les fichiers
2. Naviguez vers le dossier du projet

```bash
cd hello-world-project
```

## Utilisation

### Exécution directe

```bash
node hello.js
```

### Avec npm

```bash
npm start
```

## Structure du projet

```
.
├── hello.js          # Fichier principal contenant le code Hello World
├── package.json       # Configuration du projet Node.js
├── .gitignore        # Fichiers à ignorer par Git
└── README.md         # Documentation du projet
```

## Fonctionnalités

- ✅ Affichage simple de "Hello World"
- ✅ Code modulaire et réutilisable
- ✅ Documentation complète
- ✅ Structure de projet professionnelle

## Développement

Le fichier `hello.js` exporte également la fonction `displayHelloWorld()` qui peut être utilisée dans d'autres modules :

```javascript
const { displayHelloWorld } = require('./hello.js');
displayHelloWorld(); // Affiche "Hello World"
```

## Licence

MIT

---

*Projet créé par Vibe Agent*